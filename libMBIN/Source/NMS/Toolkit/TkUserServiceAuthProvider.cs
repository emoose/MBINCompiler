namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF1303CE69F1A09F6, NameHash = 0xE4B500D2)]
    public class TkUserServiceAuthProvider : NMSTemplate
    {
        // size: 0x8
        public enum AuthProviderEnum : uint {
            Null,
            PSN,
            Steam,
            Galaxy,
            Xbox,
            WeGame,
            NSO,
            GameCenter,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AuthProviderEnum AuthProvider;
    }
}
