namespace libMBIN.Models.Structs
{
    public class GcPlayerCommunicatorMessage : NMSTemplate      // size: 0x28
    {
        [NMS(Size = 0x20)]
        public string Dialog;
        public bool ShowHologram;
        public int CommunicatorType;
        public string[] CommunicatorTypeValues()
        {
            return new[] { "HoloExplorer", "HoloSceptic", "HoloNoone", "Generic", "PlayerFreighterCaptain", "Polo", "Nada"};
        }
    }
}
