namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1FA54D54FA89D565, NameHash = 0x90485A00D3954CE2)]
    public class GcAtmosphereEntryComponentData : NMSTemplate
    {
        /* 0x00 */ public bool AutoEntry;
        /* 0x04 */ public float EntryTime;
        /* 0x08 */ public float EntryOffset;
        /* 0x0C */ public float EditTerrainRadius;
        /* 0x10 */ public NMSString0x10 ImpactEffect;
        /* 0x20 */ public NMSString0x10 FlareEffect;
    }
}
