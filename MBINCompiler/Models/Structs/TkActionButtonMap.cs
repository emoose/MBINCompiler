using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkActionButtonMap : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ActionId;
        public bool ScaleToFitFont;
        public TkInputEnum InputButton;
        public List<TkPlatformButtonPair> Platforms;
    }
}
