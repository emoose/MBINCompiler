using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MBINCompiler;

namespace MBINCompilerTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void should_successfully_decompile()
        {
            var tests = new string[] // all of these should decompile fine
            {
                @"C:\NMS\METADATA\UI\HUD\SHIPHUD.MBIN", 
                @"C:\NMS\METADATA\ENTITLEMENTS\GCENTITLEMENTREWARDTABLE.MBIN",
                @"C:\NMS\SCENES\DEMOS\PS4TEST\MAINSETTINGSPS4TEST.MBIN",
                @"C:\NMS\METADATA\REALITY\TABLES\NMS_REALITY_GCTECHNOLOGYTABLE.MBIN",
                @"C:\NMS\METADATA\SIMULATION\SOLARSYSTEM\WEATHER\CLEARWEATHER.MBIN",
                @"C:\NMS\METADATA\SIMULATION\SOLARSYSTEM\WEATHER\SKYSETTINGS\DAYSKYCOLOURS.MBIN",
                @"C:\NMS\LANGUAGE\NMS_LOC1_ENGLISH.MBIN",
                @"C:\NMS\METADATA\REALITY\TABLES\NMS_DIALOG_GCALIENSPEECHTABLE.MBIN",
                @"C:\NMS\METADATA\REALITY\TABLES\NMS_DIALOG_GCALIENPUZZLETABLE.MBIN"
            };

            foreach (var test in tests)
            {
                var file2 = new MBINFile(test);
                file2.Load();
                var wew = file2.SerializeToXML();
            }
        }
    }
}
