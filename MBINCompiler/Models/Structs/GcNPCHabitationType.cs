namespace MBINCompiler.Models.Structs
{
    public class GcNPCHabitationType : NMSTemplate
    {
        public int NPCHabitationType;
        public string[] NPCHabitationTypeValues()
        {
            return new[] { "None", "WeaponsExpert", "Farmer", "Builder", "Vehicles", "Scientist" };
        }
    }
}
