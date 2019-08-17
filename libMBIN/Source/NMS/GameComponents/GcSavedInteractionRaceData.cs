using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0x49B6560B195F1E94, SubGUID = 0x9B192CD525C0A892)]
    public class GcSavedInteractionRaceData : NMSTemplate
    {
        [NMS(Size = 7, EnumValue = new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        public int[] SavedRaceIndicies;
    }
}
