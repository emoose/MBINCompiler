using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4804062C877D7175, NameHash = 0x5995CC3B21976698)]
    public class GcCreatureDebugSpawnData : NMSTemplate
    {
        /* 0x00 */ public int CreatureIndex;
        /* 0x04 */ public float InitialDelay;
        /* 0x08 */ public List<GcCreatureDebugWaypoint> Waypoints;
        // size: 0x3
        public enum OnCompleteEnum : uint {
            Hold,
            Loop,
            Destroy,
        }
        /* 0x18 */ public OnCompleteEnum OnComplete;
        /* 0x1C */ public float SmoothTime;
        /* 0x20 */ public int CurrentWaypoint;
        /* 0x24 */ public bool ArrivedAtCurrentWaypoint;
        /* 0x28 */ public float Timer;
        /* 0x2C */ public float SmoothTimer;
    }
}
