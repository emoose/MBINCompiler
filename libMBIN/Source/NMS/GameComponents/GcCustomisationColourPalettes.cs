using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94332187E55E7E7B, NameHash = 0x8D353F7BD3E655C5)]
    public class GcCustomisationColourPalettes : NMSTemplate
    {
        // size: 0x14
        public enum ColourPalettesEnum {
            Player,
            Vehicle,
            Weapon,
            Ship_01,
            Ship_02,
            Ship_03,
            Ship_04,
            Ship_05,
            Ship_06,
            Vehicle_Bike,
            Vehicle_Truck,
            Vehicle_WheeledBike,
            Vehicle_Hovercraft,
            Vehicle_Submarine,
            Vehicle_Mech,
            Freighter,
            Pet,
            Ship_07,
            Ship_08,
            Ship_09
        }
        [NMS(Size = 0x14, EnumType = typeof(ColourPalettesEnum))]
        /* 0x0000 */ public GcPaletteData[] ColourPalettes;
        // size: 0x14
        public enum ExtraDataEnum {
            Player,
            Vehicle,
            Weapon,
            Ship_01,
            Ship_02,
            Ship_03,
            Ship_04,
            Ship_05,
            Ship_06,
            Vehicle_Bike,
            Vehicle_Truck,
            Vehicle_WheeledBike,
            Vehicle_Hovercraft,
            Vehicle_Submarine,
            Vehicle_Mech,
            Freighter,
            Pet,
            Ship_07,
            Ship_08,
            Ship_09
        }
        [NMS(Size = 0x14, EnumType = typeof(ExtraDataEnum))]
        /* 0x5140 */ public GcCustomisationColourPaletteExtraData[] ExtraData;
    }
}
