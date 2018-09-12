using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x83655D33DC843EE4)]
    public class GcVehicleComponentData : NMSTemplate
    {
        /* 0x00 */ public GcVehicleType Class;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string VehicleType;
        [NMS(Size = 0x80)]
        /* 0x18 */ public string Cockpit;
        /* 0x98 */ public float MaxHeadTurn;
        /* 0x9C */ public float MaxHeadPitchUp;
        /* 0xA0 */ public float MaxHeadPitchDown;
        /* 0xA4 */ public float FoVFixedDistance;
        /* 0xA8 */ public int BaseHealth;
        /* 0xAC */ public TkModelResource WheelModel;
    }
}
