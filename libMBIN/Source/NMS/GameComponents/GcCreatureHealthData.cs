using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x68, GUID = 0x9E936EDD82DCDD95, NameHash = 0x8554BC1ADD990AB6)]
    public class GcCreatureHealthData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string HurtAnim;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string DeathAnim;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string DeathEffect;
        [NMS(Size = 0x10)]
        /* 0x30 */ public string HurtAudio;
        [NMS(Size = 0x10)]
        /* 0x40 */ public string DeathAudio;
        /* 0x50 */ public bool DespawnOnDeath;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x51 */ public byte[] Padding51;
        /* 0x58 */ public List<NMSString0x20> DespawnOnDeathDescriptors;
    }
}