using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5F4640FBD862BEC, NameHash = 0x56FE448D)]
    public class GcLootProbability : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource LootModel;
        [NMS(Index = 1)]
        /* 0x20 */ public float Probability;
    }
}
