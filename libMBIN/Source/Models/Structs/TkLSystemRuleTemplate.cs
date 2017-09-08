namespace libMBIN.Models.Structs
{
    public class TkLSystemRuleTemplate : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string LSystem;
    }
}
