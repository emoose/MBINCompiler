namespace libMBIN.Models.Structs
{
    public class TkEngineSettingsMapping : NMSTemplate
    {
        public float ShadowMultiplierLow;
        public float ShadowMultiplierNormal;
        public float ShadowMultiplierHigh;
        public float ShadowMultiplierUltra;
        public float ReflectionMultiplierLow;
        public float ReflectionMultiplierNormal;
        public float ReflectionMultiplierHigh;

        // boolean describing whether or not the game needs to restant when the specific setting has been changed... I think...
        [NMS(Size = 0x1D, EnumValue = new string[0x1D]{ "FullScreen", "Borderless", "ResolutionWidth", "ResolutionHeight", "Monitor",
           "FoVOnFoot", "FoVInShip", "VSync", "GSync", "ShadowDetail", "TextureDetail", "GenerationDetail", "ReflectionsQuality",
           "AntiAliasing", "MotionBlurQuality", "AnisotropyLevel", "Brightness", "AvailableMonitors", "MaxFrameRate", "NumLowThreads",
           "NumHighThreads", "TextureStreaming", "TexturePageSizeKb", "MotionBlurStrength", "ShowRequirementsWarnings", "AmbientOcclusion",
           "UseLightshafts", "MaxTextureMemoryMb", "FixedTextureMemory" })]
        public bool[] NeedsGameRestart;
    }
}
