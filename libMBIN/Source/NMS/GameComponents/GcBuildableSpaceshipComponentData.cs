using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x325ADB05383E6D45, NameHash = 0x948DF22E)]
    public class GcBuildableSpaceshipComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFilename> InitialLayouts;
    }
}
