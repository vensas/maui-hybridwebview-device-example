async function GetNativeDeviceInfoAsync() {
    const nativeDeviceInfoTask = await window.HybridWebView.InvokeDotNet("GetNativeDeviceInfoAsync");
    // Unwrap task object
    const nativeDeviceInfo = nativeDeviceInfoTask.Result;
    UpdateNativeDeviceInfo("operatingSystemLabel", nativeDeviceInfo.OperatingSystem);
    UpdateNativeDeviceInfo("operatingSystemVersionLabel", nativeDeviceInfo.OperatingSystemVersion);
    UpdateNativeDeviceInfo("appVersionLabel", nativeDeviceInfo.AppVersion);
    UpdateNativeDeviceInfo("hasFlashlightLabel", nativeDeviceInfo.HasFlashlight);
}

function UpdateNativeDeviceInfo(labelId, value){
    const label = document.getElementById(labelId);
    label.textContent = value;
}

GetNativeDeviceInfoAsync();
