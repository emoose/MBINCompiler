using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8D124FD3F031C94C, NameHash = 0x8EEA012026874C5C)]
    public class GcObjectSpawnerComponentData : NMSTemplate
    {
        /* 0x00 */ public TkModelResource Object;
        /* 0x84 */ public int SpawnPowerCost;
        /* 0x88 */ public float SpawnCooldown;
    }
}
