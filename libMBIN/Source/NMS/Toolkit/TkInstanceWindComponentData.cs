namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4743D4F13524728B, NameHash = 0xE02A1CA9048E3A96)]
    public class TkInstanceWindComponentData : NMSTemplate
    {
        /* 0x00 */ public bool EnableLdsWind;
        /* 0x04 */ public float BaseMass;
        /* 0x08 */ public float MassReduction;
        /* 0x0C */ public float BaseSpring;
        /* 0x10 */ public float SpringReduction;
        /* 0x14 */ public float LinearDamping;
        /* 0x18 */ public float SpringNonDirFactor;
        /* 0x1C */ public float SpringLengthFactor;
    }
}
