using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CBA76B00C093CB3, NameHash = 0x6A92D05C)]
    public class GcGeneratedBaseDecorationTemplate : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource TemplateScene;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 5)]
        /* 0x30 */ public List<int> InvalidRoomIndexes;
        // size: 0x8
        public enum DecorationLayerEnum : uint {
            Stairs,
            Corridor,
            Room,
            Door,
            Decoration1,
            Decoration2,
            Decoration3,
            DecorationCorridor,
        }
        [NMS(Index = 4)]
        /* 0x40 */ public DecorationLayerEnum DecorationLayer;
        [NMS(Index = 3)]
        /* 0x44 */ public int MaxPerRoom;
        [NMS(Index = 2)]
        /* 0x48 */ public float Probability;
    }
}
