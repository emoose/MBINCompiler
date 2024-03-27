using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AC29EE3849817B5, NameHash = 0x8531B20A02DD0931)]
    public class GcScanData : NMSTemplate
    {
        /* 0x00 */ public GcScanType ScanType;
        /* 0x04 */ public float PulseRange;
        /* 0x08 */ public float PulseTime;
        /* 0x0C */ public bool AddMarkers;
        /* 0x0D */ public bool PlayAudioOnMarkers;
        /* 0x10 */ public float ChargeTime;
        /* 0x14 */ public float ScanRevealDelay;
        // size: 0x3
        public enum CameraEventTypeEnum : uint {
            None,
            AerialView,
            LookAt,
        }
        /* 0x18 */ public CameraEventTypeEnum CameraEventType;
        /* 0x20 */ public NMSString0x10 CameraEventId;
        // size: 0x3
        public enum CameraEventFocusTargetTypeEnum : uint {
            None,
            ScanEventBuilding,
            RevealedNPC,
        }
        /* 0x30 */ public CameraEventFocusTargetTypeEnum CameraEventFocusTargetType;
    }
}
