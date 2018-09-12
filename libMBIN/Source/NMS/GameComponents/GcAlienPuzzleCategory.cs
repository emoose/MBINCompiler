namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x16D566E68C668BFE)]
    public class GcAlienPuzzleCategory : NMSTemplate
    {
		public enum AlienPuzzleCategoryEnum { Default, GuildTraderNone, GuildTraderLow, GuildTraderMed, GuildTraderHigh, GuildTraderBest, GuildWarriorNone, GuildWarriorLow,
                                              GuildWarriorMed, GuildWarriorHigh, GuildWarriorBest, GuildExplorerNone, GuildExplorerLow, GuildExplorerMed, GuildExplorerHigh,
                                              GuildExplorerBest }
		public AlienPuzzleCategoryEnum AlienPuzzleCategory;
    }
}
