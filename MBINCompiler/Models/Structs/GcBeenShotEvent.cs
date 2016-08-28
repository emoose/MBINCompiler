namespace MBINCompiler.Models.Structs
{
    public class GcBeenShotEvent : NMSTemplate
    {
        public int ShotBy;
        public string[] ShotByValues()
        {
            return new[] { "Player", "Anything" };
        }

        public int DamageThreshold;
        public float HealthThreshold;

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC;
    }
}
