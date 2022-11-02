namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94965E957AD36909, NameHash = 0xD01AAF2CB5C146A1)]
    public class GcDestroyAction : NMSTemplate
    {
        /* 0x0 */ public bool DestroyAll;
        /* 0x1 */ public bool UseDestructables;
        /* 0x8 */ public NMSString0x10 PlayEffect;
    }
}
