namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED6DFF3F649A5595, NameHash = 0xF554DC208673EE3D)]
    public class GcBeenShotEvent : NMSTemplate
    {
        // size: 0x3
        public enum ShotByEnum {
            Player,
            Anything,
            PlayerOrRemotePlayer
        }
        /* 0x0 */ public ShotByEnum ShotBy;
        /* 0x4 */ public int DamageThreshold;
        /* 0x8 */ public float HealthThreshold;
    }
}
