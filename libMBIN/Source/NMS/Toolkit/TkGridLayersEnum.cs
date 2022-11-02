namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7D42AFE25CB3B772, NameHash = 0xFEF6F10412C7B60)]
    public class TkGridLayersEnum : NMSTemplate
    {
        // size: 0x9
        public enum GridLayerTypesEnum {
            Small,
            Large,
            Resources_Heridium,
            Resources_Iridium,
            Resources_Copper,
            Resources_Nickel,
            Resources_Aluminium,
            Resources_Gold,
            Resources_Emeril
        }
        /* 0x0 */ public GridLayerTypesEnum GridLayerTypes;
    }
}
