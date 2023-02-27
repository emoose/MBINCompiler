using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CA9A1793484A18, NameHash = 0xB82C2871716786E2)]
    public class GcUniqueNPCSpawnData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x10 PresetId;
        /* 0x020 */ public GcResourceElement ResourceElement;
        /* 0x2C8 */ public GcAlienRace Race;
    }
}
