using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Blazonia;
using BlazoniaTemplate.Pages;

namespace BlazoniaTemplate;

public class App : AppBase
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        base.OnFrameworkInitializationCompleted();
#if DEBUG
        if (Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime lifetime)
        {
            this.AttachDevTools();
        }
#endif
    }
}
public class AppBase : BlazoniaApplication<MainPage>
{
}
