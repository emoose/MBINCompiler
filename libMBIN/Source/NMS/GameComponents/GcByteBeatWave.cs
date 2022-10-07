namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61E4EF20CE38F6A1, NameHash = 0x9860FF852C2CBCD3)]
    public class GcByteBeatWave : NMSTemplate
    {
        // size: 0x4
        public enum ByteBeatWaveEnum {
            SawTooth,
            Sine,
            Square,
            Triangle
        }
        /* 0x0 */ public ByteBeatWaveEnum ByteBeatWave;
    }
}
