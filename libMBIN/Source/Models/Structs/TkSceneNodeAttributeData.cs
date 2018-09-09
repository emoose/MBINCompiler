namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x65B3EC85D2F35211)]
    public class TkSceneNodeAttributeData : NMSTemplate     // size: 0x130
    {
        [NMS(Size = 0x10)]
        public string Name;
        [NMS(Size = 0x20)]
        public string AltID;
        [NMS(Size = 0x100)]
        public string Value;
    }
}
