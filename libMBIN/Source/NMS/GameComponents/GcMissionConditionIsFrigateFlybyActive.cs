using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xF6B325012CBB1756, NameHash = 0xCE9968E4A5D8329B)]
    public class GcMissionConditionIsFrigateFlybyActive : NMSTemplate
    {
        public GcFrigateFlybyType FrigateFlybyType;
    }
}
