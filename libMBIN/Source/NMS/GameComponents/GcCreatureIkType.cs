namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95AEBA53A9F333F2, NameHash = 0x1A5C8AEE15BC00C7)]
    public class GcCreatureIkType : NMSTemplate
    {
        // size: 0x9
        public enum CreatureIkTypeEnum {
            Foot,
            Hinge_X,
            Hinge_Y,
            Hinge_Z,
            Locked,
            Head,
            Toe,
            SpaceshipFoot,
            SpaceshipToe
        }
        /* 0x0 */ public CreatureIkTypeEnum CreatureIkType;
    }
}
