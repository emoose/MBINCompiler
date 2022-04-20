using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x118, GUID = 0x1EEBD7521D58173F, NameHash = 0x3FACFB36175544A6)]
    public class GcRewardFrigateFlyby : NMSTemplate
    {
        /* 0x000 */ public GcFrigateFlybyType FlybyType;
        /* 0x004 */ public float AppearanceDelay;
        /* 0x008 */ public NMSString0x20A CommunicatorOSDLocId;
        /* 0x028 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
        /* 0x078 */ public TkTextureResource MarkerIcon;
        /* 0x0FC */ public GcAudioWwiseEvents PulseAudio;
        /* 0x100 */ public GcAudioWwiseEvents AudioSting;
        /* 0x108 */ public NMSString0x10 CameraShake;
    }
}
