using UnityEngine;
using UnityEngine.UI;

public class DetailedHardwareInfo : MonoBehaviour
{
    // Reference to the UI Text component
    public Text hardwareInfoText;

    void Start()
    {
        // CPU information
        string cpuType = SystemInfo.processorType;
        int cpuCores = SystemInfo.processorCount;
        int cpuFrequency = SystemInfo.processorFrequency; // In MHz

        // GPU information
        string gpuType = SystemInfo.graphicsDeviceName;
        string gpuVendor = SystemInfo.graphicsDeviceVendor;
        int gpuMemory = SystemInfo.graphicsMemorySize; // In MB
        string gpuVersion = SystemInfo.graphicsDeviceVersion;
        string gpuShaderLevel = SystemInfo.graphicsShaderLevel.ToString();
        bool supportsRayTracing = SystemInfo.supportsRayTracing;

        // Operating System information
        string operatingSystem = SystemInfo.operatingSystem;
        string operatingSystemFamily = SystemInfo.operatingSystemFamily.ToString();

        // Memory information
        int systemMemory = SystemInfo.systemMemorySize; // In MB

        // Device information
        string deviceType = SystemInfo.deviceType.ToString();
        string deviceModel = SystemInfo.deviceModel;

        // Battery information
        float batteryLevel = SystemInfo.batteryLevel * 100f; // As a percentage
        string batteryStatus = SystemInfo.batteryStatus.ToString();

        // Additional graphics information
        string graphicsDeviceType = SystemInfo.graphicsDeviceType.ToString();
        int graphicsDeviceID = SystemInfo.graphicsDeviceID;
        int maxTextureSize = SystemInfo.maxTextureSize;
        int supportedRenderTargetCount = SystemInfo.supportedRenderTargetCount;
        bool supportsComputeShaders = SystemInfo.supportsComputeShaders;

        // Combine all the information into a single string
        string hardwareInfo =
            "CPU Type: " + cpuType + "\n" +
            "CPU Cores: " + cpuCores + "\n" +
            "CPU Frequency: " + cpuFrequency + " MHz\n" +
            "GPU Type: " + gpuType + "\n" +
            "GPU Vendor: " + gpuVendor + "\n" +
            "GPU Memory: " + gpuMemory + " MB\n" +
            "GPU Version: " + gpuVersion + "\n" +
            "GPU Shader Level: " + gpuShaderLevel + "\n" +
            "Supports Ray Tracing: " + supportsRayTracing + "\n" +
            "Operating System: " + operatingSystem + "\n" +
            "Operating System Family: " + operatingSystemFamily + "\n" +
            "System Memory: " + systemMemory + " MB\n" +
            "Device Type: " + deviceType + "\n" +
            "Device Model: " + deviceModel + "\n" +
            "Battery Level: " + batteryLevel + "%\n" +
            "Battery Status: " + batteryStatus + "\n" +
            "Graphics Device Type: " + graphicsDeviceType + "\n" +
            "Graphics Device ID: " + graphicsDeviceID + "\n" +
            "Max Texture Size: " + maxTextureSize + "\n" +
            "Supported Render Target Count: " + supportedRenderTargetCount + "\n" +
            "Supports Compute Shaders: " + supportsComputeShaders;

        // Output the combined information to the Text component
        hardwareInfoText.text = hardwareInfo;
    }
}
