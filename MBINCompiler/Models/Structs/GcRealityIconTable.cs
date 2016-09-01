using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcRealityIconTable : NMSTemplate
    {
        [NMS(Size = 6, EnumValue = new string[6] { "None", "NoOxygen", "ExtremeHeat", "ExtremeCold", "ToxicGas", "Radiation" })]
        public TkTextureResource[] HazardIcons;

        [NMS(Size = 5, EnumValue = new string[5] { "Commodity", "Technology", "Fuel", "Tradeable", "Special" })]
        public TkTextureResource[] SubstanceCategoryIcons;

        [NMS(Size = 4, EnumValue = new string[4] { "Component", "Device", "Consumable", "Curiosity" })]
        public TkTextureResource[] ProductCategoryIcons;

        [NMS(Size = 20, EnumValue = new string[20] { "Stamina", "NoStamina", "EnergyCharge", "Scanner", "NoScanner", "Grave", "Resources", "Inventory", "InventoryFull", "RareItems", "Pirates", "PirateScan", "Drone", "Quad", "Walker", "DroneOff", "Police", "AtlasStation", "BlackHole", "SaveGame" })]
        public TkTextureResource[] GameIcons;
    }
}
