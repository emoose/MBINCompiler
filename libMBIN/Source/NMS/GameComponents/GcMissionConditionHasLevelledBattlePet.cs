using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4DED5205D682D56A, NameHash = 0x9A3538A0)]
    public class GcMissionConditionHasLevelledBattlePet : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcPetBattlerCoreStat StatToHighlight;
        [NMS(Index = 0)]
        /* 0x4 */ public int TargetLevel;
    }
}
