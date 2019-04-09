# Usage

libMBIN is a public API for MBINCompiler which allows other applications to directly read and write `.MBIN` files.
It also allows direct manipulation and creation of any MBINCompiler structs.

## Input/Output

`libMBIN` has two functions specifically for reading and writing `.MBIN` and `.EXML` files:

#### **FileIO.LoadFile(string file)**

*Parameters:*  
    file : `string`  
    The path to the file that is to be loaded. This can be either the path to an `.EXML`, or an `.MBIN`.

*Returns:*  
    `NMSTemplate`  
    The object containing all the information from the file.  
    To use this more effectively, this value should be cast to the correct type which can be known by observing the type of struct used in the header of the `.MBIN` file.

The **FileIO.LoadMbin(string path)** and **FileIO.LoadExml(string path)** functions can be used for specific file type only loading if required.

#### **NMSTemplate.WriteToMbin(string outputpath)** and **NMSTemplate.WriteToExml(string outputpath)**

This writes the current `NMSTemplate` object to a file, either serializing it directly to an `.MBIN` file for reading by the game, or to an `.EXML` file for further external modification.

*Parameters:*  
    outputpath : `string`  
    The full path and filename of the required output file.


## NMSTemplate manipulation

Once loaded, all objects can be manipulated freely. To know what attributes a certain struct has, it is recommended that you look in the [source code](https://github.com/monkeyman192/MBINCompiler/tree/development/libMBIN/Source/NMS) for MBINCompiler .