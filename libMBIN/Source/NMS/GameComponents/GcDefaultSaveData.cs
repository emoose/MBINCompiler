using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x816B4BC69D0C6FF4, NameHash = 0xF0829DCD8555A52E)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x790F0 */ public GcPlayerSpawnStateData Spawn;
    }
}
