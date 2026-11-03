using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5D53D0BE92D0C32, NameHash = 0xC10BA45)]
    public class GcDroneComponentData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public GcCreatureHealthData Health;
        [NMS(Index = 11)]
        /* 0x68 */ public List<GcDroneGun> Guns;
        [NMS(Index = 0)]
        /* 0x78 */ public NMSString0x10 Id;
        [NMS(Index = 10)]
        /* 0x88 */ public List<NMSString0x10> ProjectileChoices;
        [NMS(Index = 1)]
        /* 0x98 */ public GcPrimaryAxis Axis;
        [NMS(Index = 4)]
        /* 0x9C */ public float HeadLookIdleTime;
        [NMS(Index = 3)]
        /* 0xA0 */ public float HeadLookTime;
        [NMS(Index = 6)]
        /* 0xA4 */ public float MaxHeadPitch;
        [NMS(Index = 8)]
        /* 0xA8 */ public float MaxHeadRoll;
        [NMS(Index = 7)]
        /* 0xAC */ public float MaxHeadYaw;
        [NMS(Index = 2)]
        /* 0xB0 */ public float Scaler;
        [NMS(Index = 5)]
        /* 0xB4 */ public NMSString0x100 HeadJointName;
    }
}
