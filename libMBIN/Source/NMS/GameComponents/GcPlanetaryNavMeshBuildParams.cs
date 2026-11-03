namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60453E34E1437290, NameHash = 0x2C6E32AD)]
    public class GcPlanetaryNavMeshBuildParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int CellsPerVoxelHeight;
        [NMS(Index = 0)]
        /* 0x4 */ public int CellsPerVoxelWidth;
    }
}
