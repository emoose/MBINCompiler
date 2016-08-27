using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkRotationComponentData : NMSTemplate
    {
        public float Speed;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        public Vector4f Axis;
    }

    public class TkAnimationData : NMSTemplate // 0xE0 bytes
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Anim;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Filename;

        /* 0x090 */ public int AnimType;
        public string[] AnimTypeValues()
        {
            return new[] { "Loop", "OneShot", "Control" };
        }

        /* 0x094 */ public int FrameStart;
        /* 0x098 */ public int FrameEnd;
        [NMS(Size = 4, Ignore = true)]
        /* 0x09C */ public byte[] Padding9C;

        [NMS(Size = 0x10)]
        /* 0x0A0 */ public string StartNode;
        /* 0x0B0 */ public List<NMSString0x10> ExtraStartNodes;

        /* 0x0C0 */ public int Priority;

        /* 0x0C4 */ public float LoopOffsetMin;
        /* 0x0C8 */ public float LoopOffsetMax;

        /* 0x0CC */ public float ControlDelay;
        /* 0x0D0 */ public float ControlSpeed;
        /* 0x0D4 */ public float ControlActionFrame;
        /* 0x0D8 */ public int ControlCreatureSize;
        public string[] ControlCreatureSizeValues()
        {
            return new[] { "AllSizes", "SmallOnly", "LargeOnly" };
        }

        /* 0x0DC */ public bool FlagsAdditive;
        /* 0x0DD */ public bool FlagsMirrored;
        /* 0x0DE */ public bool FlagsActive;

        [NMS(Size = 1, Ignore = true)]
        /* 0x0DF */ public byte[] PaddingDF;
    }

    public class TkAnimationComponentData : NMSTemplate
    {
        public TkAnimationData Idle;
        public List<TkAnimationData> Anims;
    }

    public class GcSubstanceAmount : NMSTemplate // 0x20 bytes
    {
        public int AmountMin;
        public int AmountMax;
        [NMS(Size = 0x10)]
        public string Specific;

        public GcRealitySubstanceCategory SubstanceCategory;
        public GcRarity Rarity;
    }

    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Explosion;
        /* 0x010 */ public float ExplosionScale;
        [NMS(Size = 4, Ignore = true)]
        /* 0x014 */ public byte[] Padding14;

        [NMS(Size = 0x10)]
        /* 0x018 */ public string TriggerAction;
        /* 0x028 */ public int IncreaseWanted;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02C */ public byte[] Padding2C;

        [NMS(Size = 0x10)]
        /* 0x030 */ public string LootReward;
        /* 0x040 */ public int LootRewardAmountMin;
        /* 0x044 */ public int LootRewardAmountMax;

        /* 0x048 */ public List<GcSubstanceAmount> GivesSubstances;
        [NMS(Size = 0x10)]
        /* 0x058 */ public string GivesReward;

        /* 0x068 */ public bool RemoveModel;
        /* 0x06C */ public TkModelResource DestroyedModel;
        /* 0x0F0 */ public bool DestroyedModelUsesScale;
        /* 0x0F4 */ public float DestroyForce;
        /* 0x0F8 */ public float DestroyForceRadius;
        /* 0x100 */ public List<NMSString0x10> DestroyEffectPoints;
        /* 0x110 */ public float DestroyEffectTime;

        /* 0x114 */ public bool ShowInteract;
        /* 0x118 */ public float ShowInteractRange;
        /* 0x11C */ public bool DamageGrenadeSingleHit;
    }

    public class GcScannerIconTypes : NMSTemplate
    {
        public int ScanIconType;
        public string[] ScanIconTypeValues()
        {
            return new[]
            {
                "None", "Health", "Shield", "Hazard", "Tech", "Signal", "Fuel", "Mineral", "Multi", "Artifact", "TechRecipe", "RareProp"
            };
        }
    }

    public class GcScannableComponentData : NMSTemplate
    {
        public float ScanRange;
        [NMS(Size = 0x20)]
        public string ScanName;
        public float ScanTime;

        public GcScannerIconTypes IconType;
        public bool PermanentIcon;
        public float PermanentIconRadius;
    }

    public class GcAISpaceshipTypes : NMSTemplate
    {
        public int ShipType;
        public string[] ShipTypeValues()
        {
            return new[] { "None", "Pirate", "Police", "Trader", "Freighter" };
        }
    }

    public class GcSpawnComponentOption : NMSTemplate // 0x2C8 bytes
    {
        [NMS(Size = 0x10)]
        public string Name;
        public GcSeed Seed;
        public GcResourceElement SpecificModel;
    }

    public class GcCreatureSpawnComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string TriggerID;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Model;
        [NMS(Size = 0x10)]
        /* 0x090 */ public string Creature;

        /* 0x0A0 */ public GcCreatureTypes CreatureType;
        /* 0x0A4 */ public GcAISpaceshipTypes ShipType;
        /* 0x0A8 */ public GcSeed Seed;
        /* 0x0B8 */ public int FunctionKey;
        /* 0x0BC */ public float TriggerDistance;
        /* 0x0C0 */ public float Scale;
        /* 0x0C4 */ public float StartTimeMin;
        /* 0x0C8 */ public float StartTimeMax;
        /* 0x0CC */ public bool SpawnAlert;
        /* 0x0D0 */ public int SpawnerMode;
        public string[] SpawnerModeValues()
        {
            return new[] { "Hidden", "Visible", "HideOnSpawn", "HiddenTimer" };
        }

        [NMS(Size = 4, Ignore = true)]
        /* 0x0D4 */ public byte[] PaddingD4;

        /* 0x0D8 */ public GcResourceElement SpecificModel;
        /* 0x380 */ public List<GcSpawnComponentOption> SpawnOptionList;
    }

    public class TkPhysicsData : NMSTemplate
    {
        public float Mass;
        public float Friction;
        public float RollingFriction;
        public float AngularDamping;
        public float LinearDamping;
        public float Gravity;
    }

    public class TkPhysicsComponentData : NMSTemplate
    {
        public TkPhysicsData Data;
        public NMSTemplate Unknown20;
    }

    public class GcActionTrigger : NMSTemplate
    {
        public NMSTemplate Trigger;
        public List<NMSTemplate> Action;
    }

    public class GcActionTriggerState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StateID;
        public List<GcActionTrigger> Triggers;
    }

    public class GcTriggerActionComponentData : NMSTemplate
    {
        public bool HideModel;
        public bool StartInactive;
        public List<GcActionTriggerState> States;
        public bool Persistent;
        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding19;
        [NMS(Size = 0x10)]
        public string PersistentState;
    }

    public class GcLandingHelperComponentData : NMSTemplate
    {
        public float ActiveDistanceMin;
        public float ActiveDistanceMax;
        public bool LandPoint;
    }

    public class TkReferenceComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Reference;
        [NMS(Size = 0x80)]
        public string LSystem;
    }

    public class GcDistanceScaleComponentData : NMSTemplate
    {
        public bool UseGlobals;
        public float Scale;
        public float MinDistance;
        public float MaxDistance;
        public float MinHeight;
        public float MaxHeight;
    }

    public class GcShieldComponentData : NMSTemplate
    {
        public int Type;
    }

    public class GcShootableComponentData : NMSTemplate
    {
        public int Health;
        public bool AutoAimTarget;
        public bool PlayerOnly;
        public bool ImpactShake;
        [NMS(Size = 1, Ignore = true)]
        public byte[] Padding7;
        [NMS(Size = 0x10)]
        public string ImpactShakeEffect;

        public GcProjectileImpactType ImpactType;
        public int IncreaseWanted;
        public float IncreaseWantedThresholdTime;
        public bool UseMiningDamage;
        public int MinDamage;
        public bool StaticUntilShot;
    }

    public class GcEngineComponentData : NMSTemplate
    {
        public int Type;
    }

    public class GcInventoryTechProbability : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Tech;
        public int DesiredTechProbability;
        public string[] DesiredTechProbabilityValues()
        {
            return new[] { "Never", "Rare", "Common", "Always" };
        }
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }

    public class GcCustomInventoryComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Size;
        public List<GcInventoryTechProbability> DesiredTechs;

        public bool Cool;
    }

    public class GcOutpostLSystemPair : NMSTemplate // 0x320 bytes
    {
        [NMS(Size = 0x20)]
        public string Locator;
        [NMS(Size = 6)]
        public NMSString0x80[] LSystems;
    }

    public class GcOutpostComponentData : NMSTemplate
    {
        /* 0x000 */ public bool SpaceStation;
        /* 0x001 */ public bool AIDestination;
        /* 0x002 */ public bool HasOwnGravity;

        /* 0x004 */ public float ApproachCircleRadius;
        /* 0x008 */ public float ApproachRange;
        /* 0x00C */ public float ApproachAngle;
        /* 0x010 */ public float ApproachSpeed;

        /* 0x014 */ public float LandingSpeed;
        /* 0x018 */ public float LandingHeight;
        /* 0x01C */ public bool RotateToDock;

        /* 0x020 */ public float TakeOffHeight;
        /* 0x024 */ public float TakeOffFwdDist;
        /* 0x028 */ public float TakeOffTime;
        /* 0x02C */ public float TakeOffAlignTime;
        /* 0x030 */ public float TakeOffSpeed;
        /* 0x034 */ public float TakeOffBoost;

        /* 0x038 */ public List<GcOutpostLSystemPair> LSystems;
    }

    public class TkAnimPoseData : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string Anim;
        public int FrameStart;
        public int FrameEnd;
    }

    public class TkAnimPoseCorrelationData : NMSTemplate // 0x28 bytes
    {
        [NMS(Size = 0x10)]
        public string ItemA;
        [NMS(Size = 0x10)]
        public string ItemB;
        public float Correlation;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding24;
    }

    public class TkAnimPoseExampleElement : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string Anim;
        public float Value;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }

    public class TkAnimPoseExampleData : NMSTemplate // 0x10 bytes
    {
        public List<TkAnimPoseExampleElement> Elements;
    }

    public class TkAnimPoseComponentData : NMSTemplate
    {
        public List<TkAnimPoseData> PoseAnims;

        [NMS(Size = 0x80)]
        public string Filename;

        public List<TkAnimPoseCorrelationData> Correlations;
        public List<TkAnimPoseExampleData> Examples;
        public List<float> CorrelationMat;

        public float AdultCorrelationValue;
    }

    public class TkAudioAnimTrigger : NMSTemplate // 0x98 bytes
    {
        [NMS(Size = 0x80)]
        public string Sound;
        [NMS(Size = 0x10)]
        public string Anim;

        public int FrameStart;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding94;
    }

    public class TkAudioComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Ambient;

        public int MaxDistance;

        public List<TkAudioAnimTrigger> AnimTriggers;
    }

    public class GcTurretComponentData : NMSTemplate
    {
        public int GunType;
        public string[] GunTypeValues()
        {
            return new[] { "Laser", "Projectile" };
        }
    }

    public class GcSpaceshipClasses : NMSTemplate
    {
        public int ShipClass;
        public string[] ShipClassValues()
        {
            return new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle" };
        }
    }

    public class GcPrimaryAxis : NMSTemplate
    {
        public int PrimaryAxis;
        public string[] PrimaryAxisValues()
        {
            return new[] { "Z", "ZNeg" };
        }
    }

    public class GcAISpaceshipComponentData : NMSTemplate
    {
        public GcAISpaceshipTypes ShipType;
        public GcSpaceshipClasses ShipClass;
        public GcPrimaryAxis PrimaryAxis;
        [NMS(Size = 0x10)]
        public string Weapon;
    }

    public class GcCreatureIkType : NMSTemplate
    {
        public int CreatureIkType;
        public string[] CreatureIkTypeValues()
        {
            return new[] { "Foot", "Hinge_X", "Hinge_Y", "Hinge_Z", "Locked", "Head", "Toe", "SpaceshipFoot", "SpaceshipToe" };
        }
    }

    public class GcCreatureIkData : NMSTemplate
    {
        public GcCreatureIkType CreatureIkType;
        [NMS(Size = 0x100)]
        public string JointName;
    }

    public class GcCreatureFullBodyIKComponentData : NMSTemplate
    {
        public List<GcCreatureIkData> JointData;
        public int HeadUpAxis;
        public string[] HeadUpAxisValues()
        {
            return new[] { "X", "XNeg", "Y", "YNeg", "Z", "ZNeg" };
        }

        public bool UseFootGlue;
    }

    public class GcSizeIndicator : NMSTemplate
    {
        public int SizeIndicator;
        public string[] SizeIndicatorValues()
        {
            return new[] { "Small", "Medium", "Large" };
        }
    }

    public class GcInteractionActivationCost : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string SubstanceId;
        public List<NMSString0x10> AltIds;

        public int Cost; // might be float
        public bool Repeat;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding25;
    }

    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        public int SimpleInteractionType;
        public string[] SimpleInteractionTypeValues()
        {
            return new[] { "Interact", "Treasure", "Beacon", "Scan", "Save", "CallShip", "Word", "Tech", "GenericReward", "Feed" };
        }

        public float InteractDistance;
        [NMS(Size = 0x10)]
        public string Id;

        public GcRarity Rarity;
        public GcSizeIndicator SizeIndicator;
        [NMS(Size = 0x10)]
        public string TriggerAction;
        public bool BroadcastTriggerAction;
        public float Delay;

        public bool InteractIsCrime;
        public int InteractCrimeLevel;
        public GcInteractionActivationCost ActivationCost;

        [NMS(Size = 0x20)]
        public string Name;
    }

    public class GcObjectPlacementComponentData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string GroupNodeName;

        public int ActivationType;
        public float FractionOfNodesActive;
        public int MaxNodesActivated;
        public int MaxGroupsActivated;
        public bool UseRaycast;
    }

    public class TkCameraWanderData : NMSTemplate
    {
        public bool CamWander;
        public float CamWanderPhase;
        public float CamWanderAmplitude;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC;
    }

    public class TkModelRendererCameraData : NMSTemplate // 0x40 bytes
    {
        public float Distance;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        public Vector4f Offset;
        public float Pitch;
        public float Rotate;
        public float LightPitch;
        public float LightRotate;
        public TkCameraWanderData Wander;
    }

    public class TkModelRendererData : NMSTemplate // 0x70 bytes
    {
        public TkModelRendererCameraData Camera;
        public float Fov;
        public float AspectRatio;
        public int ThumbnailMode;
        public string[] ThumbnailModeValues()
        {
            return new[] { "None", "HUD", "GUI" };
        }
        public int FocusType;
        public string[] FocusTypeValues()
        {
            return new[] { "ResourceBounds", "ResourceBoundingHeight", "NodeBoundingBox" };
        }

        [NMS(Size = 0x10)]
        public string Anim;

        public float HeightOffset;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding64;
    }

    public class GcInteractionComponentData : NMSTemplate
    {
        /* 0x000 */ public int InteractionAction;
        public string[] InteractionActionValues()
        {
            return new[] { "PressButton", "HoldButton", "Shoot" };
        }

        /* 0x004 */ public GcInteractionType InteractionType;
        [NMS(Size = 8, Ignore = true)]
        /* 0x008 */ public byte[] Padding8;
        /* 0x010 */ public TkModelRendererData Renderer;
        /* 0x080 */ public GcAlienRace AlienRace;
        /* 0x084 */ public float AttractDistanceSq;
        /* 0x088 */ public bool RepeatInteraction;
        /* 0x089 */ public bool UseInteractCamera;

        /* 0x08C */ public float BlendToCameraTime;
        /* 0x090 */ public float BlendFromCameraTime;
        /* 0x098 */ public GcInteractionActivationCost ActivationCost;

        [NMS(Size = 0x10)]
        /* 0x0C0 */ public string TriggerAction;

        /* 0x0D0 */ public bool BroadcastTriggerAction;
        /* 0x0D4 */ public float InteractAngle;
        /* 0x0D8 */ public float InteractDistance;
        /* 0x0DC */ public bool InteractInvertFace;
        /* 0x0E0 */ public GcInteractionType SecondaryInteractionType;
        /* 0x0E8 */ public GcInteractionActivationCost SecondaryActivationCost;
        /* 0x110 */ public List<TkModelRendererData> EventRenderers;

        /* 0x120 */ public float SecondaryCameraTransitionTime;
        /* 0x124 */ public bool DoInteractionsInOrder;
    }

    public class GcEncounterComponentData : NMSTemplate
    {
        public int EncounterType;
        public string[] EncounterTypeValues()
        {
            return new[] { "Guards", "Patrol", "Ambush" };
        }
        public int EncounterRobot;
        public string[] EncounterRobotValues()
        {
            return new[] { "Drones", "Quads", "Walker" };
        }
        public int CountMin;
        public int CountMax;
    }

    public class GcAudioAreaTriggerComponentData : NMSTemplate
    {
        public GcAudioWwiseEvents AkEvent1; // EnterAreaEvent perhaps?
        public GcAudioWwiseEvents AkEvent2; // ExitAreaEvent ?
        public float EnterDistance;
        public float ExitDistance;
    }
    public class GcDiscoveryTypes : NMSTemplate
    {
        public int DiscoveryType;
        public string[] DiscoveryTypeValues()
        {
            return new[] { "Unknown", "SolarSystem", "Planet", "Animal", "Flora", "Mineral", "Sector" };
        }
    }

    public class GcEncyclopediaComponentData : NMSTemplate
    {
        public GcDiscoveryTypes DiscoveryType;
    }

    public class GcCreatureComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcPrimaryAxis PrimaryAxis;
        public float Scaler;
    }

    public class TkProceduralModelComponentData : NMSTemplate
    {
        public List<NMSString0x80> List;
    }

    public class GcCreatureBaitComponentData : NMSTemplate
    {
        public List<NMSString0x10> AttractList;
        public float BaitStrength;
        public float BaitRadius;

        public bool Debug;
        public bool InducesRage;
    }

    public class TkDynamicChainComponentData : NMSTemplate
    {
        public float AngularLimit;
        public float TwistLimit;
        public float MotorStrengthCone;
        public float MotorStrengthTwist;
        public float MaxMotorForce;
        public float Gravity;
        public float AirThickness;
        public float VertAirThickness;
        public float WindStrength;
        public float LinearDamping;
        public float AngularDamping;
        public float InitialBodyMass;
        public float BodyMassChange;
        public bool WeightByJointLength;

        public List<NMSString0x20> IgnoreJoints;
    }

    public class GcGenericIconTypes : NMSTemplate
    {
        public int GenericIconType;
        public string[] GenericIconTypeValues()
        {
            return new[] { "None", "Interaction", "SpaceStation", "SpaceAnomaly", "SpaceAtlas" };
        }
    }

    public class GcMarkerComponentData : NMSTemplate
    {
        public GcGenericIconTypes GenericIconType;
        public float Radius;
        public int DisplayMode;
        public string[] DisplayModeValues()
        {
            return new[] { "Always", "SpaceOnly", "PlanetOnly" };
        }

        public bool ShipScannable;
    }

    public class GcPlayerNearbyEvent : NMSTemplate
    {
        public int RequirePlayerAction;
        public string[] RequirePlayerActionValues()
        {
            return new[] { "None", "Fire", "InShip", "OnFoot", "OnFootOutside", "Upload" };
        }
        public float Distance;
        public float Angle;
        public bool AnglePlayerRelative;
        public float AngleOffset;
        public bool AngleReflected;
        public float AngleMinDistance;
        public int DistanceCheckType;
        public string[] DistanceCheckTypeValues()
        {
            return new[] { "Radius", "BoundingBox" };
        }
        public bool Inverse;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding21;
    }

    public class GcGoToStateAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string State;

        public bool Broadcast;
        public int BroadcastLevel;
        public string[] BroadcastLevelValues()
        {
            return new[] { "Scene", "LocalModel" };
        }
    }

    public class GcDisplayText : NMSTemplate
    {
        public int HUDTextDisplayType;
        public string[] HUDTextDisplayTypeValues()
        {
            return new[] { "Full", "Compact", "EyeLevel", "Prompt", "Tooltip" };
        }

        [NMS(Size = 0x100)]
        public string Title;
        [NMS(Size = 0x100)]
        public string Subtitle1;
        [NMS(Size = 0x100)]
        public string Subtitle2;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding304;
    }

    public class GcSpawnAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Event;
    }

    public class GcBeenShotEvent : NMSTemplate
    {
        public int ShotBy;
        public string[] ShotByValues()
        {
            return new[] { "Player", "Anything" };
        }

        public int DamageThreshold;
        public float HealthThreshold;

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC;
    }

    public class GcParticleAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Effect;
        [NMS(Size = 0x20)]
        public string Joint;
        public bool Exact;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding31;
    }

    public class GcSpaceshipComponentData : NMSTemplate
    {
        public GcSpaceshipClasses ShipClass;
        [NMS(Size = 0x80)]
        public string Cockpit;
        public float MaxHeadTurn;
        public float MaxHeadPitchUp;
        public float MaxHeadPitchDown;
        public int BaseHealth;
        public float FoVFixedDistance;
    }

    public class GcStateTimeEvent : NMSTemplate
    {
        public float Seconds;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;
    }

    public class GcNodeActivationAction : NMSTemplate
    {
        public int NodeActiveState;
        public string[] NodeActiveStateValues()
        {
            return new[] { "Activate", "Deactivate", "Toggle" };
        }

        [NMS(Size = 0x80)]
        public string Name;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding84;
    }

    public class GcAnimFrameEvent : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Anim;
        public int FrameStart;
        public bool StartFromEnd;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding15;
    }

    public class GcPlayAudioAction : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Sound;
    }

    public class GcPlayAnimAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Anim;
    }

    public class GcDestroyAction : NMSTemplate
    {
        public bool DestroyAll;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding1;
    }

    public class GcPainAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Damage;
        public float Radius;
        public bool AffectsPlayer;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding15;
    }

    public class GcScareCreaturesAction : NMSTemplate
    {
        public float HearRadius;
        public float FleeRadius;
    }

    public class GcCameraShakeAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Shake;
        public float FalloffMin;
        public float FalloffMax;
    }

    public class GcWarpAction : NMSTemplate
    {
        public int WarpType;
        public string[] WarpTypeValues()
        {
            return new[] { "BlackHole" }; // one value? :D:D
        }
    }

    public class GcLootComponentData : NMSTemplate
    {
        public Vector2f Timed;
        [NMS(Size = 0x10)]
        public string TimeOutEffect;
        public bool DeathPoint;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding19;
    }

    public class GcDroneComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcPrimaryAxis PrimaryAxis;
        public float Scaler;
        public GcCreatureHealthData Health;
    }

    public class TkRagdollData : NMSTemplate
    {
        public float Density;
        public float Gravity;
        public List<NMSString0x20> ChainEnds;
        public List<NMSString0x20> ExcludeJoints;
    }

    public class GcWaypointComponentData : NMSTemplate
    {
        public TkTextureResource Icon;
    }

    public class GcNPCComponentData : NMSTemplate
    {
        public GcAlienRace AlienRace;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;
    }

    public class TkAttachmentData : NMSTemplate
    {
        public List<NMSTemplate> Components;
    }
}
