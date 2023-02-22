namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x160DC2FE51E62600, NameHash = 0x3B1EFAD66E07132E)]
    public class GcCameraAmbientSpaceData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Animation;
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        // size: 0x8
        public enum OriginEnum {
            SpaceStationInternals,
            SpaceStationBack,
            FreighterBattle,
            Freighter,
            FreighterHangar,
            AtlasStation,
            BlackHole,
            Anomaly,
        }
        /* 0x20 */ public OriginEnum Origin;
    }
}
