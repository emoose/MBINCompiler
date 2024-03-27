namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x655CD9EAB6B8C9B5, NameHash = 0xCF846F604521AD4F)]
    public class GcBuildMenuOption : NMSTemplate
    {
        // size: 0x10
        public enum BuildMenuOptionEnum : uint {
            Place,
            ChangeColour,
            FreeRotate,
            Scale,
            SnapRotate,
            Move,
            Duplicate,
            Delete,
            ToggleBuildCam,
            ToggleSnappingAndCollision,
            ToggleSelectionMode,
            ToggleWiringMode,
            ViewRelatives,
            CyclePart,
            PlaceWire,
            CycleRotateMode,
        }
        /* 0x0 */ public BuildMenuOptionEnum BuildMenuOption;
    }
}
