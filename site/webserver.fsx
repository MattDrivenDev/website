// --------------------------------------------------------------------------------------
// Start up Suave.io web server
// --------------------------------------------------------------------------------------

#r "../packages/FAKE/tools/FakeLib.dll"
#r "../packages/Suave/lib/net40/Suave.dll"
#load "app.fsx"
open Fake
open Suave
open Suave.Web
open Suave.Types
open System.Net

let config = 
    let port = getBuildParamOrDefault "port" "8083" |> Sockets.Port.Parse
    { defaultConfig with bindings = [ HttpBinding.mk HTTP IPAddress.Loopback port ]
                         homeFolder = Some __SOURCE_DIRECTORY__ }

startWebServer config App.app