using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC6122BA1FCDC06BC, NameHash = 0xA6F502B8)]
    public class TkDynamicPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkRigidBodyComponentData RigidBody;
        [NMS(Index = 0)]
        /* 0x28 */ public TkPhysicsData Data;
        // size: 0x2
        public enum PhysicsSurfacePropertiesEnum : uint {
            None,
            Glass,
        }
        [NMS(Index = 2)]
        /* 0x48 */ public PhysicsSurfacePropertiesEnum PhysicsSurfaceProperties;
        [NMS(Index = 11)]
        /* 0x4C */ public float SimpleCharacterCollisionFwdOffset;
        [NMS(Index = 9)]
        /* 0x50 */ public float SimpleCharacterCollisionHeight;
        [NMS(Index = 10)]
        /* 0x54 */ public float SimpleCharacterCollisionHeightOffset;
        [NMS(Index = 8)]
        /* 0x58 */ public float SimpleCharacterCollisionRadius;
        [NMS(Index = 4)]
        /* 0x5C */ public float SpinOnCreate;
        [NMS(Index = 5)]
        /* 0x60 */ public bool Animated;
        [NMS(Index = 3)]
        /* 0x61 */ public bool DisableGravity;
        [NMS(Index = 7)]
        /* 0x62 */ public bool RotateSimpleCharacterCollisionCapsule;
        [NMS(Index = 6)]
        /* 0x63 */ public bool UseSimpleCharacterCollision;
    }
}
