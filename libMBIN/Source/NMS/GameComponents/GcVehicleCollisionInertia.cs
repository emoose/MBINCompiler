namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE365F2F7C018C95, NameHash = 0x95CA1795)]
    public class GcVehicleCollisionInertia : NMSTemplate
    {
        // size: 0x3
        public enum VehicleCollisionInertiaEnum : uint {
            FromScene,
            FromBox,
            InertiaFromBox,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public VehicleCollisionInertiaEnum VehicleCollisionInertia;
    }
}
