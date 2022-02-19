using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x91E43B7C37D58893, NameHash = 0xCF846F604521AD4F)]
    public class GcBuildMenuOption : NMSTemplate
    {
        // size: 0xF
        public enum BuildMenuOptionEnum { Place, ChangeColour, FreeRotate, Scale, SnapRotate, Move, Duplicate, Delete,
            ToggleBuildCam, ToggleSnappingAndCollision, ToggleSelectionMode, ToggleWiringMode,
            CyclePart, PlaceWire, CycleRotateMode
        }
        /* 0x0 */ public BuildMenuOptionEnum BuildMenuOption;
    }
}
