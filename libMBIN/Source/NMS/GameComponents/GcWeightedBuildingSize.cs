namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1FF58EFC7A2FCB64, NameHash = 0x90DB43477E714E6D)]
    public class GcWeightedBuildingSize : NMSTemplate
    {
        /* 0x00 */ public float RelativeProbability;
        /* 0x04 */ public int SizeX;
        /* 0x08 */ public int SizeY;
        /* 0x0C */ public int SizeZ;
        /* 0x10 */ public bool CreateSymmetricBuilding;
    }
}
