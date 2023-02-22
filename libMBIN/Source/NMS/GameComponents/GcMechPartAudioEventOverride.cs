using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5D7F7F6B6FBA873, NameHash = 0x8713A8C7BE9925C6)]
    public class GcMechPartAudioEventOverride : NMSTemplate
    {
        /* 0x0 */ public GcMechMeshPart MeshPart;
        /* 0x4 */ public GcMechMeshType MeshType;
        /* 0x8 */ public GcAudioWwiseEvents OverrideEvent;
    }
}
