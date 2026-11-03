using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC37D856FF0614918, NameHash = 0x6C3ADDF9)]
    public class GcMissionConditionHazardLevel : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Level;
        [NMS(Index = 0)]
        /* 0x4 */ public GcPlayerHazardType SpecificHazard;
        [NMS(Index = 2)]
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
