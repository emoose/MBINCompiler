using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcNPCPlacementComponentData : NMSTemplate // 0x20 bytes
    {
        public bool SearchPlacementFromMaster;
        public GcNPCPlacementInfo PlacementInfosToApply;
    }
}
