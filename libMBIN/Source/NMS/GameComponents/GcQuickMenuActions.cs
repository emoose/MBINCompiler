using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xDE20A4EEA0840581, NameHash = 0x5EEC6F79915C67C2)]
    public class GcQuickMenuActions : NMSTemplate
    {
        // size: 0x35
        public enum QuickMenuActionsEnum { None, CallFreighter, SummonNexus, CallShip, SummonVehicleSubMenu, SummonBuggy,
            SummonBike, SummonTruck, SummonWheeledBike, SummonHovercraft, SummonSubmarine,
            SummonMech, VehicleScan, VehicleScanSelect, VehicleRestartRace,
            Torch, GalaxyMap, PhotoMode, ChargeMenu, Charge, ChargeSubMenu,
            Repair, BuildMenu, CommunicatorReceive, CommunicatorInitiate, ThirdPersonCharacter,
            ThirdPersonShip, ThirdPersonVehicle, EconomyScan, EmoteMenu,
            Emote, UtilitySubMenu, SummonSubMenu, SummonShipSubMenu, ChangeSecondaryWeaponMenu,
            ChangeSecondaryWeapon, ChooseCreatureFoodMenu, ChooseCreatureFood,
            EmergencyWarp, SwapMultitool, SwapMultitoolSubMenu,
            CreatureSubMenu, SummonPet, SummonPetSubMenu, WarpToNexus, PetUI, ByteBeatSubMenu,
            ByteBeatPlay, ByteBeatStop, ByteBeatLibrary, ReportBase,
            CallRocket, Invalid
        }
        /* 0x0 */ public QuickMenuActionsEnum QuickMenuActions;
    }
}
