namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC88E47E323B82BF4, NameHash = 0x13FCF5FDFA2BFA4E)]
    public class GcAccessibleOverride_Text : NMSTemplate
    {
        // size: 0x1
        public enum AccessibleOverride_TextEnum {
            FontHeight
        }
        /* 0x0 */ public AccessibleOverride_TextEnum AccessibleOverride_Text;
        /* 0x4 */ public float FloatValue;
    }
}
