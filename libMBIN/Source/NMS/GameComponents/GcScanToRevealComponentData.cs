using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F229B680EA889DA, NameHash = 0x3CE9B038B094EDFF)]
    public class GcScanToRevealComponentData : NMSTemplate
    {
        /* 0x00 */ public bool StartEnabled;
        /* 0x01 */ public bool RevealedByToolScan;
        /* 0x02 */ public bool RevealedByShipScan;
        /* 0x08 */ public NMSString0x10 RequiredTech;
        /* 0x18 */ public GcStatsTypes RequiredStat;
        /* 0x1C */ public float MaxRange;
        /* 0x20 */ public float RevealTime;
        /* 0x24 */ public bool DoDissolve;
        /* 0x28 */ public float DissolveTime;
        /* 0x2C */ public bool SetNodeActivation;
        /* 0x30 */ public NMSString0x10 OnRevealEffect;
        /* 0x40 */ public bool OnRevealEffectScaleWithAABB;
        /* 0x41 */ public bool LockedMarkerClearOnReveal;
        /* 0x48 */ public NMSString0x10 LockedMarkerScanOverride;
        // size: 0x3
        public enum HideScanMarkerConditionEnum : uint {
            Never,
            MissingTech,
            Hidden,
        }
        /* 0x58 */ public HideScanMarkerConditionEnum HideScanMarkerCondition;
    }
}
