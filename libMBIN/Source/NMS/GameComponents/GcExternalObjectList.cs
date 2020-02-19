using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xC6F50AA19CA19F24, NameHash = 0xF94F95509B2D4135)]
    public class GcExternalObjectList : NMSTemplate
    {
        public GcEnvironmentSpawnData Objects;
    }
}
