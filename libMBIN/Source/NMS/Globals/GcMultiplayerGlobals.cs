using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0x11FEB32DF350C1FA)]
    public class GcMultiplayerGlobals : NMSTemplate
    {
        /* 0x000 */ public float Unknown0x0;
        /* 0x004 */ public float Unknown0x4;
        /* 0x008 */ public float Unknown0x8;
        /* 0x00C */ public float Unknown0xC;
        /* 0x010 */ public float Unknown0x10;
        /* 0x014 */ public float Unknown0x14;
        /* 0x018 */ public float FullSimUpdateInterval;
        /* 0x01C */ public int MaxDownloadableBases;
        /* 0x020 */ public float BlobHeightOffset;
        /* 0x024 */ public int TransactionTimeout;
        /* 0x028 */ public int MessageQueueSize;
        /* 0x02C */ public int MessageQueueSizeDropUnreliable;
        /* 0x030 */ public float PlayerMarkerDisplayDistance;
        /* 0x034 */ public bool VoiceChatEnabled;
        /* 0x035 */ public bool FullSimHostMigration;
        /* 0x038 */ public float DisconnectionDisplayTime;
        /* 0x03C */ public float UpdatePeriod;
        /* 0x040 */ public float UpdatePeriodSteam;
        /* 0x044 */ public float VoiceUpdatePeriod;
        /* 0x048 */ public float VoiceUpdatePeriodSteam;
        /* 0x04C */ public float UpdateSlerpModifier;
        /* 0x050 */ public float ShipDirectionLerpModifier;
        /* 0x054 */ public float CharacterDirectionLerpModifier;
        /* 0x058 */ public float ShipSyncConvervengeMultiplier;
        /* 0x05C */ public float VehicleStickLerpModifier;
        /* 0x060 */ public float VehicleThrottleLerpModifier;
        /* 0x064 */ public float PlayerMarkerScreenOffsetY;
        /* 0x068 */ public float PlayerMarkerLargeIconDist;
        /* 0x06C */ public float PlayerMarkerLargeIconSize;
        /* 0x070 */ public float PlayerMarkerSmallIconSize;
        /* 0x074 */ public float PlayerMarkerMinShowDistance;
        /* 0x078 */ public bool PlayerMarkerCenteredName;
        /* 0x07C */ public float Unknown0x7C;               // not sure if this is used...
        /* 0x080 */ public int AbandonedEntityWaitPeriod_A;
        /* 0x084 */ public int AbandonedEntityWaitPeriod_B;
        /* 0x088 */ public float HostOnConnectedTimeout;
        /* 0x08C */ public int MaxSyncResponsesPerHash;
        /* 0x090 */ public float MinScore;
        /* 0x094 */ public float HostBiasScore;
        /* 0x098 */ public float UsefulSyncResponseScore;
        /* 0x09C */ public float UselessSyncResponseScore;
        /* 0x0A0 */ public float ConstantScoreDepletionRate;
        /* 0x0A4 */ public float FactorScoreDepletionRate;
        /* 0x0A8 */ public float HashCheckMessageInterval;
        /* 0x0AC */ public float SyncMessageInterval;
        /* 0x0B0 */ public float EditMessageInterval;
        /* 0x0B4 */ public float NewBlockMessageInterval;
        /* 0x0B8 */ public float EditMessageSentSyncBackOffTime;
        /* 0x0BC */ public float EditMessageReceivedSyncBackOffTime;
        /* 0x0C0 */ public float NewBlockMessageOverdueDistanceDivisor;
        /* 0x0C4 */ public float HashCheckMessageOverdueDistanceDivisor;
        /* 0x0C8 */ public int NewBlockMessageSentCooldown;
        /* 0x0CC */ public int HashReceivedCooldown;
        /* 0x0D0 */ public int HashMessageSentCooldown;
        /* 0x0D4 */ public int UsefulSyncResponseCooldown;
        /* 0x0D8 */ public int UselessSyncResponseCooldown;
        /* 0x0DC */ public int NewerHashReceivedCooldown;
        /* 0x0E0 */ public float BaseHeaderBroadcastInterval;
        /* 0x0E4 */ public float PlaceholderBroadcastInterval;
        /* 0x0E8 */ public float StatSyncRadiusPlanet;
        /* 0x0EC */ public float StatSyncRadiusSpace;
        /* 0x0F0 */ public float Unknown0xF0;
        /* 0x0F4 */ public float Unknown0xF4;
        /* 0x0F8 */ public float Unknown0xF8;
        /* 0x0FC */ public int UnknownInt0xFC;
        /* 0x100 */ public float Unknown0x100;
        /* 0x104 */ public float Unknown0x104;
        /* 0x108 */ public float Unknown0x108;
        /* 0x10C */ public float Unknown0x10C;
        /* 0x110 */ public float Unknown0x110;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x114 */ public byte[] EndPadding;
    }
}
