using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x77D27CE2F5C655FC)]
    public class GcSolarSystemEventWarpOut : NMSTemplate
    {
        /* 0x00 */ public float Time;
        [NMS(Size = 0x20)]
        /* 0x04 */ public  string SquadName;
        /* 0x24 */ public Vector2f WarpIntervalRange;
    }
}
