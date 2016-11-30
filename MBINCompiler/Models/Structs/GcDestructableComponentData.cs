using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Explosion;
        /* 0x010 */ public float ExplosionScale;
        [NMS(Size = 4, Ignore = true)]
        /* 0x014 */ public byte[] Padding14;

        [NMS(Size = 0x10)]
        /* 0x018 */ public string TriggerAction;
        /* 0x028 */ public int IncreaseWanted;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02C */ public byte[] Padding2C;

        [NMS(Size = 0x10)]
        /* 0x030 */ public string LootReward;

        /* 0x040 */ public int LootRewardAmountMin;
        /* 0x044 */ public int LootRewardAmountMax;

        /* 0x048 */ public List<GcSubstanceAmount> GivesSubstances;
        [NMS(Size = 0x10)]
        /* 0x058 */ public string GivesReward;
		/* 0x068 */ public float HardModeSubstanceMultiplier;

        /* 0x06C */ public bool RemoveModel;
        /* 0x070 */ public TkModelResource DestroyedModel;
        /* 0x0F4 */ public bool DestroyedModelUsesScale;
        /* 0x0F8 */ public float DestroyForce;
        /* 0x0FC */ public float DestroyForceRadius;
        [NMS(Size = 0x10)]
        /* 0x100 */ public string DestroyEffect;
        [NMS(Size = 0x10)]
        /* 0x110 */ public string DestroyEffectPoint;
        /* 0x120 */ public float DestroyEffectTime;

        /* 0x124 */ public bool ShowInteract;
        /* 0x128 */ public float ShowInteractRange;
        /* 0x12C */ public bool GrenadeSingleHit;

        [NMS(Size = 3, Ignore = true)]
        /* 0x12D */ public byte[] Padding12D;
    }
}
