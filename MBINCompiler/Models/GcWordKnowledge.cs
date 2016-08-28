namespace MBINCompiler.Models
{
    public class GcWordKnowledge : NMSTemplate
    {
        public string Word;

        [NMS(Size = 6)]
        public bool[] Races;
    }
}
