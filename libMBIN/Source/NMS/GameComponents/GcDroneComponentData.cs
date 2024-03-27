using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FD10D87A7979DA5, NameHash = 0xE4A9F22B5EB5CBF8)]
    public class GcDroneComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcPrimaryAxis Axis;
        /* 0x14 */ public float Scaler;
        /* 0x18 */ public GcCreatureHealthData Health;
        /* 0x80 */ public List<NMSString0x10> ProjectileChoices;
        /* 0x90 */ public List<GcDroneGun> Guns;
    }
}
