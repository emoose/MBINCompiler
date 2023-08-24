using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FAAC3AC4647D07B, NameHash = 0x3FACFB36175544A6)]
    public class GcRewardFrigateFlyby : NMSTemplate
    {
        /* 0x000 */ public GcFrigateFlybyType FlybyType;
        /* 0x004 */ public float AppearanceDelay;
        /* 0x008 */ public NMSString0x20A CommunicatorOSDLocId;
        /* 0x028 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
        /* 0x080 */ public TkTextureResource MarkerIcon;
        /* 0x104 */ public GcAudioWwiseEvents PulseAudio;
        /* 0x108 */ public GcAudioWwiseEvents AudioSting;
        /* 0x110 */ public NMSString0x10 CameraShake;
    }
}
