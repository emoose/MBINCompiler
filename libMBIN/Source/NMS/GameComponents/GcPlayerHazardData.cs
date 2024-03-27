using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x362521D640B1A7DE, NameHash = 0x18642126695741B5)]
    public class GcPlayerHazardData : NMSTemplate
    {
        /* 0x00 */ public float ProtectionInitialTime;
        /* 0x04 */ public Vector2f ProtectionTime;
        /* 0x0C */ public Vector2f DamageRate;
        /* 0x14 */ public Vector2f WoundRate;
        /* 0x1C */ public float RechargeInitialTime;
        /* 0x20 */ public float RechargeTime;
        /* 0x28 */ public NMSString0x10 Damage;
        /* 0x38 */ public bool Increases;
        /* 0x39 */ public TkCurveType DisplayCurve;
        /* 0x3C */ public float TriggerValue;
        /* 0x40 */ public float CapValue;
        /* 0x44 */ public float CriticalValue;
        /* 0x48 */ public float OutputMultiplier;
        /* 0x4C */ public float OutputMinAddition;
        /* 0x50 */ public float OutputMaxAddition;
    }
}
