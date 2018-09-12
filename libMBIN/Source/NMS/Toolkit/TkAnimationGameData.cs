namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x8, GUID = 0x0C3435145E07F1AFE)]
    public class TkAnimationGameData : NMSTemplate
    {
        public bool RootMotionEnabled;
        public bool BlockPlayerMovement;
		public enum BlockPlayerWeaponEnum { Unblocked, Sheathed, OutButCannotFire }
		public BlockPlayerWeaponEnum BlockPlayerWeapon;
    }
}
