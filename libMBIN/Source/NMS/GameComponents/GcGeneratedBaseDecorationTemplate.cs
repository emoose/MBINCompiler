using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BAD5F1D1C966F4D, NameHash = 0x6370110DC5DC47D2)]
    public class GcGeneratedBaseDecorationTemplate : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public TkModelResource TemplateScene;
        /* 0x94 */ public float Probability;
        /* 0x98 */ public int MaxPerRoom;
        // size: 0x8
        public enum DecorationLayerEnum {
            Stairs,
            Corridor,
            Room,
            Door,
            Decoration1,
            Decoration2,
            Decoration3,
            DecorationCorridor,
        }
        /* 0x9C */ public DecorationLayerEnum DecorationLayer;
        /* 0xA0 */ public List<int> InvalidRoomIndexes;
    }
}
