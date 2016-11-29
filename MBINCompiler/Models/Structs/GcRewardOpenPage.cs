namespace MBINCompiler.Models.Structs
{
    public class GcRewardOpenPage : NMSTemplate
    {
        public int PageToOpen;
        public string[] PageToOpenValues()
        {
            return new[] { "FreighterShipTransfer"};
        }
    }
}
