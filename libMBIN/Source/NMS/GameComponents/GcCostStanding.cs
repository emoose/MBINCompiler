using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x23B8916A32F09835, NameHash = 0x529C5D98B446B5B2)]
    public class GcCostStanding : NMSTemplate
    {
        /* 0x0 */ public GcAlienRace Race;
        /* 0x4 */ public int RequiredStanding;
    }
}
