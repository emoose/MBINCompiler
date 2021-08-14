using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace libMBIN.UnitTests
{
    [TestClass]
    public class NMSTemplateUnitTests
    {
        [TestMethod]
        public void TestOffsetOf() {
            Assert.AreEqual(0xB8, NMSTemplate.OffsetOf("GcAIShipSpawnData", "ChildSpawns"));
            Assert.AreEqual(0x8C, NMSTemplate.OffsetOf("GcAIShipSpawnData", "Spread"));
            Assert.AreEqual(0x1C, NMSTemplate.OffsetOf("GcCreatureDebugSpawnData", "SmoothTime"));
            Assert.AreEqual(0x0, NMSTemplate.OffsetOf("GcCustomisationColourPalettes", "ColourPalettes"));
            Assert.AreEqual(0x4510, NMSTemplate.OffsetOf("GcCustomisationColourPalettes", "ExtraData"));
            Assert.AreEqual(0x1C9C, NMSTemplate.OffsetOf("GcGameplayGlobals", "WeaponSpawnAltObject"));
        }
    }
}
