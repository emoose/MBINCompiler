using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x0A8064521312FF34A)]
    public class TkUserServiceAuthProvider : NMSTemplate
    {
		public enum AuthProviderEnum { Null, PSN, Steam, Galaxy }
		public AuthProviderEnum AuthProvider;
    }
}
