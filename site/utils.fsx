#r "../packages/Suave/lib/net40/Suave.dll"
open Suave
open Suave.Http.Applicatives
open Suave.Types

let delay (f:unit->WebPart) ctx = async {
	return! f() ctx }