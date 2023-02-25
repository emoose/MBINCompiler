namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBEFB647B9E09BAE7, NameHash = 0x91EF3068AEC32FB7)]
    public class TkUserServiceAuthProvider : NMSTemplate
    {
        // size: 0x7
        public enum AuthProviderEnum : uint {
            Null,
            PSN,
            Steam,
            Galaxy,
            Xbox,
            WeGame,
            NSO,
        }
        /* 0x0 */ public AuthProviderEnum AuthProvider;
    }
}
