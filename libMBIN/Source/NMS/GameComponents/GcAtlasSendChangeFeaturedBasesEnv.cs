using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x4B0EA5D3993F3367, NameHash = 0x0F7253E62FEA9C217, Broken = true)]
    public class GcAtlasSendChangeFeaturedBasesEnv : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public List<GcAtlasFeaturedBaseStateChange> BaseList;
    }
}
