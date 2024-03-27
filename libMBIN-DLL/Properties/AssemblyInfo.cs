﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("libMBIN")]
[assembly: AssemblyDescription("A modding tool for the game: No Man's Sky that converts the game's MBIN data files (binary) into human-readable EXML files (text) that can be edited with any text editor and then converted back again for use in a modded game.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("libMBIN")]
[assembly: AssemblyCopyright("Copyright © 2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("f2d295a6-d082-4eb4-8fc9-f4687f674939")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]

// Do not modify the attributes below.
// To Update the version, see libMBIN.Version.VERSION.STRING.
[assembly: AssemblyVersion( libMBIN.Version.VERSION_STRING )]
[assembly: AssemblyFileVersion( libMBIN.Version.VERSION_STRING )]

// MBINCompiler needs access to libMBIN.Version.VERSION_STRING
[assembly: InternalsVisibleTo( "MBINCompiler" )]

// Unit tests needs access to internals
[assembly: InternalsVisibleTo( "MBINCompilerTests" )]