using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MBINCompiler;
using System.IO;

namespace MBINCompilerTests
{
    [TestClass]
    public class UnitTests
    {
        String baseDir = "C:/NMS";

        [TestMethod]
        public void should_successfully_decompile()
        {
            var tests = new string[] // all of these should decompile fine
            {
                "METADATA/UI/HUD/SHIPHUD.MBIN", 
                "METADATA/ENTITLEMENTS/GCENTITLEMENTREWARDTABLE.MBIN",
                "SCENES/DEMOS/PS4TEST/MAINSETTINGSPS4TEST.MBIN",
                "METADATA/REALITY/TABLES/NMS_REALITY_GCTECHNOLOGYTABLE.MBIN",
                "METADATA/SIMULATION/SOLARSYSTEM/WEATHER/CLEARWEATHER.MBIN",
                "METADATA/SIMULATION/SOLARSYSTEM/WEATHER/SKYSETTINGS/DAYSKYCOLOURS.MBIN",
                "LANGUAGE/NMS_LOC1_ENGLISH.MBIN",
                "METADATA/REALITY/TABLES/NMS_DIALOG_GCALIENSPEECHTABLE.MBIN",
                "METADATA/REALITY/TABLES/NMS_DIALOG_GCALIENPUZZLETABLE.MBIN"
            };

            foreach (var test in tests)
            {
                String fullPath = Path.Combine(baseDir, test);
                var file = new MBINFile(fullPath);
                file.Load();
                Assert.IsNotNull(file.SerializeToXML(), test + " serialization was null");
            }
        }
    }
}
