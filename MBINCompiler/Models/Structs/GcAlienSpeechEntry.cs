using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcAlienSpeechEntry : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Text;

        public int WordInteractEffect;

        public string[] WordInteractEffectValues()
        {
            return new[] { "Pain", "Heal" };
        }

        public GcAlienRace AlienRace;
        public int Level;
        [NMSAttribute(Ignore = true)]
        public int Padding;
    }
}
