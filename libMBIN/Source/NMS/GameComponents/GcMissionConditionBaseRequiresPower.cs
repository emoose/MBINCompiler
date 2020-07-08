using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x8DE5B332C628BA6E, NameHash = 0x37860DD7ED5CA76A)]
    public class GcMissionConditionBaseRequiresPower : NMSTemplate
    {
        public int MinNumPowerUsingParts;
    }
}