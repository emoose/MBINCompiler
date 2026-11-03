namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22982A326B67AA2E, NameHash = 0xD56D60DA)]
    public class GcCockpitComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename Cockpit;
        [NMS(Index = 4)]
        /* 0x10 */ public float FoVFixedDistance;
        [NMS(Index = 3)]
        /* 0x14 */ public float MaxHeadPitchDown;
        [NMS(Index = 2)]
        /* 0x18 */ public float MaxHeadPitchUp;
        [NMS(Index = 1)]
        /* 0x1C */ public float MaxHeadTurn;
    }
}
