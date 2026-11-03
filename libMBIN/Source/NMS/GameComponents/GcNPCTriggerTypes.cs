namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x379443FB1014238A, NameHash = 0xED81F7C6)]
    public class GcNPCTriggerTypes : NMSTemplate
    {
        // size: 0x11
        public enum NPCTriggerEnum : uint {
            None,
            Idle,
            Greet,
            Mood,
            StartDead,
            Talk_Start,
            Talk_Stop,
            Interact_Start,
            Interact_Stop,
            Interact_BeginHold,
            Interact_CancelHold,
            LookAt_Player_Start,
            LookAt_Player_Stop,
            SetProp,
            Interact_StartFromRemote,
            StartBusy,
            OneShotMoodResponse,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCTriggerEnum NPCTrigger;
    }
}
