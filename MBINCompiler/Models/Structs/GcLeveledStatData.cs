namespace MBINCompiler.Models.Structs
{
    public class GcLeveledStatData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StatId;
        [NMS(Size = 0x20)]
        public string StatTitle;
        [NMS(Size = 0x20)]
        public string NotifyMessage;
        [NMS(Size = 0x20)]
        public string NotifyMessageSingular;

        public bool ShowInTerminal;
        public bool ShowStatLevel;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] Padding72;
        public TkTextureResource Icon;
        [NMS(Size = 0xB)]
        public GcStatLevelData[] StatLevels;
    }
}
