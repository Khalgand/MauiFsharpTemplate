namespace maui

open System;
open Android.App
open Android.Runtime
open Microsoft.Maui


[<Aplication>]
type MainApplication(handle:IntPtr, ownership:JniHandleOwnership) =
    inheret MauiApplication<Startup> (handle, ownership)
