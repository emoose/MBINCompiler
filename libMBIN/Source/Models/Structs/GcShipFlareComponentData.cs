namespace libMBIN.Models.Structs
{
    public class GcShipFlareComponentData : NMSTemplate
    {
        public int FlareType;
        public string[] FlareTypeValues()
        {
            return new[] { "Default"};
        }
    }
}
