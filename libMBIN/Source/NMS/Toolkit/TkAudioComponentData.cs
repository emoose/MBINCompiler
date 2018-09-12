using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x19610072A323204B)]
    public class TkAudioComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Ambient;

        public int MaxDistance;

        public List<TkAudioAnimTrigger> AnimTriggers;
    }
}
