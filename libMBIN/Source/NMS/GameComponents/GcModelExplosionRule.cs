namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF632B2B1C66A9F6A, NameHash = 0xA63D153E45037707)]
    public class GcModelExplosionRule : NMSTemplate
    {
        // size: 0x4
        public enum MatchNodeTypeEnum {
            Any,
            Mesh,
            Model,
            Joint,
        }
        /* 0x00 */ public MatchNodeTypeEnum MatchNodeType;
        // size: 0x2
        public enum MatchNameEnum {
            ContainsString,
            ExactString,
        }
        /* 0x04 */ public MatchNameEnum MatchName;
        /* 0x08 */ public NMSString0x20 String;
        // size: 0x4
        public enum ExplodeActionEnum {
            RelativeToParent,
            DontMove,
            SaveCenter,
            RelativeToSaved,
        }
        /* 0x28 */ public ExplodeActionEnum ExplodeAction;
        /* 0x30 */ public Vector3f AxisMultiplier;
        /* 0x40 */ public Vector3f Offset;
        /* 0x50 */ public float ExplodeMod;
    }
}
