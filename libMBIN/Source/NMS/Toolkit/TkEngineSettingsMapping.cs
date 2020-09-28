using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x78, GUID = 0x4E677597C10B7408, NameHash = 0xC02F1D19584B44D)]
    public class TkEngineSettingsMapping : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        public float[] ShadowMultiplier;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        public float[] ReflectionMultiplier;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        public float[] IKFullBodyIterations;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        public float[] CloudsResolutionScale;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        public float[] CloudsMaxIterations;

        [NMSDescription("An array of properties which require a game restart to apply")]
        [NMS(Size = 0x28, EnumType = typeof(TkEngineSettingTypes.EngineSettingEnum))]
        public bool[] NeedsGameRestart;
    }
}
