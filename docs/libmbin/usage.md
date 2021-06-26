# Usage

libMBIN is a public API for MBINCompiler which allows other applications to directly read and write `.MBIN` files.
It also allows direct manipulation and creation of any MBINCompiler structs.

All features of MBINCompiler/libMBIN can be accessed by simply adding libMBIN to your c# project and adding `using libMBIN` to the top of any file you require it in.

## libMBIN.FileIO

This module is the primary entry point for using libMBIN. It contains a number of helpful functions that can be used to load eithe `.EXML` or `.MBIN` files into the structures used by MBINCompiler. Once you have loaded a file into the struct, you can then manipulate ony of the fields and save the structure back into either and `.EXML` or `.MBIN` file.

#### **FileIO.LoadFile(string path)**

*Parameters:*  
    path : `string`  
    The path to the file that is to be loaded. This can be either the path to an `.EXML`, or an `.MBIN`.

*Returns:*  
    `NMSTemplate`  
    The object containing all the information from the file.  
    To use this more effectively, this value should be cast to the correct type which can be known by observing the type of struct used in the header of the `.MBIN` or `.EXML` file.

This function will automatically determine what the file type is and load the file into an `NMSTemplate` object.
If you already know what type of fle is being passed in, or what to restrict the type of file loaded, then there are two further functions which can be used:

#### **FileIO.LoadMbin(string path)**

*Parameters:*  
    path : `string`  
    The path to the `.MBIN` file that is to be loaded.

*Returns:*  
    `NMSTemplate`  
    The object containing all the information from the file.  
    To use this more effectively, this value should be cast to the correct type which can be known by observing the type of struct used in the header of the `.MBIN` file.

#### **FileIO.LoadExml(string path)**

*Parameters:*  
    path : `string`  
    The path to the `.EXML` file that is to be loaded.

*Returns:*  
    `NMSTemplate`  
    The object containing all the information from the file.  
    To use this more effectively, this value should be cast to the correct type which can be known by observing the type of struct used in the header of the `.EXML` file.


### Examples:

Let's say we have a file, for example, `METADATA/REALITY/TABLES/BASEBUILDINGTABLE.MBIN` that we wish to load and modify.
The following code (ignoring not being within a proper function etc) will load the base building table and print out the id's of all objects in it.

``` c#
using libMBIN;
using libMBIN.NMS.GameComponents;

GcBaseBuildingTable bbTable = (GcBaseBuildingTable)FileIO.LoadMBin("BASEBUILDINGTABLE.MBIN");
foreach (GcBaseBuildingEntry obj in bbTable.Objects)
{
    Console.WriteLine(obj.ID);
}
```

Currently there is no way to determine automatically the data type of a file but this may come in future versions of the API.


## NMSTemplate

The `NMSTemplate` is a top-level object. All of `FileIO.LoadFile`, `FileIO.LoadMbin` and `FileIO.LoadExml` return a `NMSTemplate` object.
In libMBIN, all structs are subclassed from this object, meaning that you can very easily cast the `NMSTemplate` type to the struct type that you require.

This object has a few methods that are useful to write it back to an `.EXML` or `.MBIN` file:

#### **NMSTemplate.WriteToMbin(string path)**

*Parameters:*  
    path : `string`  
    The filepath of the required output file the struct will be written to.
    Note that there is no check that the output file extension is actual `.MBIN`.

This writes the current `NMSTemplate` object to an `.MBIN` file, ready to be read by the game.


#### **NMSTemplate.WriteToExml(string path)**

*Parameters:*  
    path : `string`  
    The filepath of the required output file the struct will be written to.
    Note that there is no check that the output file extension is actual `.EXML`.

This writes the current `NMSTemplate` object to an `.EXML` file, ready to be modified by a user manually or through the use of another program.
