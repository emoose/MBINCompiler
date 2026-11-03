using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x58311772158EE46E, NameHash = 0xF8F1B5FB)]
    public class GcObjectSpawnerComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource Object;
        [NMS(Index = 2)]
        /* 0x20 */ public float SpawnCooldown;
        [NMS(Index = 1)]
        /* 0x24 */ public int SpawnPowerCost;
    }
}
