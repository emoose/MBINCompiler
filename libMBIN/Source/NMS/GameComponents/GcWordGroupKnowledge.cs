namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22FC782BAE42DCF1, NameHash = 0xB64408EDDD99E644)]
    public class GcWordGroupKnowledge : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Group;
        // size: 0x8
        public enum RacesEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(RacesEnum))]
        /* 0x20 */ public bool[] Races;
    }
}
