namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5643EEDB60F585F4, NameHash = 0xFA78E3D1251A147D)]
    public class GcPlayerSpaceshipClassBonuses : NMSTemplate
    {
        /* 0x00 */ public float ThrustForceMax;
        /* 0x04 */ public float ThrustForceMin;
        /* 0x08 */ public float MaxSpeedMax;
        /* 0x0C */ public float MaxSpeedMin;
        /* 0x10 */ public float BoostMaxSpeedMax;
        /* 0x14 */ public float BoostMaxSpeedMin;
        /* 0x18 */ public float BoostingTurnDampMax;
        /* 0x1C */ public float BoostingTurnDampMin;
        /* 0x20 */ public float DirectionBrakeMin;
        /* 0x24 */ public float DirectionBrakeMax;
        /* 0x28 */ public float TurnStrengthMax;
        /* 0x2C */ public float TurnStrengthMin;
    }
}
