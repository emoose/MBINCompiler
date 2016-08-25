using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcProjectileData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        /* 0x010 */ public GcResourceElement Model;
        /* 0x2B8 */ public GcAudioWwiseEvents AkEvent;
        /* 0x2BC */ public float Scale;
        /* 0x2C0 */ public float Radius;
        /* 0x2C4 */ public float Speed;
        /* 0x2C8 */ public float Gravity;
        /* 0x2CC */ public float Life;
        /* 0x2D0 */ public float Offset;
        /* 0x2D4 */ public float RagdollPush;
        /* 0x2D8 */ public int Damage;
        /* 0x2DC */ public int MiningDamage;
        /* 0x2E0 */ public int Bounces;
        /* 0x2E4 */ public bool HitOnBounce;
        [NMS(Size = 3, Ignore = true)]
        /* 0x2E5 */ public byte[] Padding2E5;

        [NMS(Size = 0x10)]
        /* 0x2E8 */ public string PlayerDamage;
        /* 0x300 */ public Colour Colour;
        [NMS(Size = 4, Ignore = true)]
        /* 0x310 */ public byte[] Padding310;

        /* 0x314 */ public int Class;
        public string[] ClassValues()
        {
            return new[] { "Player", "PlayerShip", "Ship", "Robot" };
        }

        [NMS(Size = 0x10)]
        /* 0x318 */ public string DefaultImpact;
        /* 0x328 */ public List<GcProjectileImpactData> Impacts;
        [NMS(Size = 8)]
        /* 0x338 */ public byte[] Padding338;
    }
}
