namespace MBINCompiler.Models.Structs
{
    public class GcAlienSpeechEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        [NMS(Size = 0x20)]
        public string Text;

        public int WordInteractEffect;

        public string[] WordInteractEffectValues()
        {
            return new[] { "Pain", "Heal" };
        }

        public GcAlienRace AlienRace;
        public int Level;
        [NMS(Ignore = true)]
        public int Padding;
    }
}
