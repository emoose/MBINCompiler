namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1857D80E0D173CE6, NameHash = 0xFC7077C2)]
    public class TkAnimationGameData : NMSTemplate
    {
        // size: 0x3
        public enum RootMotionEnum : uint {
            None,
            EnabledWithGravity,
            EnabledFullControl,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public RootMotionEnum RootMotion;
        [NMS(Index = 1)]
        /* 0x4 */ public bool BlockPlayerMovement;
        // size: 0x3
        public enum BlockPlayerWeaponEnum : uint {
            Unblocked,
            Sheathed,
            OutButCannotFire,
        }
        [NMS(Index = 2)]
        /* 0x8 */ public BlockPlayerWeaponEnum BlockPlayerWeapon;
    }
}
