namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x85A8E00B38F2871, NameHash = 0xF83331A4)]
    public class TkLightLayer : NMSTemplate
    {
        // size: 0x5
        public enum LightLayerEnum : byte {
            None = 0x0,
            Common = 0x1,
            Sunlight = 0x2,
            Character = 0x4,
            Interior = 0x8,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LightLayerEnum LightLayer;
    }
}
