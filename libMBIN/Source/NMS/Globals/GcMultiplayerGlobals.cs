using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0xDA8B00B2D67658AF)]
    public class GcMultiplayerGlobals : NMSTemplate
    {
        /* 0x0 */ public float FullSimUpdateInterval;
        /* 0x4 */ public int MaxDownloadableBases;
        /* 0x8 */ public float BlobHeightOffset;
        /* 0xC */ public int TransactionTimeout;
        /* 0x10 */ public int MessageQueueSize;
        /* 0x14 */ public int MessageQueueSizeDropUnreliable;

        /* 0x18 */ public float PlayerMarkerDisplayDistance;
        /* 0x1C */ public bool VoiceChatEnabled;
        /* 0x1D */ public bool FullSimHostMigration;
        /* 0x20 */ public float DisconnectionDisplayTime;
        /* 0x24 */ public float UpdatePeriod;
        /* 0x28 */ public float UpdatePeriodSteam;
        /* 0x2C */ public float VoiceUpdatePeriod;
        /* 0x30 */ public float VoiceUpdatePeriodSteam;
        /* 0x34 */ public float UpdateSlerpModifier;
        /* 0x38 */ public float ShipDirectionLerpModifier;
        /* 0x3C */ public float CharacterDirectionLerpModifier;
        /* 0x40 */ public float ShipSyncConvervengeMultiplier;
        /* 0x44 */ public float VehicleStickLerpModifier;
        /* 0x48 */ public float VehicleThrottleLerpModifier;
        /* 0x4C */ public float PlayerMarkerScreenOffsetY;
        /* 0x50 */ public float PlayerMarkerLargeIconDist;
        /* 0x54 */ public float PlayerMarkerLargeIconSize;
        /* 0x58 */ public float PlayerMarkerSmallIconSize;
        /* 0x5C */ public float PlayerMarkerMinShowDistance;
        /* 0x60 */ public bool PlayerMarkerCenteredName;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x61 */ public byte[] Padding61;
        /* 0x68 */ public int AbandonedEntityWaitPeriod_A;
        /* 0x6C */ public int AbandonedEntityWaitPeriod_B;
        /* 0x70 */ public float HostOnConnectedTimeout;
        /* 0x74 */ public int MaxSyncResponsesPerHash;
        /* 0x78 */ public float MinScore;
        /* 0x7C */ public float HostBiasScore;
        /* 0x80 */ public float UsefulSyncResponseScore;
        /* 0x84 */ public float UselessSyncResponseScore;
        /* 0x88 */ public float ConstantScoreDepletionRate;
        /* 0x8C */ public float FactorScoreDepletionRate;
        /* 0x90 */ public float HashCheckMessageInterval;
        /* 0x94 */ public float SyncMessageInterval;
        /* 0x98 */ public float EditMessageInterval;
        /* 0x9C */ public float NewBlockMessageInterval;
        /* 0xA0 */ public float EditMessageSentSyncBackOffTime;
        /* 0xA4 */ public float EditMessageReceivedSyncBackOffTime;
        /* 0xA8 */ public float NewBlockMessageOverdueDistanceDivisor;
        /* 0xAC */ public float HashCheckMessageOverdueDistanceDivisor;
        /* 0xB0 */ public int NewBlockMessageSentCooldown;
        /* 0xB4 */ public int HashReceivedCooldown;
        /* 0xB8 */ public int HashMessageSentCooldown;
        /* 0xBC */ public int UsefulSyncResponseCooldown;
        /* 0xC0 */ public int UselessSyncResponseCooldown;
        /* 0xC4 */ public int NewerHashReceivedCooldown;
        /* 0xC8 */ public float BaseHeaderBroadcastInterval;
        /* 0xCC */ public float PlaceholderBroadcastInterval;
        /* 0xD0 */ public float StatSyncRadiusPlanet;
        /* 0xD4 */ public float StatSyncRadiusSpace;
    }
}
