using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x300, GUID = 0x6A32789113B9B41D)]
    public class GcMultiplayerGlobals : NMSTemplate
    {
        /* 0x000 */ public float Unknown0x0;
        /* 0x004 */ public float Unknown0x4;
        /* 0x008 */ public float Unknown0x8;
        /* 0x00C */ public float Unknown0xC;
        /* 0x010 */ public float Unknown0x10;
        /* 0x014 */ public float Unknown0x14;
        /* 0x018 */ public float FullSimUpdateInterval;
        /* 0x01C */ public float Unknown0x1C;
        /* 0x020 */ public float Unknown0x20;
        /* 0x024 */ public int MaxDownloadableBases;
        /* 0x028 */ public float BlobHeightOffset;
        /* 0x02C */ public int TransactionTimeout;
        /* 0x030 */ public int MessageQueueSize;
        /* 0x034 */ public int MessageQueueSizeDropUnreliable;
        /* 0x038 */ public float PlayerMarkerDisplayDistance;
        /* 0x03C */ public bool VoiceChatEnabled;
        /* 0x03D */ public bool FullSimHostMigration;
        /* 0x040 */ public float DisconnectionDisplayTime;
        /* 0x044 */ public float UpdatePeriod;
        /* 0x048 */ public float UpdatePeriodSteam;
        /* 0x04C */ public float VoiceUpdatePeriod;
        /* 0x050 */ public float VoiceUpdatePeriodSteam;
        /* 0x054 */ public float UpdateSlerpModifier;
        /* 0x058 */ public float ShipDirectionLerpModifier;
        /* 0x05C */ public float CharacterDirectionLerpModifier;
        /* 0x060 */ public float ShipSyncConvervengeMultiplier;
        /* 0x064 */ public float VehicleStickLerpModifier;
        /* 0x068 */ public float VehicleThrottleLerpModifier;
        /* 0x06C */ public float PlayerMarkerScreenOffsetY;
        /* 0x070 */ public float Unknown0x70;
        /* 0x074 */ public float PlayerMarkerLargeIconDist;
        /* 0x078 */ public float PlayerMarkerLargeIconSize;
        /* 0x07C */ public float PlayerMarkerSmallIconSize;
        /* 0x080 */ public float PlayerMarkerMinShowDistance;
        /* 0x084 */ public bool PlayerMarkerCenteredName;
        /* 0x088 */ public int AbandonedEntityWaitPeriod_A;
        /* 0x08C */ public int AbandonedEntityWaitPeriod_B;
        /* 0x090 */ public float HostOnConnectedTimeout;
        /* 0x094 */ public int MaxSyncResponsesPerHash;
        /* 0x098 */ public float MinScore;
        /* 0x09C */ public float HostBiasScore;
        /* 0x0A0 */ public float UsefulSyncResponseScore;
        /* 0x0A4 */ public float UselessSyncResponseScore;
        /* 0x0A8 */ public float ConstantScoreDepletionRate;
        /* 0x0AC */ public float FactorScoreDepletionRate;
        /* 0x0B0 */ public float HashCheckMessageInterval;
        /* 0x0B4 */ public float SyncMessageInterval;
        /* 0x0B8 */ public float EditMessageInterval;
        /* 0x0BC */ public float NewBlockMessageInterval;
        /* 0x0C0 */ public float EditMessageSentSyncBackOffTime;
        /* 0x0C4 */ public float EditMessageReceivedSyncBackOffTime;
        /* 0x0C8 */ public float NewBlockMessageOverdueDistanceDivisor;
        /* 0x0CC */ public float HashCheckMessageOverdueDistanceDivisor;
        /* 0x0D0 */ public int NewBlockMessageSentCooldown;
        /* 0x0D4 */ public int HashReceivedCooldown;
        /* 0x0D8 */ public int HashMessageSentCooldown;
        /* 0x0DC */ public int UsefulSyncResponseCooldown;
        /* 0x0E0 */ public int UselessSyncResponseCooldown;
        /* 0x0E4 */ public int NewerHashReceivedCooldown;
        /* 0x0E8 */ public float BaseHeaderBroadcastInterval;
        /* 0x0EC */ public float PlaceholderBroadcastInterval;
        /* 0x0F0 */ public float StatSyncRadiusPlanet;
        /* 0x0F4 */ public float StatSyncRadiusSpace;
        /* 0x0F8 */ public float Unknown0xF8;
        /* 0x0FC */ public float Unknown0xFC;
        /* 0x0100 */ public float Unknown0x100;
        /* 0x0104 */ public int UnknownInt0x104;
        /* 0x108 */ public float Unknown0x108;
        /* 0x10C */ public float Unknown0x10C;      // Encrypted mission chance?
        [NMS(Size = 0x5)]
        /* 0x110 */ public NMSString0x10[] EncryptedMissionRewards;

        /* 0x160 */ public TkTextureResource HideNSeekShopIcon;
        /* 0x1E4 */ public TkTextureResource HideNSeekOnIcon;
        /* 0x268 */ public TkTextureResource HideNSeekOffIcon;

        /* 0x2EC */ public float Unknown0x2DC;
        /* 0x2F0 */ public float Unknown0x2E0;
        /* 0x2F4 */ public float Unknown0x2E4;
        /* 0x2F8 */ public float Unknown0x2E8;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2FC */ public byte[] EndPadding;
    }
}
