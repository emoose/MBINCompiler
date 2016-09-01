using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        [NMS(Size = 0x20)]
        public string Genus;

        public GcCreatureTypes CreatureType;

        public int MoveArea;
        public string[] MoveAreaValues()
        {
            return new[] { "Ground", "Water", "Air", "Space" };
        }

        public float MinScale;
        public float MaxScale;
        public GcRarity Rarity;

        public List<NMSTemplate> Data;
    }
}
