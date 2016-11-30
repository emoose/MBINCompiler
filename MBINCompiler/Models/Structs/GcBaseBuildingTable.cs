namespace MBINCompiler.Models.Structs
{
    public class GcBasebuildingTable : NMSTemplate
    {
        /* 0x000 */ public TkModelResource LegModel;
        /* 0x084 */ public TkModelResource BaseRadiusModel;
        /* 0x108 */ public TkModelResource SnapPointValid;
        /* 0x18C */ public TkModelResource SnapPointInvalid;
        /* 0x210 */ public TkModelResource SnapPointFar;

        /* 0x298 */ public GcBaseBuildingEntry Objects;
        /* 0x2A8 */ public GcBaseBuildingGroup Groups;
        /* 0x2C0 */ public GcBaseBuildingPalette Palettes;
        /* 0x4C0 */ public GcBaseBuildingProperties Properties;
    }
}
