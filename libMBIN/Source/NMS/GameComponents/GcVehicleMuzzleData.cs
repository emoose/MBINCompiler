namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC981D9D1A311269E, NameHash = 0x2BA616233E287BB2)]
    public class GcVehicleMuzzleData : NMSTemplate
    {
        // size: 0x4
        public enum MuzzleFlashDataIDEnum {
            Laser,
            Gun,
            TerrainEdit,
            StunGun
        }
        [NMS(Size = 0x4, EnumType = typeof(MuzzleFlashDataIDEnum))]
        /* 0x0 */ public NMSString0x10[] MuzzleFlashDataID;
    }
}
