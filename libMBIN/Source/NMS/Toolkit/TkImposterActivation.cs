namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2FA4095048216D6B, NameHash = 0xB39D58B3)]
    public class TkImposterActivation : NMSTemplate
    {
        // size: 0x3
        public enum ImposterActivationEnum : byte {
            Default,
            ForceHaveImposter,
            ForceNoImposter,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ImposterActivationEnum ImposterActivation;
    }
}
