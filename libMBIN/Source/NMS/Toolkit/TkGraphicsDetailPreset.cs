using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x2C, GUID = 0x69FCAF6F12021AF4, NameHash = 0x56E0EB96EB3713F0)]
    public class TkGraphicsDetailPreset : NMSTemplate
    {
        public TkGraphicsDetailTypes TextureQuality;
        public TkGraphicsDetailTypes AnimationQuality;
        public TkGraphicsDetailTypes ShadowQuality;
        public TkGraphicsDetailTypes PostProcessingEffects;
        public TkGraphicsDetailTypes VolumetricsQuality;
        public TkGraphicsDetailTypes TerrainTessellation;
        public TkGraphicsDetailTypes PlanetQuality;
        public TkGraphicsDetailTypes BaseQuality;
        public enum AmbientOcclusionEnum { Off, GTAO_Low, GTAO_Medium, GTAO_High, HBAO_Low, HBAO_High }
        public AmbientOcclusionEnum AmbientOcclusion;
        public enum AnisotropyLevelEnum { _1, _2, _4, _8, _16 }
        public AnisotropyLevelEnum AnisotropyLevel;
        public enum AntiAliasingEnum { None, TAA_LOW, TAA, FXAA, TAA_FXAA }
        public AntiAliasingEnum AntiAliasing;
    }
}
