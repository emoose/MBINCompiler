namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF308B3FC00EF34F, NameHash = 0x4C03886F1A1C1DF7)]
    public class GcCreatureDebugWaypoint : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        // size: 0x3
        public enum WaypointTypeEnum {
            Move,
            MoveAlt,
            Idle
        }
        /* 0x10 */ public WaypointTypeEnum WaypointType;
        /* 0x18 */ public NMSString0x10 Anim;
        /* 0x28 */ public float Time;
    }
}
