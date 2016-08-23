using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcAlienPuzzleOption : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        /* 0x000 */
        public string Name;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x200)]
        /* 0x020 */
        public string Text;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        /* 0x220 */
        public string Cost;

        /* 0x230 */
        public List<NMSString0x10> Rewards;
        /* 0x240 */
        public int Mood;

        public string[] MoodValues()
        {
            return new[] { "Positive", "Negative", "Neutral", "Pity" };
        }

        /* 0x244 */
        public bool KeepOpen;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding;
    }
}
