namespace MBINCompiler.Models.Structs
{
    public class GcMissionConditionStatLevel : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Stat;
        [NMS(Size = 0x10)]
        public string StatGroup;
        public int Level;
        public TkEqualityEnum Test;
    }
}
