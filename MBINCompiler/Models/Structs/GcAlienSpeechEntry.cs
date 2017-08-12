namespace MBINCompiler.Models.Structs
{
    public class GcAlienSpeechEntry : NMSTemplate       // size: 0x40
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;

        [NMS(Size = 0x20)]
        /* 0x10 */ public string Text;

        /* 0x30 */ public int WordInteractEffect;
        public string[] WordInteractEffectValues()
        {
            return new[] { "Pain", "Heal" };
        }

        /* 0x34 */ public GcAlienRace AlienRace;
        /* 0x38 */ public int Level;
        [NMS(Ignore = true)]
        public int EndPadding;
    }
}
