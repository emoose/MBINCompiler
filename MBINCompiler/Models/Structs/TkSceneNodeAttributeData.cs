namespace MBINCompiler.Models.Structs
{
    public class TkSceneNodeAttributeData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        [NMS(Size = 0x10)]
        public string AltID;
        [NMS(Size = 0x100)]
        public string Value;
    }
}
