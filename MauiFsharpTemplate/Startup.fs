namespace maui


open Microsoft.Maui
open Microsoft.Maui.Hosting
open Microsoft.Maui.Controls.Compatibility
open Microsoft.Maui.Controls.Hosting
open Microsoft.Maui.Controls.Xaml

type Startup() =
    interface IStartup with
        member this.Configure(appBuilder: IAppHostBuilder) =
            appBuilder
                .UseMauiApp<App>()
                .ConfigureFonts(fun fonts -> fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular") |> ignore)
            |> ignore