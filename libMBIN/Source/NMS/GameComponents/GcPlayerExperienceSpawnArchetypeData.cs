using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0x4195C66D915283D7, NameHash = 0x3D6AF30F10DB0EAA)]
    public class GcPlayerExperienceSpawnArchetypeData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string GenerateResource;
        /* 0x20 */ public GcCreatureTypes Type;
        /* 0x24 */ public float Scale;
        /* 0x28 */ public float ScaleVariation;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] Padding2C;
        [NMS(Size = 0x10)]
        /* 0x30 */ public string AppearAnim;
        /* 0x40 */ public float SpeedMultiplier;
        /* 0x44 */ public int HealthOverride;
        [NMS(Size = 0x10)]
        /* 0x48 */ public string DamageOverride;
        [NMS(Size = 0x10)]
        /* 0x58 */ public string DamageReceivedMultiplier;
        /* 0x68 */ public float SpawnDistOverride;
        /* 0x6C */ public float DespawnDistOverride;
        /* 0x70 */ public List<NMSTemplate> BehaviourOverrides;
    }
}
