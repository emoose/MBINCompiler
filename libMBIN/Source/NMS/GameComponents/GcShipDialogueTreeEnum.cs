namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5BF1578B28BC2995, NameHash = 0xBC8B5F2250F65891)]
    public class GcShipDialogueTreeEnum : NMSTemplate
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
        /* 0x0 */ public DialogueTreeEnum DialogueTree;
    }
}
