namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2FF18440DA1DBF7, NameHash = 0x1FD33D08A7082C22)]
    public class GcSpaceStationSpawnData : NMSTemplate
    {
        // size: 0x3
        public enum SpawnModeEnum : uint {
            None,
            UseSeed,
            UseAltID,
        }
        /* 0x000 */ public SpawnModeEnum SpawnMode;
        /* 0x008 */ public GcSeed Seed;
        /* 0x018 */ public NMSString0x100 AltId;
        /* 0x120 */ public Vector3f SpawnPosition;
        /* 0x130 */ public Vector3f SpawnFacing;
    }
}
