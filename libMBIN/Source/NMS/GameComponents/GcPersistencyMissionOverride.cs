using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDAF87BDC85368077, NameHash = 0xD595098569C459AF)]
    public class GcPersistencyMissionOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public GcInteractionBufferType Buffer;
    }
}
