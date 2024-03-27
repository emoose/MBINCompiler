namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D237CCE7DD21A46, NameHash = 0x25C87553CE78E1FD)]
    public class GcColourModifier : NMSTemplate
    {
        /* 0x00 */ public bool ForceColour;
        /* 0x10 */ public Colour ForceColourTo;
        /* 0x20 */ public float OffsetSaturation;
        /* 0x24 */ public float OffsetValue;
        /* 0x28 */ public float MultiplySaturation;
        /* 0x2C */ public float MultiplyValue;
    }
}
