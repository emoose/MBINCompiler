namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB692417D36C81BA1, NameHash = 0x8EABFDEC)]
    public class GcCreatureIkType : NMSTemplate
    {
        // size: 0x9
        public enum CreatureIkTypeEnum : uint {
            Foot,
            Hinge_X,
            Hinge_Y,
            Hinge_Z,
            Locked,
            Head,
            Toe,
            SpaceshipFoot,
            SpaceshipToe,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureIkTypeEnum CreatureIkType;
    }
}
