namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E4EC4F00F9BECC9, NameHash = 0xCF846F604521AD4F)]
    public class GcBuildMenuOption : NMSTemplate
    {
        // size: 0x10
        public enum BuildMenuOptionEnum {
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
            CycleRotateMode
        }
        /* 0x0 */ public BuildMenuOptionEnum BuildMenuOption;
    }
}
