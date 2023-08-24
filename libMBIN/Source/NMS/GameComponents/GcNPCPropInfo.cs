using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x268C07FA59329E8A, NameHash = 0x9441C44CA7215426)]
    public class GcNPCPropInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Model;
        /* 0x080 */ public bool Hologram;
        /* 0x090 */ public GcScanEffectData ScanEffect;
        /* 0x0E0 */ public NMSString0x40 ScanEffectNodeName;
        /* 0x120 */ public float Weight;
        /* 0x124 */ public GcTechnologyCategory ShopType;
        /* 0x128 */ public GcHand DominantHand;
        // size: 0x2
        public enum NPCPropAttachLocationEnum : uint {
            Hand,
            Wrist,
        }
        /* 0x12C */ public NPCPropAttachLocationEnum NPCPropAttachLocation;
        /* 0x130 */ public NMSString0x10 AttachLocator;
        /* 0x140 */ public Vector3f AttachTranslation;
        /* 0x150 */ public Vector3f AttachRotation;
        /* 0x160 */ public float AttachScale;
        /* 0x164 */ public float AttachScaleGek;
    }
}
