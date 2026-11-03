using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x489E847AFCDE4E5C, NameHash = 0xB0229282)]
    public class GcMissionConditionIsFrigateFlybyActive : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcFrigateFlybyType FrigateFlybyType;
    }
}
