namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB63C7A813B28E355, NameHash = 0xEB9944B7)]
    public class TkVolumeNavMeshFamilyBuildParams : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float CellsPerAgentRadius;
        [NMS(Index = 3)]
        /* 0x4 */ public float CellsPerUnitHeight;
        [NMS(Index = 1)]
        /* 0x8 */ public float TileSize;
        [NMS(Index = 0)]
        /* 0xC */ public bool Enabled;
    }
}
