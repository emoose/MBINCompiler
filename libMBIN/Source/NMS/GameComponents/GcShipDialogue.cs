namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x268, GUID = 0x0CC2407F5B59CAB0C)]
    public class GcShipDialogue : NMSTemplate
    {
        [NMS(Size = 0x7, EnumValue = new string[] { "Bribe", "Beg", "Ambush", "Trade", "Help", "Goods", "Hostile" })]
        public GcPlayerCommunicatorMessageWeighted[] DialogueTree;
    }
}
