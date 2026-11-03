namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F25D2EE85D0B77E, NameHash = 0x67EE1437)]
    public class GcShipDialogueTreeEnum : NMSTemplate
    {
        // size: 0x7
        public enum DialogueTreeEnum : uint {
            Bribe,
            Beg,
            Ambush,
            Trade,
            Help,
            Goods,
            Hostile,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DialogueTreeEnum DialogueTree;
    }
}
