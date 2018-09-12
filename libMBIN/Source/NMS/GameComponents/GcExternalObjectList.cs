using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0x23399F250B09CC4D)]
    public class GcExternalObjectList : NMSTemplate
    {
        public GcEnvironmentSpawnData Objects;
    }
}
