using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CF1040662DE1F07, NameHash = 0x38873007)]
    public class GcVehicleComponentData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public TkModelResource WheelModel;
        [NMS(Index = 2)]
        /* 0x20 */ public GcFilename Cockpit;
        [NMS(Index = 3)]
        /* 0x30 */ public List<GcCustomVehicleCockpitOption> CustomCockpits;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 VehicleType;
        [NMS(Index = 9)]
        /* 0x50 */ public int BaseHealth;
        [NMS(Index = 0)]
        /* 0x54 */ public GcVehicleType Class;
        [NMS(Index = 8)]
        /* 0x58 */ public float FoVFixedDistance;
        [NMS(Index = 6)]
        /* 0x5C */ public float MaxHeadPitchDown;
        [NMS(Index = 5)]
        /* 0x60 */ public float MaxHeadPitchUp;
        [NMS(Index = 4)]
        /* 0x64 */ public float MaxHeadTurn;
        [NMS(Index = 7)]
        /* 0x68 */ public float MinTurretAngle;
    }
}
