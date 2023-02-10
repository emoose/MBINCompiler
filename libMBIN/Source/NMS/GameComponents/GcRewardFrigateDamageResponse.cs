namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4246FD0878C23044, NameHash = 0xFA9A306017ED3640)]
    public class GcRewardFrigateDamageResponse : NMSTemplate
    {
        // size: 0x6
        public enum ResponseEnum {
            StayOut,
            ReturnHome,
            CheckForMoreDamage,
            ShowDamagedCaptain,
            ShowExpeditionCaptain,
            AbortExpedition,
        }
        /* 0x0 */ public ResponseEnum Response;
    }
}
