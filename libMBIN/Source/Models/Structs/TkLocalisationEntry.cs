namespace libMBIN.Models.Structs
{
    public class TkLocalisationEntry : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Id;

        public VariableSizeString English;
        public VariableSizeString French;
        public VariableSizeString Italian;
        public VariableSizeString German;
        public VariableSizeString Spanish;
        public VariableSizeString Russian;
        public VariableSizeString Polish;
        public VariableSizeString Dutch;
        public VariableSizeString Portuguese;
        public VariableSizeString LatinAmericanSpanish;
        public VariableSizeString BrazilianPortuguese;
        public VariableSizeString SimplifiedChinese;
        public VariableSizeString TraditionalChinese;
        public VariableSizeString Korean;
        public VariableSizeString Japanese;
        public VariableSizeString USEnglish;
    }
}
