using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcNPCPlacementComponentData : NMSTemplate // 0x20 bytes
    {
        public bool SearchPlacementFromMaster;
        public List<NMSString0x10> PlacementInfosToApply;
        //public GcNPCPlacementInfo PlacementInfosToApply;
    }
}
