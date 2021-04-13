using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x58, GUID = 0x9586CD35800C5D18, NameHash = 0x4845AFA2BB576F24)]
    public class GcAtlasSendMarkFeaturedBaseWithImage : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        [NMS(Size = 0x40)]
        /* 0x08 */ public string BaseID;
        [NMS(Size = 0x10)]
        /* 0x48 */ public string Image;
    }
}
