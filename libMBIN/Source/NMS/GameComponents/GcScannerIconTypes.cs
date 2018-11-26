using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x40ABD329BE41172E)]
    public class GcScannerIconTypes : NMSTemplate
    {
        // Size: 0x25
		public enum ScanIconTypeEnum { None, Health, Shield, Hazard, Tech, Heridium, Platinum, Chrysonite, Signal, Fuel, Carbon, Plutonium, Thamium, Mineral, Iron, Zinc, Titanium, Multi, Artifact, TechRecipe, RareProp, Trade, Exotic, Plant, RelicCrate, Buried, BuriedRare, Drone, PlaceMarker, HazardPlant, Refiner, Grave, Rare1, Rare2, Rare3, StormCrystal, BiomeTrophy }
		public ScanIconTypeEnum ScanIconType;
    }
}
