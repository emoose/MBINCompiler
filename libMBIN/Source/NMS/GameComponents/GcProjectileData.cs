using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3C0, GUID = 0x678C02B9E33C9DEB, NameHash = 0x98B648B5C054B7F7)]
    public class GcProjectileData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public GcResourceElement Model;
        /* 0x2B8 */ public GcAudioWwiseEvents FireAudioEvent;
        /* 0x2BC */ public GcAudioWwiseEvents OverheatAudioEvent;
        /* 0x2C0 */ public float Scale;
        /* 0x2C4 */ public bool IsAutonomous;
        /* 0x2C8 */ public float Radius;
        /* 0x2CC */ public float CapsuleHeight;
        /* 0x2D0 */ public float Speed;
        /* 0x2D4 */ public float Gravity;
        /* 0x2D8 */ public float Life;
        /* 0x2DC */ public float Offset;
        /* 0x2E0 */ public float RagdollPush;
        /* 0x2E4 */ public float PhysicsPush;
        /* 0x2E8 */ public int Damage;
        /* 0x2EC */ public GcDamageType DamageType;
        /* 0x2F0 */ public int Bounces;
        /* 0x2F4 */ public float BounceMaxSpeed;
        /* 0x2F8 */ public float BounceDamping;
        /* 0x2FC */ public float BounceFinalStopTime;
        /* 0x300 */ public bool HitOnBounce;
        /* 0x308 */ public NMSString0x10 PlayerDamage;
        /* 0x318 */ public bool UseCustomBulletData;
        /* 0x31C */ public GcProjectileLineData CustomBulletData;
        /* 0x344 */ public bool UseDamageNumberData;
        /* 0x348 */ public float DamageImpactMergeTime;
        /* 0x34C */ public float DamageImpactTimeBetweenNumbers;
        /* 0x350 */ public float DamageImpactMinDistance;
        /* 0x360 */ public Colour Colour;
        [Flags]
        public enum BehaviourFlagsEnum { None = 0x00, DestroyTerrain = 0x01, DestroyAsteroids = 0x02, GatherResources = 0x04,
            Homing = 0x08, HomingLaser = 0x10, ScareCreatures = 0x20, ExplosionForce = 0x40}
        [NMSDescription("The enum that describes this field uses flags. This means that multiple values may be specified simultaneously" +
                        "by using the notation 'DestroyTerrain|Homing'. Ie. split values with a | character")]
        /* 0x370 */ public BehaviourFlagsEnum BehaviourFlags;
        public enum ClassEnum { Player, PlayerShip, Ship, Robot }
        /* 0x374 */ public ClassEnum Class;
        /* 0x378 */ public NMSString0x10 DefaultImpact;
        /* 0x388 */ public NMSString0x10 CriticalImpact;
        /* 0x398 */ public List<GcProjectileImpactData> Impacts;
        /* 0x3B0 */ public Vector3f ImpactOffset;
    }
}
