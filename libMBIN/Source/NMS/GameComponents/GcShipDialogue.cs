using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D4E90FB6F6124F7, NameHash = 0x770E3F1934F2D769)]
    public class GcShipDialogue : NMSTemplate
    {
        // size: 0x7
        public enum DialogueTreeEnum {
            Bribe,
            Beg,
            Ambush,
            Trade,
            Help,
            Goods,
            Hostile
        }
        [NMS(Size = 0x7, EnumType = typeof(DialogueTreeEnum))]
        /* 0x0 */ public GcPlayerCommunicatorMessageWeighted[] DialogueTree;
    }
}
