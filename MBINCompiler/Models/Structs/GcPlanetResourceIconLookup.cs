namespace MBINCompiler.Models.Structs
{
    public class GcPlanetResourceIconLookup : NMSTemplate        // size: 0x98
    {
        [NMS(Size = 0x10)]
        public string ID;
        public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
