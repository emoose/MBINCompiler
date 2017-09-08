namespace libMBIN.Models.Structs
{
    public class GcFontTypesEnum : NMSTemplate
    {
        public int Font;
        public string[] FontValues()
        {
            return new[] { "Impact", "Bebas", "GeosansLightWide", "GeosansLight", "GeosansLightMedium", "GeosansLightSmall", "Segoeuib", "Segoeui32" };
        }
    }
}
