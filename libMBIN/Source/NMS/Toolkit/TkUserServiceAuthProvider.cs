namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDAA8FB6246AA6458, NameHash = 0x91EF3068AEC32FB7)]
    public class TkUserServiceAuthProvider : NMSTemplate
    {
        // size: 0x6
        public enum AuthProviderEnum {
            Null,
            PSN,
            Steam,
            Galaxy,
            Xbox,
            WeGame,
        }
        /* 0x0 */ public AuthProviderEnum AuthProvider;
    }
}
