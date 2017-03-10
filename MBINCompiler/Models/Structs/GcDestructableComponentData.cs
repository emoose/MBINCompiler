using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Explosion;
        /* 0x010 */ public float ExplosionScale;
        /* 0x014 */ public bool ExplosionScaleToBounds;
        [NMS(Size = 3, Ignore = true)]
        /* 0x015 */ public byte[] Padding15;

        [NMS(Size = 0x10)]
        /* 0x018 */public string VehicleDestroyEffect;

        [NMS(Size = 0x10)]
        /* 0x028 */ public string TriggerAction;
        /* 0x038 */ public int IncreaseWanted;
        [NMS(Size = 4, Ignore = true)]
        /* 0x03C */ public byte[] Padding3C;

        [NMS(Size = 0x10)]
        /* 0x040 */ public string LootReward;

        /* 0x050 */ public int LootRewardAmountMin;
        /* 0x054 */ public int LootRewardAmountMax;

        /* 0x058 */ public List<GcSubstanceAmount> GivesSubstances;
        [NMS(Size = 0x10)]
        /* 0x068 */ public string GivesReward;
		/* 0x078 */ public float HardModeSubstanceMultiplier;

        /* 0x07C */ public bool RemoveModel;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x07D */ public byte[] Padding7D;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DestroyedModel;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x100 */ public byte[] Padding100;
        /* 0x104 */ public bool DestroyedModelUsesScale;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x105 */public byte[] Padding105;
        /* 0x108 */ public float DestroyForce;
        /* 0x10C */ public float DestroyForceRadius;
        [NMS(Size = 0x10)]
        /* 0x110 */ public string DestroyEffect;
        [NMS(Size = 0x10)]
        /* 0x120 */ public string DestroyEffectPoint;
        /* 0x130 */ public float DestroyEffectTime;

        /* 0x134 */ public bool ShowInteract;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x135 */ public byte[] Padding135;
        /* 0x138 */ public float ShowInteractRange;
        /* 0x13C */ public bool GrenadeSingleHit;

        [NMS(Size = 3, Ignore = true)]
        /* 0x13D */ public byte[] Padding13D;
    }
}
