namespace libMBIN.Models.Structs
{
    public class GcWikiTopicType : NMSTemplate
    {
        public int WikiTopicType;
        public string[] WikiTopicTypeValues()
        {
            return new[] { "List", "Grid"};
        }
    }
}
