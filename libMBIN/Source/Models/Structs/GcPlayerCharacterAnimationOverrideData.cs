namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x30, GUID = 0x4714DD868638194)]
    public class GcPlayerCharacterAnimationOverrideData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string AnimName;
        public GcPlayerCharacterIKOverrideData Data;
    }
}
