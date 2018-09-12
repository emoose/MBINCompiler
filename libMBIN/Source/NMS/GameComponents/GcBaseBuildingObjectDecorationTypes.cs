using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x48FADD6F70304AF4)]
    public class GcBaseBuildingObjectDecorationTypes : NMSTemplate
    {
		public enum BaseBuildingDecorationTypeEnum { Normal, SurfaceNormal, Ceiling, Terrain, Substance, Plant, BuildingSurfaceNormal }
		public BaseBuildingDecorationTypeEnum BaseBuildingDecorationType;
    }
}
