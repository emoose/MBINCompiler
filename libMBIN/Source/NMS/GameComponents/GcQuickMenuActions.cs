using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7E0E9457B5DF185E)]
    public class GcQuickMenuActions : NMSTemplate
    {
        // size: 0x28
		public enum QuickMenuActionsEnum { None, CallFreighter, CallShip, SummonVehicleSubMenu, SummonBuggy, SummonBike, SummonTruck,
            SummonWheeledBike, SummonHovercraft, SummonSubmarine, VehicleScan, VehicleScanSelect, VehicleRestartRace, Torch, GalaxyMap,
            PhotoMode, ChargeMenu, Charge, ChargeSubMenu, Repair, BuildItem, BuildChangeGroup, BuildDelete, BuildColour, BuildMaterial,
            BuildColourGroup, BuildMaterialGroup, CommunicatorReceive, CommunicatorInitiate, ThirdPersonCharacter, ThirdPersonShip,
            EconomyScan, EmoteMenu, Emote, UtilitySubMenu, SummonSubMenu, SummonShipSubMenu, ChangeSecondaryWeaponMenu, ChangeSecondaryWeapon,
            Invalid }
        public QuickMenuActionsEnum QuickMenuActions;
    }
}
