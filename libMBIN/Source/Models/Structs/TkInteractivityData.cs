using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x209CCBD02527DE07)]
    public class TkInteractivityData : NMSTemplate
    {
        public List<TkInteractiveSceneData> Scenes;
    }
}
