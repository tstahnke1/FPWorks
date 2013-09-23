﻿// http://www.quanttec.com/fparsec/users-guide/debugging-a-parser.html

[<AutoOpen>]
module Propagate

type Propagation<'s, 'r> =
    | Propagation of 's * 'r list
    override this.ToString () =
        match this with Propagation (state, recordings) -> "State: " + str state + " Recordings: " + List.joinBy str " " recordings

let inline ( >>. ) (propagation : Propagation<'s, 'r>) ((setter : ('s -> 't)), (recorder : 't -> 'r)) =
    match propagation with
    | Propagation (state, recordings) ->
        let newState = setter state
        Propagation (newState, recorder newState :: recordings)

let inline ( >. ) (propagation : Propagation<'s, 's>) (setter : ('s -> 's)) : Propagation<'s, 's> =
    ( >>. ) propagation (setter, id)

[<AutoOpen>]
module Propagate =

    let propagate state =
        Propagation (state, [])