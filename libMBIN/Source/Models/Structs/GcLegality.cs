namespace libMBIN.Models.Structs
{
    public class GcLegality : NMSTemplate
    {
        public int Legality;

        public string[] LegalityValues()
        {
            return new[] { "Legal", "Illegal", "None" };
        }
    }
}
