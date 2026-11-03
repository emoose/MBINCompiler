using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8A65E3202D2BAEC, NameHash = 0xEFBFCE4B)]
    public class GcGameTableNPCEventReactionData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcGameTableNPCEventTriggerOwner.GameTableNPCEventTriggerOwnerEnum))]
        /* 0x0 */ public GcGameTableNPCEventReactionList[] Reactions;
    }
}
