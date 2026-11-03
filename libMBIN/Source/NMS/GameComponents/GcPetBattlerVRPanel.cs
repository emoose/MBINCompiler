namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99B7ABB9F6B17EB8, NameHash = 0xD7ACDB9A)]
    public class GcPetBattlerVRPanel : NMSTemplate
    {
        // size: 0x7
        public enum PetBattlerVRPanelEnum : byte {
            CombatLog,
            LocalPlayer,
            Opponent,
            Actions,
            OpponentActions,
            MatchInfo,
            Popup,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerVRPanelEnum PetBattlerVRPanel;
    }
}
