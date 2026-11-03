using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6F27EEBCC95A88B, NameHash = 0xC9C915DF)]
    public class GcMechPartEffectOverride : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 OverrideEffect;
        [NMS(Index = 0)]
        /* 0x10 */ public GcMechMeshPart MeshPart;
        [NMS(Index = 1)]
        /* 0x14 */ public GcMechMeshType MeshType;
    }
}
