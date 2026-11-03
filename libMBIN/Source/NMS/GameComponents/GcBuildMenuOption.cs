namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x195CA352B9599C81, NameHash = 0x9E230B05)]
    public class GcBuildMenuOption : NMSTemplate
    {
        // size: 0x15
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
            Flip,
            ToggleCatalogue,
            Purchase,
            FamiliesRotate,
            YFlip,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BuildMenuOptionEnum BuildMenuOption;
    }
}
