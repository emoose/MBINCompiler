using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD470919B8A2F4197, NameHash = 0x6CE18BA2B414C4ED)]
    public class GcRewardSetInteractionMissionState : NMSTemplate
    {
        /* 0x0 */ public GcInteractionMissionState MissionState;
        /* 0x4 */ public bool SetForThisInteraction;
        /* 0x8 */ public GcInteractionType SetForInteractionClassInMyBuilding;
    }
}
