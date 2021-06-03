using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1408, GUID = 0xA11EB28A67E6FAA5, NameHash = 0x1D3FECE6AC6A7E9F)]
    public class GcByteBeatLibraryData : NMSTemplate
    {
        [NMS(Size = 0x8)]
        /* 0x0000 */ public GcByteBeatSong[] MySongs;
        [NMS(Size = 0x10)]
        /* 0x1300 */ public NMSString0x10[] Playlist; 
        /* 0x1400 */ public bool Shuffle;
        /* 0x1401 */ public bool AutoplayOnFoot;
        /* 0x1402 */ public bool AutoplayInShip;
        /* 0x1403 */ public bool AutoplayInVehicle;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1404 */ public byte[] EndPadding;
    }
}
