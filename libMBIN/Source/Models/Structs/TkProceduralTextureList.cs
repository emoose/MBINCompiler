namespace libMBIN.Models.Structs
{
    public class TkProceduralTextureList : NMSTemplate      //size: 0x200
    {
        [NMS(Size = 0x8)]
        public TkProceduralTextureLayer[] Layers;
    }
}
