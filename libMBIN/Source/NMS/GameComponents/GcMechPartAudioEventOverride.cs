using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D5C10F95A234AA9, NameHash = 0x8713A8C7BE9925C6)]
    public class GcMechPartAudioEventOverride : NMSTemplate
    {
        /* 0x0 */ public GcMechMeshPart MeshPart;
        /* 0x4 */ public GcMechMeshType MeshType;
        /* 0x8 */ public GcAudioWwiseEvents OverrideEvent;
    }
}
