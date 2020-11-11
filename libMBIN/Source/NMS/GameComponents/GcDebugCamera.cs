using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xDCE2D4890B1CD4AD, NameHash = 0xC7724B26F8E50BC5)]
    public class GcDebugCamera : NMSTemplate
    {
        /* 0x00 */ public float BaseSpeed;
        /* 0x04 */ public float Smoothing;
        /* 0x08 */ public List<NMSString0x10> Waypoints;  // Note: I think this is a list of some inbuilt type, but it's only used here... so no idea...
        /* 0x18 */ public int CurrentWaypoint;
        /* 0x1C */ public float CurrentWaypointProgress;
    }
}
