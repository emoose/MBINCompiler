namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BE9BD794D5FB0A9, NameHash = 0xA4091406380F5113)]
    public class GcGenericIconTypes : NMSTemplate
    {
        // size: 0x6
        public enum GenericIconTypeEnum {
            None,
            Interaction,
            SpaceStation,
            SpaceAnomaly,
            SpaceAtlas,
            Nexus
        }
        /* 0x0 */ public GenericIconTypeEnum GenericIconType;
    }
}
