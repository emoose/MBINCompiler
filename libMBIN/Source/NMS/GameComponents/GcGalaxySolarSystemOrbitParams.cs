namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35F1C6D230DE1C75, NameHash = 0x9A190BDD7FF30DF9)]
    public class GcGalaxySolarSystemOrbitParams : NMSTemplate
    {
        /* 0x00 */ public float FirstOrbitRadiusMin;
        /* 0x04 */ public float FirstOrbitRadiusMax;
        /* 0x08 */ public float OrbitRadiusOffsetMin;
        /* 0x0C */ public float OrbitRadiusOffsetMax;
        /* 0x10 */ public float OrbitRotationSpeedMin;
        /* 0x14 */ public float OrbitRotationSpeedMax;
        /* 0x18 */ public float OrbitLineWidth;
    }
}
