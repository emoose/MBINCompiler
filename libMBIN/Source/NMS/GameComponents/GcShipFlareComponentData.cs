namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3033020A33203A, NameHash = 0xCF633C20574F7F38)]
    public class GcShipFlareComponentData : NMSTemplate
    {
        // size: 0x1
        public enum FlareTypeEnum {
            Default,
        }
        /* 0x0 */ public FlareTypeEnum FlareType;
    }
}
