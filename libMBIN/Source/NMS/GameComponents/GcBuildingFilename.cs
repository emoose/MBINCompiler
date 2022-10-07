namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31114F981BFD599E, NameHash = 0x5E68908664819224)]
    public class GcBuildingFilename : NMSTemplate
    {
        // size: 0x2
        public enum LSystemEnum {
            Normal,
            AbandonedSystem
        }
        [NMS(Size = 0x2, EnumType = typeof(LSystemEnum))]
        /* 0x000 */ public NMSString0x80[] LSystem;
        // size: 0x2
        public enum SceneEnum {
            Normal,
            AbandonedSystem
        }
        [NMS(Size = 0x2, EnumType = typeof(SceneEnum))]
        /* 0x100 */ public NMSString0x80[] Scene;
        // size: 0x2
        public enum WFCEnum {
            Normal,
            AbandonedSystem
        }
        [NMS(Size = 0x2, EnumType = typeof(WFCEnum))]
        /* 0x200 */ public NMSString0x80[] WFC;
    }
}
