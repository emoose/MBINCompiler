namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5694B6159F50EE8, NameHash = 0x9F0F26C55027F010)]
    public class GcCameraSpawnSetupData : NMSTemplate
    {
        /* 0x0 */ public float Distance;
        /* 0x4 */ public bool InFrontOfShip;
        /* 0x8 */ public float YawProportion;
        /* 0xC */ public float HorizontalProportion;
    }
}
