using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38E0, GUID = 0xFEB57F7A1D0FB6A8, SubGUID = 0x8D353F7BD3E655C5)]
    public class GcCustomisationColourPalettes : NMSTemplate
    {
        [NMS(Size = 0xE, EnumValue = new[] {"Player", "Vehicle", "Weapon", "Ship_01", "Ship_02", "Ship_03", "Ship_04", "Ship_05", "Ship_06",
                                                "Vehicle_Bike", "Vehicle_Truck", "Vehicle_WheeledBike", "Vehicle_Hovercraft", "Vehicle_Submarine" })]
        public GcPaletteData[] ColourPalettes;
    }
}
