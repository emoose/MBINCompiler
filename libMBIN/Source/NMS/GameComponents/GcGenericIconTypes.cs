namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC364E4B5E5B16679, NameHash = 0xA4091406380F5113)]
    public class GcGenericIconTypes : NMSTemplate
    {
        // size: 0x6
        public enum GenericIconTypeEnum : uint {
            None,
            Interaction,
            SpaceStation,
            SpaceAnomaly,
            SpaceAtlas,
            Nexus,
        }
        /* 0x0 */ public GenericIconTypeEnum GenericIconType;
    }
}
