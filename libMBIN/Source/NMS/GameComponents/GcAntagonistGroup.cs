namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA828BEAB9CF4306, NameHash = 0x39B4070AE5C76F6F)]
    public class GcAntagonistGroup : NMSTemplate
    {
        // size: 0x6
        public enum AntagonistGroupEnum {
            Player,
            Fiends,
            Creatures,
            Sentinels,
            Turrets,
            Walls
        }
        /* 0x0 */ public AntagonistGroupEnum AntagonistGroup;
    }
}
