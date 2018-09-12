using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1284E8A8B0A4B370)]
    public class GcAmbientModeCameras : NMSTemplate      // size: 0x30
    {
        public List<GcCameraAmbientBuildingData> BuildingCameraAnimations;
        public List<GcCameraAmbientSpaceData> SpaceCameraAnimations;
        public List<GcCameraAmbientSpecialData> SpecialCameraAnimations;
    }
}
