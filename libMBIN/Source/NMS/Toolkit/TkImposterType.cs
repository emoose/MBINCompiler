namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x13DD7094A2385B64, NameHash = 0x7887C69F)]
    public class TkImposterType : NMSTemplate
    {
        // size: 0x2
        public enum ImposterTypeEnum : byte {
            Hemispherical,
            Spherical,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ImposterTypeEnum ImposterType;
    }
}
