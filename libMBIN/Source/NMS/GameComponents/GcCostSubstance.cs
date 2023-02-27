using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E0BBA2A23E0B886, NameHash = 0xDDDD3B456E0993D3)]
    public class GcCostSubstance : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Amount;
    }
}
