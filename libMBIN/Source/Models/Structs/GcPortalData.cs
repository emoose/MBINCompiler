namespace libMBIN.Models.Structs
{
    public class GcPortalData : NMSTemplate
    {
        public float RuneRotateTime;
        public bool SkipRuneEntry;
        public bool KnowAllRunes;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] EndPadding;
    }
}
