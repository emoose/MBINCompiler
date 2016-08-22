using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompiler.Models.Structs
{
    // doesn't seem to be used by the game, TkEngineSettings template isn't inside the exe
    // and the only file using this template (METADATA/ENGINE/TKENGINESETTINGS.MBIN) isn't referenced
    // file is probably a leftover from early development

    public class TkEngineSettings : NMSTemplate
    {
        public float ScreenWidth;
        public float ScreenHeight;
    }
}
