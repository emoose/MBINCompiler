using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9FC1366FC90CF988)]
    public class GcStatDefinition : NMSTemplate
    {
        public GcStatType Type;
        public GcStatTrackType TrackType;
        public GcStatDisplayType DisplayType;
        public GcStatValueData DefaultValue;

        [NMS(Size = 0x10)]
        public string Id;
    }
}
