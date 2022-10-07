using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9876B949FCE1EA5B, NameHash = 0x84B1F1D780A31A2A)]
    public class GcSolarSystemLocatorChoice : NMSTemplate
    {
        // size: 0x4
        public enum ChoiceEnum {
            LookupName,
            AnyOfType,
            SpecificIndex,
            InFrontOfPlayer
        }
        /* 0x00 */ public ChoiceEnum Choice;
        /* 0x04 */ public NMSString0x20 Name;
        /* 0x24 */ public GcSolarSystemLocatorTypes Type;
        /* 0x28 */ public int Index;
    }
}
