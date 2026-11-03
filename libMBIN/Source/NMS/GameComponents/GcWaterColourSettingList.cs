using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70C0B88C85F0B84D, NameHash = 0x8EA66BD5)]
    public class GcWaterColourSettingList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcPlanetWaterColourData> Settings;
        [NMS(Index = 1, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x10 */ public GcWaterEmissionBiomeData[] EmissionTypeSelection;
    }
}
