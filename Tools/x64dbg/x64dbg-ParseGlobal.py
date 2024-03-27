import struct
from ctypes import *
from x64dbgpy import *

################################################################################

def get_string(ea, max_length=1024):
    byte_array = bytearray()
    for offset in xrange(max_length + 1):
        read_byte = pluginsdk.ReadByte(ea + offset)
        if (read_byte == 0):
            break
        byte_array.append(read_byte)

    return str(byte_array)
	
################################################################################
def GetType( typeID, subtypeID, typePtr ):
	typeName  = typeID
	if (typeID == 0x01):
		typeName = "bool"
	elif (typeID == 0x03): # struct
		typeName = "?struct 0x%016X" % typePtr
	elif (typeID == 0x04):
		typeName = "Colour"
	elif (typeID == 0x08): # enum
		typeName = "int"
	elif (typeID == 0x09):
		typeName = "string"
		if (subtypeID == -1):
			typeName = "NMSString0x80"
	elif (typeID == 0x0B):
		typeName = "float"
	elif (typeID == 0x0C):
		typeName = "string"
		if (subtypeID == -1):
			typeName = "NMSString0x10"
	elif (typeID == 0x0E):
		typeName = "string"
		if (subtypeID == -1):
			typeName = "NMSString0x20"
	elif (typeID == 0x11): # uint?
		typeName = "int"
	elif (typeID == 0x15):
		typeName = "GcSeed"
	elif (typeID == 0x16): # static array
		typeName = "%s[]" % GetType( subtypeID, -1, typePtr )
	elif (typeID == 0x17): # LocID?
		typeName = "string"
		if (subtypeID == -1):
			typeName = "NMSString0x20"
	elif (typeID == 0x1A):
		typeName = "string"
		if (subtypeID == -1):
			typeName = "NMSString0x100"
	elif (typeID == 0x21): # ulong?
		typeName = "ulong"
	elif (typeID == 0x22):
		typeName = "Vector2f"
	elif (typeID == 0x23):
		typeName = "Vector4f" # should be Vector3f. MBINCompiler is not padding correctly
	elif (typeID == 0x24):
		typeName = "Vector4f"

	return typeName

################################################################################

def ParseGlobal( addr, totalSize ):
	currentOffset = 0
	while True:
		name      = get_string( pluginsdk.ReadQword( addr + 0x00 ) )
		unknown08 = pluginsdk.ReadDword( addr + 0x08 )
		typeID    = pluginsdk.ReadDword( addr + 0x0C )
		subtypeID = pluginsdk.ReadDword( addr + 0x10 )
		size      = pluginsdk.ReadDword( addr + 0x14 )
		offset    = pluginsdk.ReadDword( addr + 0x18 )
		unknown1C = pluginsdk.ReadDword( addr + 0x1C )
		typePtr   = pluginsdk.ReadQword( addr + 0x20 )

		if (not name):
			break

		addr += 0x28

		typeName = GetType( typeID, subtypeID, typePtr )
		comment = ""

		pad = (offset - currentOffset)
		if (pad != 0):
			print "        [NMS(Size = 0x%02X, Ignore = true)]" % pad
			print "        /* 0x%04X */ public byte[] Padding%X;" % (currentOffset, currentOffset)

		if ((typeID == 0x08) or (subtypeID == 0x08)):
			comment = " // TODO: should be enum"

		length = 0
		if (typeID == 0x16):
			# array
			nextOffset = pluginsdk.ReadDword( addr + 0x18 )
			if (nextOffset == 0):
				nextOffset = totalSize
			length = (nextOffset - offset) / size;
			size *= length
		elif ((typeID == 0x09) or (typeID == 0x0C) or (typeID == 0x0E) or (typeID == 0x17) or (typeID == 0x1A)):
			# string types
			length = size

		if (length != 0): # array or string
			print "        [NMS(Size = 0x%02X)]" % length
			
		print "        /* 0x%04X */ public %s %s;%s" % (offset, typeName, name, comment)

		currentOffset = offset + size

		if (typeName == typeID):
			break
