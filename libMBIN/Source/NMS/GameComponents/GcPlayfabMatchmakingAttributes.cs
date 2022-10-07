namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27FA6871BF53D406, NameHash = 0x49457F0F4ABEDEE6)]
    public class GcPlayfabMatchmakingAttributes : NMSTemplate
    {
        /* 0x000 */ public NMSString0x40 UA;
        /* 0x040 */ public NMSString0x80 matchmakingVersion;
        /* 0x0C0 */ public int isBackfilling;
        /* 0x0C4 */ public int needsSmallLobby;
        /* 0x0C8 */ public int gameProgress;
        /* 0x0CC */ public NMSString0x80 platform;
        /* 0x14C */ public NMSString0x80 gamemode;
        /* 0x1CC */ public NMSString0x100 lobbyConnectionString;
    }
}
