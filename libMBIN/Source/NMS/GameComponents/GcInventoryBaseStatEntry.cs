namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E4E2A7E377AB512, NameHash = 0xA46C3D75)]
    public class GcInventoryBaseStatEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 BaseStatID;
        [NMS(Index = 1)]
        /* 0x10 */ public float Value;
    }
}
