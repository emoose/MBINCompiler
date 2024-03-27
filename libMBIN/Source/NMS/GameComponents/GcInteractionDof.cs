namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE00369E1965F75C9, NameHash = 0xE4D4852DEDEE280B)]
    public class GcInteractionDof : NMSTemplate
    {
        /* 0x00 */ public bool IsEnabled;
        /* 0x01 */ public bool UseGlobals;
        /* 0x04 */ public float NearPlaneMin;
        /* 0x08 */ public float NearPlaneAdjust;
        /* 0x0C */ public float FarPlane;
        /* 0x10 */ public float FarFadeDistance;
    }
}
