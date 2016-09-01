using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Size = 9)]
        public NMSString0x80[] BiomeFiles;

        public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
