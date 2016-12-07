namespace MBINCompiler.Models.Structs
{
    public class GcBuildingFilenameList : NMSTemplate // 0x2C00 bytes
    {
        [NMS(Size = 0x17)]
        public GcBuildingFilename[] BuildingFiles;
    }
}
