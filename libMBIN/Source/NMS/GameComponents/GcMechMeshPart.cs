namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE73D1B29D0357E0, NameHash = 0x78242DA1B96F48FC)]
    public class GcMechMeshPart : NMSTemplate
    {
        // size: 0x5
        public enum MechMeshPartEnum {
            Scanner,
            Body,
            Legs,
            LeftArm,
            RightArm
        }
        /* 0x0 */ public MechMeshPartEnum MechMeshPart;
    }
}
