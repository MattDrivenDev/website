#load "references.fsx"
open System
open Suave
open Suave.Http.Successful
open Suave.Web
open Suave.Types
open Utils

type Home = { Date : DateTime }

let home() = { Date = DateTime.UtcNow }

let show = 
	let f() = DotLiquid.page "home.html" (home())
	delay f