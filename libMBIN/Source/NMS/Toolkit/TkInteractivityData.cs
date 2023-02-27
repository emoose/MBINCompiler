using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x43B9DE6D6C692EC1, NameHash = 0x8BA785D3F3AE4D34)]
    public class TkInteractivityData : NMSTemplate
    {
        /* 0x0 */ public List<TkInteractiveSceneData> Scenes;
    }
}
