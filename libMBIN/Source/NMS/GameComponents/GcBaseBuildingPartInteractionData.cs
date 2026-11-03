namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D5985BD1B7D3C2D, NameHash = 0x56FDC790)]
    public class GcBaseBuildingPartInteractionData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f AtDir;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f LocalPos;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 InteractionID;
    }
}
