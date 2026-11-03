namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39943CB38C3E1192, NameHash = 0xC6FDDB33)]
    public class GcPetBattlerMoveSlotOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Template;
        [NMS(Index = 2)]
        /* 0x10 */ public int CooldownMax;
        [NMS(Index = 1)]
        /* 0x14 */ public int CooldownMin;
        [NMS(Index = 3)]
        /* 0x18 */ public float Weighting;
    }
}
