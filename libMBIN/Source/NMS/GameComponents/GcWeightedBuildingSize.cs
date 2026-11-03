namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DB6BED82D6156F6, NameHash = 0xE1287B3D)]
    public class GcWeightedBuildingSize : NMSTemplate
    {
        [NMS(Index = 0, MxmlName = "Relative Probability")]
        /* 0x00 */ public float RelativeProbability;
        [NMS(Index = 1, MxmlName = "Size X")]
        /* 0x04 */ public int SizeX;
        [NMS(Index = 2, MxmlName = "Size Y")]
        /* 0x08 */ public int SizeY;
        [NMS(Index = 3, MxmlName = "Size Z")]
        /* 0x0C */ public int SizeZ;
        [NMS(Index = 4, MxmlName = "Create Symmetric Building")]
        /* 0x10 */ public bool CreateSymmetricBuilding;
    }
}
