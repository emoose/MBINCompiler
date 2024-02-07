using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3FFE9FFE02F9D4A, NameHash = 0xF0829DCD8555A52E)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x74FA0 */ public GcPlayerSpawnStateData Spawn;
    }
}
