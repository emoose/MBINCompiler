namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x75A7492E264F5958)]
    public class GcCreatureHealthData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string HurtAnim;
        [NMS(Size = 0x10)]
        public string DeathAnim;
        [NMS(Size = 0x10)]
        public string DeathEffect;
        [NMS(Size = 0x10)]
        public string HurtAudio;
        [NMS(Size = 0x10)]
        public string DeathAudio;
    }
}
