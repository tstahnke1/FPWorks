﻿namespace InfinityRpg
open OpenTK
open Nu
open InfinityRpg

[<RequireQualifiedAccess>]
module Simulants =

    // nu splash screen
    let Splash = !> "Splash"

    // title screen
    let Title = !> "Title"
    let TitleGui = Title => "Gui"
    let TitleNewGame = TitleGui => "NewGame"
    let TitleLoadGame = TitleGui => "LoadGame"
    let TitleCredits = TitleGui => "Credits"
    let TitleExit = TitleGui => "Exit"

    // credits screen
    let Credits = !> "Credits"
    let CreditsGui = Credits => "Gui"
    let CreditsBack = CreditsGui => "Back"

    // gameplay screen
    let Gameplay = !> "Gameplay"
    let Hud = Gameplay => "Hud"
    let HudBack = Hud => "Back"
    let HudSaveGame = Hud => "SaveGame"
    let HudHalt = Hud => "Halt"
    let HudFeeler = Hud => "Feeler"
    let HudDetailUp = Hud => "DetailUp"
    let HudDetailRight = Hud => "DetailRight"
    let HudDetailDown = Hud => "DetailDown"
    let HudDetailLeft = Hud => "DetailLeft"
    let Scene = Gameplay => "Scene"
    let Field = Scene => "Field"
    let Player = Scene => "Player"