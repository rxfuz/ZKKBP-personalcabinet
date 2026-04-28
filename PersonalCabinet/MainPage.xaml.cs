using System;
using Microsoft.Maui.Controls;

namespace PersonalCabinet;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override bool OnBackButtonPressed()
    {
        if (webView?.CanGoBack == true)
        {
            webView.GoBack();
            return true;
        }

        ShowExitDialog();
        return true;
    }

    private async void ShowExitDialog()
    {
        exitDialogOverlay.IsVisible = true;
        await exitDialogOverlay.FadeTo(1, 200);
        if (exitFrame != null)
        {
            exitFrame.Scale = 0.9;
            await exitFrame.ScaleTo(1, 150, Easing.CubicOut);
        }
    }

    private async void HideExitDialog()
    {
        await exitDialogOverlay.FadeTo(0, 150);
        exitDialogOverlay.IsVisible = false;
    }

    private void OnExitCancelClicked(object sender, EventArgs e)
    {
        HideExitDialog();
    }

    private void OnExitConfirmClicked(object sender, EventArgs e)
    {
        HideExitDialog();
        Application.Current?.Quit();
    }
}