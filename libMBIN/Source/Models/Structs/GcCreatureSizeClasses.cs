namespace libMBIN.Models.Structs
{
    public class GcCreatureSizeClasses : NMSTemplate
    {
        public int CreatureSizeClass;
        public string[] CreatureSizeClassValues()
        {
            return new[]
            {
                "Small", "Medium", "Large", "Huge"
            };
        }
    }
}
