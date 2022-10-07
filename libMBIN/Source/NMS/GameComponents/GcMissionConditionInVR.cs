namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FDBA424CB55A384, NameHash = 0xC52227A9653C40A8)]
    public class GcMissionConditionInVR : NMSTemplate
    {
        /* 0x0 */ public bool NeedsHandControllers;
        /* 0x1 */ public bool NeedsSnapTurnOn;
        /* 0x2 */ public bool NeedsNoHandControllers;
        /* 0x3 */ public bool NeedsTeleportOn;
        /* 0x4 */ public bool NeedsSmoothMoveOn;
    }
}
