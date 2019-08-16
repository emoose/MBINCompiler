using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x268, GUID = 0xF653BDA2ED60AE1D)]
    public class GcShipDialogue : NMSTemplate
    {
        [NMS(Size = 0x7, EnumValue = new[] { "Bribe", "Beg", "Ambush", "Trade", "Help", "Goods", "Hostile" })]
        public GcPlayerCommunicatorMessageWeighted[] DialogueTree;
    }
}
