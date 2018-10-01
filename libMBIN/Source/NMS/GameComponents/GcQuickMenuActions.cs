using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7E0E9457B5DF185E, Broken = true)]
    public class GcQuickMenuActions : NMSTemplate
    {
		public enum QuickMenuActionsEnum { None, CallFreighter, CallShip, SummonBuggy, SummonBike, SummonTruck, VehicleScan, VehicleScanSelect, VehicleRestartRace, Torch, GalaxyMap, PhotoMode, ChargeMenu, Charge, ChargeSubMenu, Repair, BuildItem, BuildChangeGroup, BuildDelete, BuildColour, BuildMaterial, BuildColourGroup, BuildMaterialGroup, CommunicatorReceive, CommunicatorInitiate, ThirdPersonCharacter, ThirdPersonShip, EconomyScan, EmoteMenu, Emote, UtilitySubMenu, SummonSubMenu, SummonShipSubMenu, ChangeSecondaryWeaponMenu, ChangeSecondaryWeapon, Invalid }
		public QuickMenuActionsEnum QuickMenuActions;
    }
}
