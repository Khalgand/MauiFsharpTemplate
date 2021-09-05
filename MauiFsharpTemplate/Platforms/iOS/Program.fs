namespace maui

open UIKit


module Main =
    [<EntryPoint>]
	let Main args =
	    UIApplication.Main(args, null, typeof(AppDelegate)) |> ignore
        0