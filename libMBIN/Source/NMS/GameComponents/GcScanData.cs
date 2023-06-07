using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE0AEF271B0249D8F, NameHash = 0x8531B20A02DD0931)]
    public class GcScanData : NMSTemplate
    {
        /* 0x00 */ public GcScanType ScanType;
        /* 0x04 */ public float PulseRange;
        /* 0x08 */ public float PulseTime;
        /* 0x0C */ public bool AddMarkers;
        /* 0x0D */ public bool PlayAudioOnMarkers;
        /* 0x10 */ public float ChargeTime;
    }
}
