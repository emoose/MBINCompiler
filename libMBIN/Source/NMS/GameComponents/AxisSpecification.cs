namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7403AD71234BEEE2, NameHash = 0xE46A33ECA1AA62F7)]
    public class AxisSpecification : NMSTemplate
    {
        // size: 0x7
        public enum AxisEnum {
            X,
            Y,
            Z,
            NegativeX,
            NegativeY,
            NegativeZ,
            CustomAxis
        }
        /* 0x00 */ public AxisEnum Axis;
        /* 0x10 */ public Vector3f CustomAxis;
    }
}
