This application's sole purpose is to assist in keeping a local copy of the source in an easy
to reference location, with automated compressing and decompressing of the pak files using 
batched commands and an intuitive directory structure.  the compiler will generate the Decompressor directory
and the application will work from there. if your game's PCBANKS dir is not located here:

"C:\Program Files (x86)\Steam\steamapps\common\No Man's Sky\GAMEDATA\PCBANKS"

then please use the -s switch with the appropriate path.

Usage: NMSDecompressor [-s:NMSSourcePath] | [-i] | [-r] | [-g]
runs the psarc.exe decompressor on the build located in .\pre.
all decompressed files will be located in the .\post
   -g   runs application with default configuration.
   -i   ignores the NMSSourcePath as well as doing the manual copy.
        assumes that .\pre already contains pack files.
   -s   redirects auto-pull from the standard path to the specified location.
        This is from the common steam route to NMS's PCBANKS dir.
   -r   This runs the recompress command.
        final .pak files can be located in .\recomp.