using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE74F361F98517688, NameHash = 0x1518FAA28FFA87F7)]
    public class GcMissionConditionCreatureOwned : NMSTemplate
    {
        /* 0x00 */ public int Amount;
        /* 0x04 */ public TkEqualityEnum Test;
        /* 0x08 */ public NMSString0x10 SpecificCreatureID;
        /* 0x18 */ public bool AnyPredator;
    }
}
