namespace maui

open Foundation;
open Microsoft.Maui;

[<Register("AppDelegate")>]
type AppDelegate () = 
    inherit MauiUIApplicationDelegate<Startup> ()