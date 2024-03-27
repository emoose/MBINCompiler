using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x99BA278E9CAE3BE9, NameHash = 0x4955878C6E8051DB)]
    public class TkStaticPhysicsComponentData : NMSTemplate
    {
        /* 0x00 */ public TkPhysicsData Data;
        /* 0x18 */ public bool AddToWorldOnPrepare;
        /* 0x19 */ public bool AddToWorldImmediately;
        /* 0x1C */ public TkVolumeTriggerType TriggerVolumeType;
        /* 0x20 */ public bool TriggerVolume;
        /* 0x21 */ public bool Climbable;
        /* 0x22 */ public bool NoVehicleCollide;
        /* 0x23 */ public bool NoPlayerCollide;
        /* 0x24 */ public bool CameraInvisible;
    }
}
