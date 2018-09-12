namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x23D1A40BAFED32A4)]
    public class GcBeenShotEvent : NMSTemplate
    {
		public enum ShotByEnum { Player, Anything }
		public ShotByEnum ShotBy;

        public int DamageThreshold;
        public float HealthThreshold;
    }
}
