namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8517264229D41D7D, NameHash = 0x882EF682)]
    public class GcCharacterCustomisationBoneScaleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 BoneName;
        [NMS(Index = 1)]
        /* 0x10 */ public float Scale;
    }
}
