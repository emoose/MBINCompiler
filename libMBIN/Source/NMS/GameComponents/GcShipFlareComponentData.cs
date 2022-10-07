namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E6DFC2F6689E5A4, NameHash = 0xCF633C20574F7F38)]
    public class GcShipFlareComponentData : NMSTemplate
    {
        // size: 0x1
        public enum FlareTypeEnum {
            Default
        }
        /* 0x0 */ public FlareTypeEnum FlareType;
    }
}
