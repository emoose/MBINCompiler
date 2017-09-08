using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkProceduralModelList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public List<NMSString0x80> List;
    }
}
