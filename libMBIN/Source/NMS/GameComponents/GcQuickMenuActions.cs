using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x40E826294ED747CE, NameHash = 0x5EEC6F79915C67C2)]
    public class GcQuickMenuActions : NMSTemplate
    {
        // size: 0x32
		public enum QuickMenuActionsEnum {
            None, CallFreighter, SummonNexus, CallShip, SummonVehicleSubMenu, SummonBuggy, SummonBike, SummonTruck, SummonWheeledBike, SummonHovercraft,
            SummonSubmarine, SummonMech, VehicleScan, VehicleScanSelect, VehicleRestartRace, Torch, GalaxyMap, PhotoMode, ChargeMenu, Charge,
            ChargeSubMenu, Repair, BuildMenu, CommunicatorReceive, CommunicatorInitiate, ThirdPersonCharacter, ThirdPersonShip, ThirdPersonVehicle, EconomyScan, EmoteMenu,
            Emote, UtilitySubMenu, SummonSubMenu, SummonShipSubMenu, ChangeSecondaryWeaponMenu, ChangeSecondaryWeapon, ChooseCreatureFoodMenu, ChooseCreatureFood, EmergencyWarp, SwapMultitool,
            SwapMultitoolSubMenu, CreatureSubMenu, SummonPet, WarpToNexus, PetUI, ByteBeatSubMenu, ByteBeatPlay, ByteBeatStop, ByteBeatLibrary, Invalid
        }
        public QuickMenuActionsEnum QuickMenuActions;
    }
}
