namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD03F6F0863C69B0F, NameHash = 0x91EF3068AEC32FB7)]
    public class TkUserServiceAuthProvider : NMSTemplate
    {
        // size: 0x6
        public enum AuthProviderEnum {
            Null,
            PSN,
            Steam,
            Galaxy,
            Xbox,
            WeGame
        }
        /* 0x0 */ public AuthProviderEnum AuthProvider;
    }
}
