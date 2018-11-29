import struct
from ctypes import *
from x64dbgpy import *

################################################################################

def get_section( section_name, module=pluginsdk.GetMainModuleInfo()):
	for i in xrange(module.sectionCount):
		section = pluginsdk.SectionFromAddr(module.base, i)
		if (section.name == section_name):
			return section

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

if __name__ == '__main__':
	text_section  = get_section('.text')
	rdata_section = get_section('.rdata')
	data_section  = get_section('.data')

	size = text_section.size
	addr = text_section.addr
	count = 0
	while True:
		addr = pluginsdk.FindMem(addr, size, "04 C4 09 00 00")
		if not addr:
			break

		if addr == 0xFFFFFFFFFFFFFFFF:
			break

		typeGuid = ""
		typeName = ""
		bytesRemaining = 0x40

		#print "0x%016X" % (addr)
		addr2 = pluginsdk.FindMem(addr + 5, 0x20, "48 B8" )
 		if not addr2:
 			addr2 = pluginsdk.FindMem(addr + 5, 0x40, "48 B9" )
		if addr2:
			addr2 += 2
			typeGuid = "0x%016X\t" % pluginsdk.ReadQword( addr2 )
			addr2 += 8
			bytesRemaining = (addr2 - addr)

			addr2 = pluginsdk.FindMem(addr2, 0x40, "48 8D 15" )
			if addr2:
				addr2 += 3
				addr2 += 4 + pluginsdk.ReadDword( addr2 )
				typeName = "%s\t" % ( get_string( addr2 ) )
				bytesRemaining = 0

		bytes = ""
		byte_array = bytearray()
		for offset in xrange(bytesRemaining):
			read_byte = pluginsdk.ReadByte( addr + offset )
			bytes += "%02X " % read_byte

		if (bytesRemaining != 0):
			print "0x%016X\t%s%s%s" % (addr, typeGuid, typeName, bytes)
		else:
			print "0x%016X\t%s%s" % (addr, typeGuid, typeName)

		addr += 1
		size = addr - text_section.addr
		count += 1
		if (count >= 5000):
			break

	print "%d occurences found." % count


################################################################################
# import struct
# from ctypes import *
# from x64dbg_python import *
#
# 
# class App(Structure):
#     _fields_ = [
#         ("id", c_int32),
#         ("name", c_void_p),
#         ("callback", c_void_p),
#     ]
#
# 
# def bswap(val):
#     return struct.unpack("<I", struct.pack(">I", val))[0]
# 
# def get_section(section_name, module=pluginsdk.GetMainModuleInfo()):
#     for i in xrange(module.sectionCount):
#         section = pluginsdk.SectionFromAddr(module.base, i)
#         if section.name == section_name:
#             return section
# 
# def get_string(ea, max_length=1024):
#     byte_array = bytearray()
#     for offset in xrange(max_length + 1):
#         read_byte = pluginsdk.ReadByte(ea + offset)
#         if read_byte == 0:
#             break
#         byte_array.append(read_byte)
# 
#     return str(byte_array)
# 
# 
# if __name__ == '__main__':
#     rdata_section = get_section('.rdata')
#     Test1_address = pluginsdk.FindMem(rdata_section.addr, rdata_section.size, "Test1".encode('hex'))
#     data_section = get_section('.data')
#     Test1_pointer = pluginsdk.FindMem(data_section.addr, data_section.size, "%08X" % bswap(Test1_address))
#     app_array_address = Test1_pointer - sizeof(c_int32)
# 
#     app_size = sizeof(App)
#     app_offset = 0
#     while True:
#         app = App.from_buffer_copy(pluginsdk.Read(app_array_address + app_offset, app_size))
#         if not app.name:
#             break
# 
#         print 'App Id: %d' % app.id
#         print 'App Name: %s' % get_string(app.name)
#         print 'App Callback Address: 0x%08X\n' % app.callback
# 
#         app_offset += app_size
