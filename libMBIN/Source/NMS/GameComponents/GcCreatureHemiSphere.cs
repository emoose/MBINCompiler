namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB74FEC78503E10A1, NameHash = 0x1BE056BC4F556CAA)]
    public class GcCreatureHemiSphere : NMSTemplate
    {
        // size: 0x3
        public enum CreatureHemiSphereEnum : uint {
            Any,
            Northern,
            Southern,
        }
        /* 0x0 */ public CreatureHemiSphereEnum CreatureHemiSphere;
    }
}
