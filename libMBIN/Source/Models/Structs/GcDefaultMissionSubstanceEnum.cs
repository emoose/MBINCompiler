using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x751F47F5E80735E)]
    public class GcDefaultMissionSubstanceEnum : NMSTemplate
    {
		public enum DefaultSubstanceTypeEnum { None, PrimarySubstance, SecondarySubstance }
		public DefaultSubstanceTypeEnum DefaultSubstanceType;
    }
}
