using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x5A9ACF1C6E60399B, NameHash = 0x428DC2A675E89B6D)]
    public class GcAlienPuzzleCategory : NMSTemplate
    {
        // size: 0x33
        public enum AlienPuzzleCategoryEnum {
            Default, GuildTraderNone, GuildTraderLow, GuildTraderMed, GuildTraderHigh, GuildTraderBest, GuildWarriorNone, GuildWarriorLow, GuildWarriorMed, GuildWarriorHigh,
            GuildWarriorBest, GuildExplorerNone, GuildExplorerLow, GuildExplorerMed, GuildExplorerHigh, GuildExplorerBest, BiomeHot, BiomeCold, BiomeLush, BiomeDusty,
            BiomeTox, BiomeRad, BiomeWeird, LocationSpaceStation, LocationShop, LocationOutpost, LocationObservatory, Walking, ExtremeWeather, ExtremeSentinels,
            WaterPlanet, FreighterCrew, FreighterCrewOwned, ShipShop, SuitShop, WeapShop, VehicleShop, MoodVeryPositive, MoodPositive, MoodNeutral,
            MoodNegative, MoodVeryNegative, Proc, FirstAbandonedFreighter, StandardAbandonedFreighter, BiomeSwamp, BiomeLava, AbandonedSystem, InhabitedSystem, SettlementOwned,
            SettlementNotOwned
        }
        public AlienPuzzleCategoryEnum AlienPuzzleCategory;
    }
}