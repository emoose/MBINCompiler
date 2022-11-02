using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4A3D6B09C33E9D5, NameHash = 0xF0829DCD8555A52E)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x77310 */ public GcPlayerSpawnStateData Spawn;
    }
}
