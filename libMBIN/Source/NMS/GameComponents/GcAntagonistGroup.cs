namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x256D198A2AEE52B6, NameHash = 0x19DADEA2)]
    public class GcAntagonistGroup : NMSTemplate
    {
        // size: 0x6
        public enum AntagonistGroupEnum : uint {
            Player,
            Fiends,
            Creatures,
            Sentinels,
            Turrets,
            Walls,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AntagonistGroupEnum AntagonistGroup;
    }
}
