using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x160, GUID = 0x9C67CB22ECD72C8F)]
    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Explosion;
        /* 0x010 */ public float ExplosionScale;
        /* 0x014 */ public bool ExplosionScaleToBounds;
        [NMS(Size = 3, Ignore = true)]
        /* 0x015 */ public byte[] Padding15;

        [NMS(Size = 0x10)]
        /* 0x018 */ public string VehicleDestroyEffect;

        [NMS(Size = 0x10)]
        /* 0x028 */ public string TriggerAction;
        /* 0x038 */ public int IncreaseWanted;
        /* 0x03C */ public bool IncreaseFiendWanted;
        [NMS(Size = 3, Ignore = true)]
        /* 0x03D */ public byte[] Padding3D;

        [NMS(Size = 0x10)]
        /* 0x040 */ public string LootReward;

        /* 0x050 */ public int LootRewardAmountMin;
        /* 0x054 */ public int LootRewardAmountMax;

        /* 0x058 */ public List<GcSubstanceAmount> GivesSubstances;

        /* 0x68 */ public GcStatsEnum StatsToTrack;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x6C */ public byte[] Padding6C;

        [NMS(Size = 0x10)]
        /* 0x070 */ public string GivesReward;
		/* 0x080 */ public float HardModeSubstanceMultiplier;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x084 */ public byte[] Padding84;

        /* 0x088 */ public List<GcRewardMissionOverride> RewardOverrideTable;

        /* 0x098 */ public bool UseSystemColorsForTexture;
        /* 0x099 */ public bool RemoveModel;
        /* 0x09A */ public bool HideModel;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x09B */ public byte[] Padding9B;
        [NMS(Size = 0x80)]
        /* 0x09C */ public TkTextureResource DestroyedModel;
        /* 0x120 */ public bool DestroyedModelUsesScale;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x121 */ public byte[] Padding121;
        /* 0x124 */ public float DestroyForce;
        /* 0x128 */ public float DestroyForceRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x12C */ public byte[] Padding12C;
        [NMS(Size = 0x10)]
        /* 0x130 */ public string DestroyEffect;
        [NMS(Size = 0x10)]
        /* 0x140 */ public string DestroyEffectPoint;
        /* 0x150 */ public float DestroyEffectTime;

        /* 0x154 */ public bool DestroyEffectMatrices;
        /* 0x155 */ public bool ShowInteract;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x156 */ public byte[] Padding156;
        /* 0x158 */ public float ShowInteractRange;
        /* 0x15C */ public bool GrenadeSingleHit;

        [NMS(Size = 3, Ignore = true)]
        /* 0x15D */ public byte[] EndPadding;
    }
}
