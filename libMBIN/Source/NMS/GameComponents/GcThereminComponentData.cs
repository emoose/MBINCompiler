namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E9E8E9F0A88323, NameHash = 0xD0E5A023C215AB4A)]
    public class GcThereminComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 VolumeBBName;
        /* 0x20 */ public float VolumeMinDist;
        /* 0x24 */ public float VolumeMaxDist;
        /* 0x28 */ public float MinVolume;
        /* 0x2C */ public float MaxVolume;
        /* 0x30 */ public NMSString0x20 PitchStartLocator;
        /* 0x50 */ public NMSString0x20 PitchEndLocator;
        /* 0x70 */ public float PitchMinDist;
        /* 0x74 */ public float PitchMaxDist;
        /* 0x78 */ public float MinPitch;
        /* 0x7C */ public float MaxPitch;
        /* 0x80 */ public float IgnorePlayerDistance;
    }
}
