namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9411927715FC9B8E, NameHash = 0x88530A815E5B1B46)]
    public class GcTurretComponentData : NMSTemplate
    {
        // size: 0x3
        public enum GunTypeEnum : uint {
            Laser,
            Projectile,
            Missile,
        }
        /* 0x00 */ public GunTypeEnum GunType;
        /* 0x08 */ public NMSString0x10 LaserEffectId;
        /* 0x18 */ public NMSString0x10 LaserMuzzleFlashId;
        /* 0x28 */ public NMSString0x10 LaserMuzzleChargeId;
        /* 0x38 */ public NMSString0x10 ProjectileId;
        /* 0x48 */ public NMSString0x10 ProjectileMuzzleFlashId;
        /* 0x58 */ public NMSString0x10 MissileId;
        /* 0x68 */ public bool HasFreighterAlertLight;
        /* 0x6C */ public float TurretRange;
        /* 0x70 */ public float TurretLaserShootTime;
        /* 0x74 */ public float TurretLaserLength;
        /* 0x78 */ public float TurretLaserMoveSpeed;
        /* 0x7C */ public float TurretLaserActiveTime;
        /* 0x80 */ public float TurretLaserChargeTime;
        /* 0x84 */ public float TurretLaserAbortDistance;
        /* 0x88 */ public float TurrentLaserShootTimeRandomExtraMax;
        /* 0x8C */ public float TurretShootPauseTime;
        /* 0x90 */ public int TurretBurstCount;
        /* 0x94 */ public float TurretBurstTime;
        /* 0x98 */ public float LevelledBurstCountExtra;
        /* 0x9C */ public float LevelledBurstTimeMultiplier;
        /* 0xA0 */ public float TurretMissileLaunchTime;
        /* 0xA4 */ public float TurretMissileLaunchSpeed;
        /* 0xA8 */ public float TurretMaxDownAngle;
        /* 0xAC */ public float TurretMaxYawTurnSpeedDegPerSec;
        /* 0xB0 */ public float TurretMaxPitchTurnSpeedDegPerSec;
        /* 0xB4 */ public float TurretYawSmoothTurnTime;
        /* 0xB8 */ public float TurretPitchSmoothTurnTime;
        /* 0xBC */ public float TurretAngle;
        /* 0xC0 */ public float TurretProjectileRange;
        /* 0xC4 */ public float TurretMissileRange;
        /* 0xC8 */ public float TurretDispersionAngle;
        /* 0xCC */ public bool RemotePlayersCanDamage;
        /* 0xCD */ public bool CanMoveDuringBurst;
        /* 0xCE */ public bool FireInTurretFacing;
        /* 0xD0 */ public float TurretAimOffset;
        // size: 0x3
        public enum TargetFilterEnum : uint {
            Any,
            FreightersOnly,
            SmallShipsOnly,
        }
        /* 0xD4 */ public TargetFilterEnum TargetFilter;
        /* 0xD8 */ public float BaseRotationAngleThreshold;
    }
}
