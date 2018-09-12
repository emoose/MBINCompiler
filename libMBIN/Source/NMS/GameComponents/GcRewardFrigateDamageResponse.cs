namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8441E6AA6DAFDE25)]
    public class GcRewardFrigateDamageResponse : NMSTemplate
    {
		public enum ResponseEnum { StayOut, ReturnHome, CheckForMoreDamage, ShowDamagedCaptain, ShowExpeditionCaptian }
		public ResponseEnum Response;
    }
}
