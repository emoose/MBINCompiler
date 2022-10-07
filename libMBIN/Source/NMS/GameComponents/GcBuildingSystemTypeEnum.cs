namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2179A317A158D039, NameHash = 0xB4AC262382F5910E)]
    public class GcBuildingSystemTypeEnum : NMSTemplate
    {
        // size: 0x2
        public enum BuildingSystemTypeEnum {
            Normal,
            AbandonedSystem
        }
        /* 0x0 */ public BuildingSystemTypeEnum BuildingSystemType;
    }
}
