namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0FE1CDC6167AE7D3B)]
    public class GcCreatureVocalSoundData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

		public enum VocalEmoteEnum { EmoteIdle, EmoteFlee, EmoteAggression, EmoteRoar, EmotePain, EmoteAttack, EmoteDie, EmoteMiniRoarNeutral, EmoteMiniRoarHappy, EmoteMiniRoarAngry }
		public VocalEmoteEnum VocalEmote;

        public float PlayFrequency;
        public float MinCooldown;
        public float MaxCooldown;
        public bool PlayImmediately;
        public bool PlayOnlyOnce;

        [NMS(Size = 6, Ignore = true)]
        public byte[] Padding22;
    }
}
