using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE875CAEEE0044040, NameHash = 0xFFD81BF5)]
    public class TkMarkupVolumeData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public TkVolumeMarkupType MarkupVolumeType;
    }
}
