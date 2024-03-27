using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC456A057ECE2EEC9, NameHash = 0x74BA808E86F0EC01)]
    public class GcScannableComponentData : NMSTemplate
    {
        /* 0x00 */ public float ScanRange;
        /* 0x04 */ public NMSString0x20 ScanName;
        /* 0x24 */ public float ScanTime;
        /* 0x28 */ public float CompassRangeMultiplier;
        /* 0x2C */ public float AlwaysShowRange;
        /* 0x30 */ public bool CanTagIcon;
        /* 0x31 */ public bool ClearTagOnArrival;
        /* 0x32 */ public bool DisableIfBuildingPart;
        /* 0x33 */ public bool DisableIfInBase;
        /* 0x34 */ public bool UseModelNode;
        /* 0x38 */ public GcScannerIconTypes Icon;
        // size: 0x6
        public enum ScannableTypeEnum : uint {
            Binoculars,
            BinocularsHotspots,
            Scanner,
            Marker,
            SpaceBattleTarget,
            None,
        }
        /* 0x3C */ public ScannableTypeEnum ScannableType;
        /* 0x40 */ public bool IsPlacedMarker;
        /* 0x41 */ public bool ShowInFreighterBranchRoom;
        /* 0x42 */ public bool TellPlayerIfFreighterObjectUsed;
        /* 0x48 */ public NMSString0x20A FreighterObjectAlreadyUsedLocID;
        /* 0x68 */ public bool AllowedToMerge;
        /* 0x69 */ public bool MarkerActiveWithNodeInactive;
        /* 0x70 */ public NMSString0x10 MissionSurveyId;
        /* 0x80 */ public float MinDisplayDistanceOverride;
    }
}
