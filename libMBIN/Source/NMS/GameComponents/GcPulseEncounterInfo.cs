using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x198, GUID = 0x5D81E441F67671AC, NameHash = 0x657592AF71342449)]
    public class GcPulseEncounterInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x20A MarkerLabel;
        /* 0x030 */ public NMSString0x20A ChatMessageName;
        /* 0x050 */ public TkTextureResource MarkerIcon;
        /* 0x0D8 */ public GcPulseEncounterSpawnConditions SpawnCondition;
        /* 0x138 */ public float SpawnChance;
        /* 0x13C */ public float SpawnDistance;
        /* 0x140 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x144 */ public bool Silent;
        /* 0x148 */ public NMSTemplate Encounter;
    }
}
