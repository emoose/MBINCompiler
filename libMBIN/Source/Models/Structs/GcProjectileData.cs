using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcProjectileData : NMSTemplate     // 0x390
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        /* 0x010 */ public GcResourceElement Model;
        /* 0x2B8 */ public GcAudioWwiseEvents FireAudioEvent;
        /* 0x2BC */ public GcAudioWwiseEvents OverheatAudioEvent;
        /* 0x2C0 */ public float Scale;
        /* 0x2C4 */ public bool isAutonomous;
        /* 0x2C8 */ public float Radius;
        /* 0x2CC */ public float Speed;
        /* 0x2D0 */ public float Gravity;
        /* 0x2D4 */ public float Life;
        /* 0x2D8 */ public float Offset;
        /* 0x2DC */ public float RagdollPush;
        /* 0x2E0 */ public int Damage;
        /* 0x2E4 */ public int MiningDamage;
        /* 0x2E8 */ public int Bounces;
        /* 0x2EC */ public bool HitOnBounce;
        [NMS(Size = 3, Ignore = true)]
        /* 0x2ED */ public byte[] Padding2ED;

        [NMS(Size = 0x10)]
        /* 0x2F0 */ public string PlayerDamage;
        /* 0x300 */ public bool UseCustomBulletData;
        /* 0x304 */ public GcProjectileLineData CustomBulletData;
        /* 0x32C */ public bool UseDamageNumberData;
        /* 0x330 */ public float DamageImpactMergeTime;
        /* 0x334 */ public float DamageImpactTimeBetweenNumbers;
        /* 0x338 */ public float DamageImpactMinDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x33C */ public byte[] Padding33C;
        /* 0x340 */ public Colour Colour;

        public int BehaviourFlags;
        /* 0x350 */ public Dictionary<int, string> BehaviourFlagsDict()
        {
            return new Dictionary<int, string>
            {
                {0x00, "None"},
                {0x01, "DestroyTerrain"},
                {0x02, "DestroyAsteroids"},
                {0x04, "GatherResources"},
                {0x08, "Homing"},
                {0x10, "HomingLaser"},
                {0x20, "ScareCreatures"},
                {0x40, "ExplosionForce"}
            };
        }

        public int Class;
        /* 0x354 */ public string[] ClassValues()
        {
            return new[] { "Player", "PlayerShip", "Ship", "Robot"};
        }

        

        [NMS(Size = 0x10)]
        /* 0x358 */ public string DefaultImpact;
        [NMS(Size = 0x10)]
        /* 0x368 */ public string CriticalImpact;
        /* 0x378 */ public List<GcProjectileImpactData> Impacts;
        [NMS(Size = 8, Ignore = true)]
        /* 0x388 */ public byte[] EndPadding;
    }
}
