namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x18, GUID = 0x608078A388EF854B)]
    public class GcCharacterCustomisationBoneScaleData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string BoneName;
        public float Scale;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
