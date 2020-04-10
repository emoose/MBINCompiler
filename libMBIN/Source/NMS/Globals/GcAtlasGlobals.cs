using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x10, GUID = 0xF07A5559350356C7 )]
    public class GcAtlasGlobals : NMSTemplate
    {
        public int ChanceOfDisconnect;
        public int TimeoutSecNameResolution;
        public int TimeoutSecConnection;
        public int TimeoutSecSendRecv;
    }
}
