using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
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
