namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5101C54ADF6E837B, NameHash = 0xC14DD9CC)]
    public class GcPetBattleCameraPose : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public float CamOrientPitch;
        [NMS(Index = 5)]
        /* 0x04 */ public float CamOrientRoll;
        [NMS(Index = 3)]
        /* 0x08 */ public float CamOrientYaw;
        [NMS(Index = 0)]
        /* 0x0C */ public float Distance;
        [NMS(Index = 2)]
        /* 0x10 */ public float Pitch;
        [NMS(Index = 1)]
        /* 0x14 */ public float Yaw;
    }
}
