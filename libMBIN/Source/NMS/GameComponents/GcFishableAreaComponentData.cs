namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C9A9D3CE736AE9B, NameHash = 0x88F119C7)]
    public class GcFishableAreaComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Radius;
        [NMS(Index = 1)]
        /* 0x4 */ public bool SourceFishBasedOnSettlementBuildingLevel;
    }
}
