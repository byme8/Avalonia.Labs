﻿using Android.App;
using Android.Content;
using Android.OS;
using Avalonia.Android;
using Avalonia.ReactiveUI;

namespace Avalonia.Labs.Catalog.Android;

[Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
public class SplashActivity : AvaloniaSplashActivity<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .UseReactiveUI();
    }

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
    }

    protected override void OnResume()
    {
        base.OnResume();

        StartActivity(new Intent(global::Android.App.Application.Context, typeof(MainActivity)));
    }
}
