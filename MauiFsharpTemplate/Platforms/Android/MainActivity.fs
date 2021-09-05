namespace maui

open Android.App
open Android.Content.PM
open Microsoft.Maui


[<Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize ||| ConfigChanges.Orientation ||| ConfigChanges.UiMode ||| ConfigChanges.ScreenLayout ||| ConfigChanges.SmallestScreenSize)>]
type MainActivity () =
    inherit MauiAppCompatActivity()
