using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPersistentBaseTypes : NMSTemplate
    {
        public int PersistentBaseTypes;
        public string[] PersistentBaseTypesValues()
        {
            return new[] { "HomePlanetBase", "FreighterBase" };
        }
    }
}
