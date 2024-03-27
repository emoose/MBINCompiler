namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DE40488BE597ACC, NameHash = 0x78242DA1B96F48FC)]
    public class GcMechMeshPart : NMSTemplate
    {
        // size: 0x5
        public enum MechMeshPartEnum : uint {
            Scanner,
            Body,
            Legs,
            LeftArm,
            RightArm,
        }
        /* 0x0 */ public MechMeshPartEnum MechMeshPart;
    }
}
