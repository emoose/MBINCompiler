using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD96E3A3A21F98E23)]
    public class GcCreatureAlertData : NMSTemplate          // in creature global?
    {
        /* 0x000 */ public GcCreatureTypes AlertTarget;
		/* 0x004 */ public GcCreatureTypes AlertInitiator;
		/* 0x008 */ public float HearingRange;              // 42C80000h
		/* 0x00C */ public float SightRange;                // 43160000h
		/* 0x010 */ public float SightAngle;                // 42700000h
		/* 0x014 */ public float FleeRange;                 // 41700000h
    }
}
