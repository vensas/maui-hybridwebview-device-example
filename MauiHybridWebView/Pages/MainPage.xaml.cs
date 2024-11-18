
using System.Reflection;
using MauiHybridWebView.Models;

namespace MauiHybridWebView.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        HybridWebView.SetInvokeJavaScriptTarget(this);
    }

    public async Task<NativeDeviceInfo> GetNativeDeviceInfoAsync()
    {
        var hasFlashlight = await Flashlight.IsSupportedAsync();
        return new NativeDeviceInfo
        {
            OperatingSystemVersion = DeviceInfo.Current.VersionString,
            OperatingSystem = DeviceInfo.Platform.ToString(), 
            AppVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(),
            HasFlashlight = hasFlashlight
            
        };
    }
}