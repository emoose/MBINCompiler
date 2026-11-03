using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x406829765E43A65, NameHash = 0xA151C99F)]
    public class GcNGuiLayerData : NMSTemplate
    {
        [NMS(Index = 0, MxmlName = "Element Data")]
        /* 0x000 */ public GcNGuiElementData ElementData;
        [NMS(Index = 3)]
        /* 0x068 */ public List<NMSTemplate> Children;
        [NMS(Index = 4)]
        /* 0x078 */ public GcFilename DataFilename;
        [NMS(Index = 2)]
        /* 0x088 */ public GcFilename Image;
        [NMS(Index = 1)]
        /* 0x098 */ public TkNGuiGraphicStyle Style;
        // size: 0x5
        public enum AltModeEnum : uint {
            None,
            Normal,
            Alt,
            NeverOnTouch,
            OnlyOnTouch,
        }
        [NMS(Index = 5)]
        /* 0x218 */ public AltModeEnum AltMode;
    }
}
