﻿using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using HanumanInstitute.MvvmDialogs;
using HanumanInstitute.MvvmDialogs.Wpf;

namespace Demo.CustomSaveFileDialog;

public partial class App
{
    protected override void OnStartup(StartupEventArgs e)
    {
        Ioc.Default.ConfigureServices(
            new ServiceCollection()
                .AddSingleton<IDialogService>(_ => new DialogService(dialogManager: new DialogManager(frameworkDialogFactory: new CustomFrameworkDialogFactory()), new ViewLocator()))
                .AddTransient<MainWindowViewModel>()
                .BuildServiceProvider());
    }
}
