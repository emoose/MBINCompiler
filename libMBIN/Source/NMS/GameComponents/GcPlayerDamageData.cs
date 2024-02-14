using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30E925A879888D52, NameHash = 0x5F9BF82F9925D932)]
    public class GcPlayerDamageData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x20A DeathMessage;
        /* 0x030 */ public NMSString0x10 DeathStat;
        /* 0x040 */ public TkTextureResource HitIcon;
        /* 0x0C8 */ public NMSString0x20A HitChatMessage;
        /* 0x0E8 */ public NMSString0x20A HitMessage;
        /* 0x108 */ public GcAudioWwiseEvents HitMessageAudio;
        /* 0x110 */ public NMSString0x20A CriticalHitMessage;
        /* 0x130 */ public GcAudioWwiseEvents CriticalHitMessageAudio;
        /* 0x134 */ public float Damage;
        /* 0x138 */ public float PushForce;
        /* 0x13C */ public float CameraTurn;
        /* 0x140 */ public NMSString0x10 CameraShakeShield;
        /* 0x150 */ public NMSString0x10 CameraShakeNoShield;
        /* 0x160 */ public bool ShowTrackIcon;
        /* 0x161 */ public bool ForceDamageInInteraction;
        /* 0x162 */ public bool AllowDeathInInteraction;
        // size: 0x5
        public enum PlayerDamageTypeEnum : uint {
            Normal,
            Toxic,
            Radioactive,
            Freeze,
            Scorch,
        }
        /* 0x164 */ public PlayerDamageTypeEnum PlayerDamageType;
        /* 0x168 */ public List<GcBreakTechByStatData> DamageTechWithStat;
        /* 0x178 */ public float TechDamageChance;
    }
}
