using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x28101937F4FE62D1, NameHash = 0xCDB7AC6D11C9DF03)]
    public class GcCustomisationTextureOption : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TextureOptionsID;
        [NMS(Size = 0x10)]
        public string Layer;
        [NMS(Size = 0x10)]
        public string Group;
        public TkPaletteTexture Palette;
        public List<NMSString0x20> Options;
    }
}
