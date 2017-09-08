using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x14)]
    public class GcInteractionDof : NMSTemplate     // in global?
    {
        /* 0x00 */ public bool IsEnabled;           // 101h     (ie. including next byte)
        /* 0x01 */ public bool UseGlobals;
        /* 0x04 */ public float NearPlaneMin;       // 40000000h
        /* 0x08 */ public float NearPlaneAdjust;    // 3F800000h
        /* 0x0C */ public float FarPlane;           // 40400000h
        /* 0x10 */ public float FarFadeDistance;    // 40000000h
    }
}
