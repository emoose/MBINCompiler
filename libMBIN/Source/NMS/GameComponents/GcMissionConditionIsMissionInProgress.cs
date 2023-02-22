namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2890453EA87F62D7, NameHash = 0x8FA593E74FC53DD5)]
    public class GcMissionConditionIsMissionInProgress : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public bool MustBeSelectedMission;
    }
}
