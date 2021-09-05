namespace maui

open System
open Microsoft.Maui.Controls
open Microsoft.Maui.Controls.Xaml



 type MainPage () = 
    inherit ContentPage()

    let _ = base.LoadFromXaml(typeof<MainPage>)
    let mutable count = 0
    let CounterLabel = base.FindByName<Label>("CounterLabel")

    member private this.OnCounterClicked (sender: Object, e: EventArgs) =
        count <- count + 1
        CounterLabel.Text <- $"Current count: {count}"