using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1639F80C9E1E506E, NameHash = 0x28E8DAB19EC55198)]
    public class GcCreatureComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcPrimaryAxis Axis;
        /* 0x14 */ public float Scaler;
        /* 0x18 */ public float PetIndoorScaler;
        /* 0x20 */ public NMSString0x10 DeathEffect;
        /* 0x30 */ public List<GcReplacementEffectData> ReplacementImpacts;
        /* 0x40 */ public float AccessoryPitchOffset;
        /* 0x44 */ public float DiscoveryFurScaler;
        /* 0x48 */ public float DiscoveryUIScaler;
        /* 0x50 */ public Vector3f DiscoveryUIOffset;
        /* 0x60 */ public List<GcCreatureDiscoveryThumbnailOverride> ThumbnailOverrides;
        /* 0x70 */ public bool UsePetLargeUIOverride;
        /* 0x74 */ public float PetLargeUIOverrideScaler;
        /* 0x80 */ public Vector3f PetLargeUIOverrideOffset;
    }
}
