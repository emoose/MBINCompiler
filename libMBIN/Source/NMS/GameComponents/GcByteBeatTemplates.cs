using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34F44B119AE0F661, NameHash = 0xBBB68492659143C4)]
    public class GcByteBeatTemplates : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x40> InitialTrees;
        /* 0x10 */ public List<GcByteBeatTemplate> Templates;
        [NMS(Size = 0x12, EnumType = typeof(GcByteBeatToken.ByteBeatTokenEnum))]
        /* 0x20 */ public float[] CombinerWeights;
        /* 0x68 */ public List<GcByteBeatDrum> KickDrums;
        /* 0x78 */ public List<GcByteBeatDrum> SnareDrums;
        /* 0x88 */ public List<GcByteBeatDrum> HiHats;
        /* 0x98 */ public float OperatorPermuteChance;
        /* 0x9C */ public float TemplateCombineChanceAtRoot;
        /* 0xA0 */ public float TemplateCombineChance;
        /* 0xA8 */ public List<GcByteBeatSong> Songs;
    }
}
