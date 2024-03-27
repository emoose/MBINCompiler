namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9C78044FF5BDB6D, NameHash = 0x9860FF852C2CBCD3)]
    public class GcByteBeatWave : NMSTemplate
    {
        // size: 0x4
        public enum ByteBeatWaveEnum : uint {
            SawTooth,
            Sine,
            Square,
            Triangle,
        }
        /* 0x0 */ public ByteBeatWaveEnum ByteBeatWave;
    }
}
