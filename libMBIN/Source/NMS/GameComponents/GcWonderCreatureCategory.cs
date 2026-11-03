namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96A77684C873E120, NameHash = 0x118B6CAD)]
    public class GcWonderCreatureCategory : NMSTemplate
    {
        // size: 0xF
        public enum WonderCreatureCategoryEnum : uint {
            HerbivoreSizeMax,
            HerbivoreSizeMin,
            CarnivoreSizeMax,
            CarnivoreSizeMin,
            IntelligenceMax,
            ViciousnessMax,
            Hot,
            Cold,
            Tox,
            Rad,
            Weird,
            Water,
            Robot,
            Flyer,
            Cave,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderCreatureCategoryEnum WonderCreatureCategory;
    }
}
