using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x10, GUID = 0x36E3CF6D7FBAA203)]
    public class GcCustomisationTextureOptions : NMSTemplate
    {
        public List<GcCustomisationTextureOption> TextureOptions;
    }
}
