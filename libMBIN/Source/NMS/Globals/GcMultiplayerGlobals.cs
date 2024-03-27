using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x8F2F3FB8E36B1F67, NameHash = 0xAE0EEF5ED0659FF3)]
    public class GcMultiplayerGlobals : NMSTemplate
    {
        /* 0x000 */ public Vector2f FullSimHandUpdateDistance;
        /* 0x008 */ public Vector2f FullSimHandUpdateInterval;
        /* 0x010 */ public float DistanceBetweenTeleportMovementEffects;
        /* 0x014 */ public float FullSimHandUpdateDisabledDistance;
        /* 0x018 */ public float FullSimUpdateInterval;
        /* 0x01C */ public float JoinInteractionTimeout;
        /* 0x020 */ public float InviteInteractionTimeout;
        /* 0x024 */ public int MaxDownloadableBases;
        /* 0x028 */ public float BlobHeightOffset;
        /* 0x02C */ public int TransactionTimeout;
        /* 0x030 */ public int MessageQueueSize;
        /* 0x034 */ public int MessageQueueSizeDropUnreliable;
        /* 0x038 */ public float PlayerMarkerDisplayDistance;
        /* 0x03C */ public bool VoiceChatEnabled;
        /* 0x040 */ public float DisconnectionDisplayTime;
        /* 0x044 */ public float UpdateSlerpModifier;
        /* 0x048 */ public float ShipDirectionLerpModifier;
        /* 0x04C */ public float CharacterDirectionLerpModifier;
        /* 0x050 */ public float ShipSyncConvervengeMultiplier;
        /* 0x054 */ public float ShipLandShakeMaxDist;
        /* 0x058 */ public float VehicleStickLerpModifier;
        /* 0x05C */ public float VehicleThrottleLerpModifier;
        /* 0x060 */ public float PlayerMarkerScreenOffsetY;
        /* 0x064 */ public float PlayerMarkerSmallIconSize;
        /* 0x068 */ public float PlayerMarkerLargeIconDist;
        /* 0x06C */ public float PlayerMarkerLargeIconFarSize;
        /* 0x070 */ public float PlayerMarkerLargeIconCloseSize;
        /* 0x074 */ public float PlayerMarkerMinShowDistance;
        /* 0x078 */ public bool PlayerMarkerCenteredName;
        /* 0x07C */ public float PlayerInteractCooldown;
        /* 0x080 */ public ulong AbandonedEntityWaitPeriod;
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
        /* 0x0F0 */ public float NPCInteractionTimeout;
        /* 0x0F4 */ public float NPCReplicateStartDistance;
        /* 0x0F8 */ public float NPCReplicateEndDistance;
        /* 0x0FC */ public int MissionRecurrenceTime;
        /* 0x100 */ public float MissionWaitOnceAllPlayersReadyTime;
        /* 0x104 */ public float ChanceMissionEpic;
        /* 0x108 */ public float RemoveDuplicateChatMessageTime;
        /* 0x110 */ public NMSString0x10 StandardMissionSecondReward;
        /* 0x120 */ public NMSString0x10 QuicksilverMissionSecondReward;
        /* 0x130 */ public NMSString0x10 EpicMissionSecondReward;
        /* 0x140 */ public NMSString0x10 WeekendMissionSecondReward;
        /* 0x150 */ public NMSString0x10 EpicMissionRewardOverride;
        /* 0x160 */ public NMSString0x10 NexusMissionStandardReward;
        /* 0x170 */ public TkTextureResource EpicMissionIcon;
        /* 0x1F4 */ public TkTextureResource EpicMissionIconSelected;
        /* 0x278 */ public TkTextureResource EpicMissionIconNotSelected;
        /* 0x2FC */ public float PlanetLocalEnitityInterestStart;
        /* 0x300 */ public float PlanetLocalEnitityInterestEnd;
        /* 0x304 */ public float EntityUpdateMaxRateDist;
        /* 0x308 */ public float EntityUpdateMinRateDist;
    }
}
