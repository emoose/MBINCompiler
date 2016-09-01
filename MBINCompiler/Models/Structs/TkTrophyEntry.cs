namespace MBINCompiler.Models.Structs
{
    public class TkTrophyEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TrophyId;
        public int Ps4Id;
        [NMS(Size = 0x40)]
        public string PCId;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding54;
    }
}
