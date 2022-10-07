namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC3435145E07F1AFE, NameHash = 0x4CC02B5A253167FD)]
    public class TkAnimationGameData : NMSTemplate
    {
        /* 0x0 */ public bool RootMotionEnabled;
        /* 0x1 */ public bool BlockPlayerMovement;
        // size: 0x3
        public enum BlockPlayerWeaponEnum {
            Unblocked,
            Sheathed,
            OutButCannotFire
        }
        /* 0x4 */ public BlockPlayerWeaponEnum BlockPlayerWeapon;
    }
}
