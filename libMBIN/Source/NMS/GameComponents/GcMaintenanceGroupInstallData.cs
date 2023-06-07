using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB766931C9EC5EC4, NameHash = 0x89DE1BAB1C9B553D)]
    public class GcMaintenanceGroupInstallData : NMSTemplate
    {
        /* 0x00 */ public GcMaintenanceElementGroups ItemGroupOverride;
        /* 0x04 */ public bool DismantleIsDelete;
        /* 0x05 */ public bool InstallIsFree;
        /* 0x06 */ public bool HideChargingInfo;
        /* 0x08 */ public NMSString0x20A InstallTitle;
        /* 0x28 */ public NMSString0x20A InstallSubtitle;
        /* 0x48 */ public NMSString0x20A UninstallTitle;
        /* 0x68 */ public NMSString0x20A UninstallSubtitle;
        /* 0x88 */ public int BuildingSeedOffset;
        /* 0x8C */ public GcAudioWwiseEvents OverrideAudioID;
    }
}
