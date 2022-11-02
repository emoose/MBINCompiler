namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2A330E82F30567DD, NameHash = 0x9B8944FB55B77041)]
    public class GcPainAction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Damage;
        /* 0x10 */ public float Radius;
        /* 0x14 */ public bool RadiusBasedDamage;
        /* 0x15 */ public bool AffectsPlayer;
        /* 0x18 */ public float RetriggerTime;
    }
}
