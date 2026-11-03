using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4DB75690138CA58B, NameHash = 0x3701D8B8)]
    public class GcGameTablePetPrerequisite : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSTemplate> Rules;
    }
}
