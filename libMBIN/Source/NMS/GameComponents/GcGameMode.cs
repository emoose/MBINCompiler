namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4908B03210959014)]
    public class GcGameMode : NMSTemplate
    {
		public enum PresetGameModeEnum { Unspecified, Normal, Creative, Survival, Ambient, Permadeath }
		public PresetGameModeEnum PresetGameMode;
    }
}
