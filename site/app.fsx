#r "../packages/Suave/lib/net40/Suave.dll"
#r "../packages/Suave.DotLiquid/lib/net40/Suave.DotLiquid.dll"
#r "../packages/DotLiquid/lib/NET45/DotLiquid.dll"
#r "../packages/FSharp.Data/lib/net40/FSharp.Data.dll"
#load "pages/home.fsx"
open System
open System.IO
open System.Web
open Suave
open Suave.Web
open Suave.Http
open Suave.Types
open Suave.Http.Applicatives
open Suave.Http.Successful
open Suave.Http.Writers

DotLiquid.setTemplatesDir (__SOURCE_DIRECTORY__ + "/templates")

let app =
	choose [ path "/" >>= Home.show ]