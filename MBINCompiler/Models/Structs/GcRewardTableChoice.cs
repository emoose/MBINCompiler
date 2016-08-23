namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableChoice : NMSTemplate
    {
        public int Choice;
        public string[] ChoiceValues()
        {
            return new[] { "GiveAll", "Select", "TryEach" };
        }
    }
}
