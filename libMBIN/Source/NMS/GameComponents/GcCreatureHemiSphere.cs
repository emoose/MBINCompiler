namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE0856518ACA9A16, NameHash = 0x1BE056BC4F556CAA)]
    public class GcCreatureHemiSphere : NMSTemplate
    {
        // size: 0x3
        public enum CreatureHemiSphereEnum {
            Any,
            Northern,
            Southern,
        }
        /* 0x0 */ public CreatureHemiSphereEnum CreatureHemiSphere;
    }
}
