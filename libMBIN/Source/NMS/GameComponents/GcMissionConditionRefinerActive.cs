using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x88, GUID = 0x39BC2F266DED2C79)]
    public class GcMissionConditionRefinerActive : NMSTemplate
    {
        public bool HasFuel;
        [NMS(Size = 0x80)]
        public string ActiveRecipe;
        public int AmountToMake;
    }
}
