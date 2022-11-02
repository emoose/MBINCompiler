using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDC67D502ABE821ED, NameHash = 0x780D9DC36193A771)]
    public class TkVoxelGeneratorSettingsElement : NMSTemplate
    {
        /* 0x0000 */ public TkVoxelGeneratorData Min;
        /* 0x15D0 */ public TkVoxelGeneratorData Max;
    }
}
