﻿#r "System.Configuration"

(* IMPORTANT NOTE: change these paths to make this script run with your Nu installation! *)
#r "C:/Development/OmniBlade/Prime/xUnit/xunit.dll"
#r "C:/Development/OmniBlade/Prime/FSharpx.Core/FSharpx.Core.dll"
#r "C:/Development/OmniBlade/Prime/Prime/Prime/bin/Debug/Prime.dll"
#r "C:/Development/OmniBlade/Nu/xUnit/xunit.dll"
#r "C:/Development/OmniBlade/Nu/FSharpx.Core/FSharpx.Core.dll"
#r "C:/Development/OmniBlade/Nu/Farseer/FarseerPhysics.dll"
#r "C:/Development/OmniBlade/Nu/SDL2#/Debug/SDL2#.dll"
#r "C:/Development/OmniBlade/Nu/TiledSharp/Debug/TiledSharp.dll"
System.IO.Directory.SetCurrentDirectory "C:/OmniBlade/Nu/Nu/Nu/bin/Debug"

#load "NuCore.fs"
#load "RQueue.fs"
#load "NuConstants.fs"
#load "NuMath.fs"
#load "Voords.fs"
#load "Assets.fs"
#load "Physics.fs"
#load "Rendering.fs"
#load "Audio.fs"
#load "Metadata.fs"
#load "Input.fs"
#load "Camera.fs"
#load "DomainModel.fs"
#load "Sdl.fs"
#load "Sim.fs"
#load "Entity.fs"
#load "Group.fs"
#load "Screen.fs"
#load "Game.fs"
#load "World.fs"

open System
open SDL2
open OpenTK
open TiledSharp
open Nu