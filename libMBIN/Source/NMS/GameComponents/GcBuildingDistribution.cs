namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EBAD47C3B85DC63, NameHash = 0x1F6F2BB0)]
    public class GcBuildingDistribution : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 2)]
        /* 0x10 */ public int MaxDistance;
        [NMS(Index = 1)]
        /* 0x14 */ public int MinDistance;
    }
}
