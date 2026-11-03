namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53F220048D07243E, NameHash = 0x1F8894CB)]
    public class GcRewardStartShipBuildMode : NMSTemplate
    {
        // size: 0x4
        public enum ShipBuildTypeEnum : uint {
            CreateFromDefault,
            CreateFromDockedShip,
            ResumeBuild,
            ResumeBuildFromPurchaseScreen,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ShipBuildTypeEnum ShipBuildType;
    }
}
