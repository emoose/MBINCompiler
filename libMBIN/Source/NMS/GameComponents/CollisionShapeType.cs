namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF1849CC2622465E, NameHash = 0x2635860B)]
    public class CollisionShapeType : NMSTemplate
    {
        // size: 0x4
        public enum _CollisionShapeTypeEnum : uint {
            Box,
            Capsule,
            Sphere,
            None,
        }
        [NMS(Index = 0, MxmlName = "CollisionShapeType")]
        /* 0x0 */ public _CollisionShapeTypeEnum _CollisionShapeType;
    }
}
