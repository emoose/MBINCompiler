using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public GcAlienRace AlienRace;
        public GcInteractionType InteractionType;

        [NMS(Size = 0x200)]
        public string Text;

        [NMS(Size = 0x200)]
        public string TextAlien;

        public bool TranslateAlienText;
        public List<GcAlienPuzzleOption> Options;
    }
}
