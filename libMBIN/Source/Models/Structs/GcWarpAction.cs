namespace libMBIN.Models.Structs
{
    public class GcWarpAction : NMSTemplate
    {
        public int WarpType;
        public string[] WarpTypeValues()
        {
            return new[] { "BlackHole" }; // one value? :D:D
        }
    }
}
