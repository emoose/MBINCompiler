using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51375E20814E8B68, NameHash = 0x770E3F1934F2D769)]
    public class GcShipDialogue : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcShipDialogueTreeEnum.DialogueTreeEnum))]
        /* 0x0 */ public GcPlayerCommunicatorMessageWeighted[] DialogueTree;
    }
}
