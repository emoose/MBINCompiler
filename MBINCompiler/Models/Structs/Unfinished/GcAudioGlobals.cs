namespace MBINCompiler.Models.Structs.Unfinished
{
    public class GcAudioGlobals : NMSTemplate
    {
        // the func that uses the blocks of floats below (up to 0x3C) seems to associate each 3 with a different NPC type
        [NMS(Size = 0x5, EnumValue = new string[0x5] { "None", "Pirate", "Police", "Trader", "Freighter"})]
        public GcAudio3PointDopplerData[] Unknown0;

        public float Unknown3C;
        public float Unknown40;
        public float Unknown44;
        public float Unknown48;
        public float Unknown4C;
        public float Unknown50;
        public float Unknown54;
        public float Unknown58;
        public float Unknown5C;
        public float Unknown60;
        public float Unknown64;
        public float Unknown68;
        public float Unknown6C;
        public float Unknown70;
        public float Unknown74;
        public float Unknown78;
        public float Unknown7C;

        public float Unknown80;
        public float Unknown84;
        public float Unknown88;
        public float Unknown8C;
        public float Unknown90;
        public float Unknown94;
        public float Unknown98;
        public float Unknown9C;
        public float UnknownA0;
        public float UnknownA4;
        public float UnknownA8;

        public bool UnknownAC; // if false, main code chunk inside cGcAudioManager::RunObstructionQueries won't get run (default true)

        public int UnknownB0;
        public float UnknownB4;
        public float UnknownB8;
        public float UnknownBC;

        public bool UnknownC0; // if true, loads music from /MUSIC/PULSE.XML? (default true)

        [NMS(Size = 3, Ignore = true)]
        public byte[] PaddingC1;
    }
}
