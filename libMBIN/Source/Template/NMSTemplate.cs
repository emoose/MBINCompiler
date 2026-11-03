// These defines require that the project is set to the 'Debug' configuration, not Release.
// They will always be disabled/ignored in Release builds.

// Uncomment to enable debug logging of the template de/serialization.
// #define DEBUG_TEMPLATE

// Uncomment to enable debug logging of XML comments
// #define DEBUG_COMMENTS

// Uncomment to enable debug logging of MBIN field names
// #define DEBUG_FIELD_NAMES

// Uncomment to enable debug logging of XML property names
// #define DEBUG_PROPERTY_NAMES


using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using libMBIN.NMS;
using System.Runtime.InteropServices;

namespace libMBIN
{
    public class NMSTemplate
    {
        internal static readonly string[] FakeTypes = { "Colour", "Vector2f", "Vector3f", "Vector4f", "Vector4i", "Colour32" };
        internal static readonly Dictionary<string, Type> NMSTemplateMap = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.BaseType == typeof(NMSTemplate))
                .ToDictionary(t => t.Name);

        internal static readonly Dictionary<uint?, string> NameHashToNameMap = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.BaseType == typeof(NMSTemplate))
                .Where(t => (t.GetCustomAttribute<NMSAttribute>()?.NameHash ?? 0) != 0)
                .ToDictionary(t => t.GetCustomAttribute<NMSAttribute>()?.NameHash, t => t.Name);

        internal static readonly Dictionary<uint?, Type> NameHashToNMSTemplate = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.BaseType == typeof(NMSTemplate))
                .Where(t => (t.GetCustomAttribute<NMSAttribute>()?.NameHash ?? 0) != 0)
                .ToDictionary(t => t.GetCustomAttribute<NMSAttribute>()?.NameHash);

        #region DebugLog
        // Conditionally compile methods for Release optimization.
        //
        // DEBUG is automatically defined if the project is set to the 'Debug' build configuration.
        // If the project is set to the 'Release' configuration, then DEBUG will not be defined.
        // 
        // Use the NMSTEMPLATE_* defines at the top of this file to enable/disable debug logging.

        // TODO: static could be problematic for threading?
        internal static bool isDebugLogTemplateEnabled = true;

        [Conditional( "DEBUG" )]
        internal static void DebugLogTemplate( string msg ) {
            #if DEBUG_TEMPLATE
                if (isDebugLogTemplateEnabled) Logger.LogDebug( msg );
            #endif
        }

        [Conditional( "DEBUG" )]
        internal static void DebugLogTemplate( string templateName, long position ) {
            #if DEBUG_TEMPLATE
                if (templateName != "MBINHeader") {
                    // "Undo" the subtraction of the header size since we are in it.
                    position -= MBINHeader.HEADER_SIZE;
                }
                if (isDebugLogTemplateEnabled) Logger.LogDebug($"{templateName}\t0x{position:X4}");
            #endif
        }

        [Conditional( "DEBUG" )]
        internal static void DebugLogComment( string msg ) {
            #if DEBUG_COMMENTS
                Logger.LogDebug( msg );
            #endif
        }

        [Conditional( "DEBUG" )]
        internal static void DebugLogFieldName( string msg ) {
            #if DEBUG_FIELD_NAMES
                Logger.LogDebug( msg );
            #endif
        }

        [Conditional( "DEBUG" )]
        internal static void DebugLogFieldName( string templateName, long position, long internalPos, string fieldName, object value ) {
            #if DEBUG_FIELD_NAMES
                if (templateName != "MBINHeader") {
                    // "Undo" the subtraction of the header size since we are in it.
                    position -= MBINHeader.HEADER_SIZE;
                }
                Logger.LogDebug( $"{templateName}\t0x{position:X4} (+0x{internalPos:X4})\t{fieldName}\t{value}" );
            #endif
        }

        [Conditional( "DEBUG" )]
        internal static void DebugLogPropertyName( string msg ) {
            #if DEBUG_PROPERTY_NAMES
                Logger.LogDebug( msg );
            #endif
        }

        #endregion

        public static Type GetTemplateType(string name) {
            if (NMSTemplateMap.TryGetValue(name, out Type type)) return type;
            return null;
        }

        public static Type GetTemplateType(uint nameHash) {
            if (NameHashToNMSTemplate.TryGetValue(nameHash, out Type type)) return type;
            return null;
        }

        public static NMSTemplate TemplateFromType(Type templateType) {
            if ( templateType != null) return Activator.CreateInstance( templateType ) as NMSTemplate;
            return null; // Template type doesn't exist
        }

        public static string TypeHasID(Type templateType) {
            IEnumerable<string> fieldNames = templateType.GetFields().Select(
                field => field.Name
            ).Where(
                fieldName => fieldName.ToLower() == "id"
            );
            if (fieldNames.Count() == 1) {
                return fieldNames.First();
            }
            return null;
        }

        public static bool ValueSerializable(Type fieldType) {
            if (typeof(INMSString).IsAssignableFrom(fieldType)) {
                // If the data is a string, we read as a property since it won't have the type.
                return true;
            } else if (fieldType == typeof(NMSTemplate) || fieldType.BaseType == typeof(NMSTemplate)) {
                return false;
            } else {
                return true;
            }
        }

        public static NMSTemplate TemplateFromName(string templateName) {
            Type type = GetTemplateType( templateName );
            if ( type != null) return Activator.CreateInstance( type ) as NMSTemplate;
            return null; // Template type doesn't exist
        }

        public static NMSTemplate TemplateFromNameHash(uint nameHash) {
            NameHashToNameMap.TryGetValue(nameHash, out string templateName);
            return TemplateFromName(templateName);
        }

        public int GetDataSize() {
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                var addt = new List<Tuple<long, object>>();
                int addtIdx = 0;

                var prevState = isDebugLogTemplateEnabled;
                isDebugLogTemplateEnabled = false;
                AppendToWriter(bw, ref addt, ref addtIdx, GetType());
                isDebugLogTemplateEnabled = prevState;

                return ms.ToArray().Length;
            }
        }

        public int OffsetOf(string field) {
            return OffsetOf(GetType(), field);
        }

        public static int OffsetOf(string className, string fieldName) {
            return OffsetOf(NMSTemplateMap[className], fieldName);
        }

        /// <summary>
        /// Get the relative offset within the class of the given field name.
        /// </summary>
        /// <param name="type">
        /// The type of the class that contains the specified field.
        /// </param>
        /// <param name="fieldName">
        /// The name of the field to find the offset of. This must be a field of this class itself, not a child class.
        /// </param>
        /// <exception cref="System.ArgumentException">Thrown when the fieldName value isn't a valid field of the specified class.</exception>
        /// <returns></returns>
        public static int OffsetOf(Type type, string fieldName)
        {
            var fields = type.GetFields().OrderBy(field => field.MetadataToken);
            int offset = 0;
            foreach (var field in fields)
            {
                int alignment = AlignOf(field.FieldType);
                // Make sure the alignment is taken into consideration.
                if (offset % alignment != 0) {
                    offset += alignment - (offset % alignment);
                }
                // Now check to see if the field name matches.
                if (fieldName == field.Name) {
                    return offset;
                }
                // If not, then add the size of the current field and continue.
                offset += SizeOf(field);
            }

            // If we get here then we have an issue. Throw an exception
            throw new ArgumentException($"{type.Name} has no field called {fieldName}", fieldName);
        }

        public static int GetTemplateDataSize(string templateName) {
            var template = TemplateFromName(templateName);
            if (template == null) return 0;

            return template.GetDataSize();
        }

        public static int SizeOf(FieldInfo field) {
            // Get the base size of the field.
            int size;
            // If the field is an array, we need to multiply this base size by the number of elements
            if (field.FieldType.IsArray) {
                size = SizeOf(field.FieldType.GetElementType());
                size *= field.GetCustomAttribute<NMSAttribute>()?.Size ?? 0;
            } else if (field.FieldType.Name == "String") {
                // The length of a string is an attribute.
                size = field.GetCustomAttribute<NMSAttribute>()?.Size ?? 0;
            } else {
                size = SizeOf(field.FieldType);
            }
            return size;
        }


        public static int SizeOf(Type type) {
            int size = 0;

            switch (type.Name)
            {
                case "Boolean":
                case "Byte":
                case "SByte":
                case "String":
                    size = 0x1;
                    break;

                case "Int16":
                case "UInt16":
                    size = 0x2;
                    break;

                case "Single":
                case "Int32":
                case "UInt32":
                    size = 0x4;
                    break;

                case "Int64":
                case "UInt64":
                    size = 0x8;
                    break;

                case "VariableSizeString":
                case "GcFilename":
                case "List`1":
                case "NMSTemplate":
                    size = 0x10;
                    break;

                default:
                    if (type.IsEnum) {
                        size = SizeOf(Enum.GetUnderlyingType(type));
                        break;
                    }

                    NMSAttribute settings = type.GetCustomAttribute<NMSAttribute>();
                    if (settings != null && settings.Size > 0) {
                        size = settings.Size;
                        break;
                    }

                    // For a class which inherits from the NMSTemplate, iterate over
                    // the fields and get the total size by adding up the sizes of the
                    // fields.
                    int max_alignment = 1;
                    int alignment = 1;
                    foreach (FieldInfo field in type.GetFields()) {
                        alignment = AlignOf(field.FieldType);
                        // If the current size doesn't match the alignment of the current field,
                        // then align it.
                        if (size % alignment != 0) {
                            size += (alignment - (size % alignment));
                        }
                        size += SizeOf(field);
                        // Update the max alignment.
                        if (alignment > max_alignment) {
                            max_alignment = alignment;
                        }
                    }
                    // Finally, ensure that the total size is a multiple of the max alignment.
                    if (size % max_alignment != 0) {
                        size += (max_alignment - (size % max_alignment));
                    }
                    // If the size is still 0 after this then it means that we got a class derived
                    // from NMSTemplate which has no fields. We still give this a nominal size of 1.
                    if (size == 0) {
                        size = 1;
                    }
                    break;
            }

            if (size != 0) { return size; }
            // If we have got here then we have got a type which we cannot determine the size of. Raise an error.
            throw new ArgumentException($"{type.Name} has an unknown size.");
        }

        private static ConcurrentDictionary<Type,int> AlignmentMap = new ConcurrentDictionary<Type,int>();

        public static int AlignOf(Type type) {
            int alignment;

            if (AlignmentMap.TryGetValue(type, out alignment)) {
                return alignment;
            }

            switch (type.Name) {
                case "Boolean":
                case "Byte":
                case "SByte":
                case "String":
                    alignment = 0x1;
                    break;

                case "Int16":
                case "UInt16":
                    alignment = 0x2;
                    break;

                case "Single":
                case "Int32":
                case "UInt32":
                    alignment = 0x4;
                    break;

                case "Int64":
                case "UInt64":
                case "List`1":
                case "NMSTemplate":
                case "VariableSizeString":
                case "GcFilename":
                    // TODO: See whether or not `max(0x8, AlignOf(<list subtype>))` is acctually the right value...
                    alignment = 0x8;
                    break;

                default:
                    if (type.IsArray) {
                        alignment = AlignOf(type.GetElementType());
                        break;
                    }

                    if (type.IsEnum) {
                        Type enumType = type.GetEnumUnderlyingType();
                        if ( enumType.Name == "UInt32") {
                            alignment = 0x4;
                        } else if (enumType.Name == "UInt16") {
                            alignment = 0x2;
                        } else {
                            alignment = 0x1;
                        }
                        break;
                    }

                    NMSAttribute settings = type.GetCustomAttribute<NMSAttribute>();
                    if (settings != null && settings.Alignment > 0) {
                        alignment = settings.Alignment;
                        break;
                    }

                    if (type.BaseType == typeof(NMSTemplate)) {
                        alignment = 1;

                        foreach (FieldInfo field in type.GetFields()) {
                            int align = AlignOf(field.FieldType);
                            if (align > alignment) {
                                alignment = align;
                                if (alignment >= 0x10) break;
                            }
                        }

                        break;
                    }

                    throw new UnknownTypeException( type );
            }

            AlignmentMap[type] = alignment;
            return alignment;
        }

        public static object DeserializeValue(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo, NMSTemplate parent) {
            // Logger.LogDebug( $"{fieldInfo?.DeclaringType.Name}.{fieldInfo?.Name}\ttype:\t{field.Name}\tpos:\t0x{templatePosition:X}" );

            object template = parent.CustomDeserialize( reader, field, settings, fieldInfo );
            if (template != null) return template;

            // TODO: change fieldType to fieldName...
            string fieldType = field.Name;
            switch (fieldType) {
                case "String":
                case "Byte[]":
                    int size = settings?.Size ?? 0;

                    if (fieldType == "String") {
                        return reader.ReadString(Encoding.UTF8, size, true);
                    } else {
                        return reader.ReadBytes(size);
                    }
                case "Single":
                    reader.Align( 4 );
                    return reader.ReadSingle();
                case "Boolean":
                    return reader.ReadByte() != 0;
                case "Byte":
                    return reader.ReadByte();
                case "SByte":
                    return reader.ReadSByte();
                case "Int16":
                case "UInt16":
                    reader.Align( 2 );
                    return fieldType == "Int16" ? (object)reader.ReadInt16() : (object)reader.ReadUInt16();
                case "Int32":
                case "UInt32":
                    reader.Align( 4 );
                    return fieldType == "Int32" ? (object)reader.ReadInt32() : (object)reader.ReadUInt32();
                case "Int64":
                case "UInt64":
                    reader.Align( 8 );
                    return fieldType == "Int64" ? (object)reader.ReadInt64() : (object)reader.ReadUInt64();
                case "List`1":
                    reader.Align( 8 );
                    if (field.IsGenericType && field.GetGenericTypeDefinition() == typeof(List<>)) {
                        Type itemType = field.GetGenericArguments()[0];
                        if ( itemType == typeof( NMSTemplate ) ) {
                            return DeserializeGenericList( reader, parent );
                        } else {
                            // todo: get rid of this nastiness
                            MethodInfo method = typeof( NMSTemplate ).GetMethod( "DeserializeList", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic )
                                                         .MakeGenericMethod( new Type[] { itemType } );
                            var list = method.Invoke( null, new object[] { reader, fieldInfo, settings, templatePosition, parent } );
                            return list;
                        }
                    }
                    return null;
                case "Colour32":
                    uint col = reader.ReadUInt32();
                    byte A = (byte)((col >> 24) & 0xFF);
                    byte B = (byte)((col >> 16) & 0xFF);
                    byte G = (byte)((col >> 8) & 0xFF);
                    byte R = (byte)(col & 0xFF);
                    Colour32 colour = new Colour32(R, G, B, A);
                    return colour;
                case "HashMap`1":
                    reader.Align(8);
                    Type subType = field.GetGenericArguments()[0];
                    MethodInfo meth = typeof( NMSTemplate ).GetMethod( "DeserializeHashMap", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic )
                                                         .MakeGenericMethod( new Type[] { subType } );
                    var result = meth.Invoke( null, new object[] { reader, fieldInfo, settings, templatePosition, parent } );
                    return result;
                case "NMSTemplate":
                    reader.Align( 8 );
                    long startPos = reader.BaseStream.Position;
                    long offset = reader.ReadInt64();
                    uint nameHash = reader.ReadUInt32();
                    uint NMSTemplateMagic = reader.ReadUInt32();
                    if (NMSTemplateMagic != 0xEEEEEE01) throw new InvalidListException(NMSTemplateMagic, reader.BaseStream.Position);
                    long endPos = reader.BaseStream.Position;
                    template = null;
                    if (offset != 0 && nameHash != 0) {
                        reader.BaseStream.Position = startPos + offset;
                        template = DeserializeBinaryTemplate(reader, nameHash);
                        if (template == null) throw new DeserializeTemplateException( nameHash );
                    }
                    reader.BaseStream.Position = endPos;
                    return template;
                default:
                    if ( fieldType == "VariableStringSize") {
                        reader.Align( 0x8 );
                    }

                    if (field.IsEnum) {
                        Type enumType = field.GetEnumUnderlyingType();
                        if (enumType.Name == "UInt32") {
                            reader.Align( 4 );
                            return (object)reader.ReadUInt32();
                        } else if (enumType.Name == "UInt16") {
                            reader.Align( 2 );
                            return (object)reader.ReadUInt16();
                        } else if (enumType.Name == "Byte") {
                            reader.Align( 1 );
                            return (object)reader.ReadByte();
                        }
                    }

                    if (field.IsArray) {
                        var arrayType = field.GetElementType();
                        var length = GetEnumNames( fieldInfo.Name, settings ).Length;
                        Array array = Array.CreateInstance(arrayType, length);
                        for (int i = 0; i < length; ++i) {
                            object val = DeserializeValue( reader, arrayType, settings, templatePosition, fieldInfo, parent );
                            array.SetValue(val, i);
                        }
                        return array;
                    } else {
                        reader.Align( AlignOf(field) );
                        return DeserializeBinaryTemplate(reader, fieldType);
                    }
            }
        }

        public static NMSTemplate DeserializeBinaryTemplate(BinaryReader reader, uint nameHash) {
            NMSTemplate template = TemplateFromNameHash(nameHash);
            return DeserializeBinaryTemplate(reader, template);
        }

        public static NMSTemplate DeserializeBinaryTemplate(BinaryReader reader, string templateName)
        {
            if (templateName.StartsWith("c") && templateName.Length > 1) templateName = templateName.Substring(1);
            NMSTemplate template = TemplateFromName(templateName);
            return DeserializeBinaryTemplate(reader, template);
        }

        public static NMSTemplate DeserializeBinaryTemplate(BinaryReader reader, NMSTemplate template) {
            if (template == null) return null;

            Type templateType = template.GetType();
            string templateName = templateType.Name;

            long templatePosition = reader.BaseStream.Position;
            using ( var indentScope = new Logger.IndentScope() ) {

                if (typeof(INMSVariableLengthString).IsAssignableFrom(templateType)) {
                    long stringPos = reader.ReadInt64();
                    int stringLength = reader.ReadInt32();
                    int magic = reader.ReadInt32();
                    int templateSize = 0x10;
                    if (templateName == "HashedString") {
                        // Read some extra bytes
                        uint hash = reader.ReadUInt32();
                        int magic2 = reader.ReadInt32();
                        templateSize = 0x18;
                    }
                    reader.BaseStream.Position = templatePosition + stringPos;
                    ((INMSVariableLengthString)template).String = reader.ReadString( Encoding.UTF8, stringLength ).TrimEnd( '\x00' );
                    
                    reader.BaseStream.Position = templatePosition + templateSize;
                    return template;
                }

                // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
                // TODO: We shouldn't need to order in .Net 7 and above...
                var fields = templateType.GetFields().OrderBy( field => field.MetadataToken );
                long fieldStartPos = reader.BaseStream.Position;
                foreach ( FieldInfo field in fields ) {
                    NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                    long fieldPos = reader.BaseStream.Position;
                    bool is_primitive = field.FieldType.BaseType != typeof(NMSTemplate);
                    if (!is_primitive) DebugLogFieldName(templateName, fieldPos, fieldPos - fieldStartPos, field.Name, "");
                    if ( field.FieldType.IsEnum ) {
                        field.SetValue( template, Enum.ToObject( field.FieldType, DeserializeValue( reader, field.FieldType, settings, fieldPos, field, template ) ) );
                    } else {
                        field.SetValue( template, DeserializeValue( reader, field.FieldType, settings, fieldPos, field, template ) );
                    }
                    if (is_primitive) DebugLogFieldName(templateName, fieldPos, fieldPos - fieldStartPos, field.Name, field.GetValue( template ));
                }
                reader.Align( AlignOf(templateType) ); // This is to remove the need for end padding
                
                template.FinishDeserialize();

            }

            return template;
        }

        public static List<NMSTemplate> DeserializeGenericList( BinaryReader reader, NMSTemplate parent ) {
            long listPosition = reader.BaseStream.Position;
            DebugLogTemplate( $"DeserializeGenericList\tstart\t0x{listPosition:X}" );

            long templateNamesOffset = reader.ReadInt64();
            int numTemplates = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if ( (listMagic & 0xFF) != 1 ) throw new InvalidListException( listMagic, reader.BaseStream.Position );

            long listEndPosition = reader.BaseStream.Position;

            reader.BaseStream.Position = listPosition + templateNamesOffset;
            List<NMSTemplate> list = new List<NMSTemplate>();
            if ( numTemplates > 0 ) {
                List<KeyValuePair<long, String>> templates = new List<KeyValuePair<long, String>>();
                for ( int i = 0; i < numTemplates; i++ ) {
                    long nameOffset = reader.BaseStream.Position;
                    long templateOffset = reader.ReadInt64();
                    uint nameHash = reader.ReadUInt32();
                    uint NMSTemplateMagic = reader.ReadUInt32();
                    if (NMSTemplateMagic != 0xEEEEEE01) throw new InvalidListException(NMSTemplateMagic, reader.BaseStream.Position);
                    NameHashToNameMap.TryGetValue(nameHash, out string name);
                    // sometimes there are lists which have n values, but less than n actual structs in them. We replace the empty thing with EmptyNode
                    name = (templateOffset == 0) ? "EmptyNode" : name;

                    templates.Add( new KeyValuePair<long, string>( nameOffset + templateOffset, name ) );
                }

                long pos = reader.BaseStream.Position;

                foreach ( KeyValuePair<long, string> templateInfo in templates ) {
                    reader.BaseStream.Position = templateInfo.Key;
                    var template = DeserializeBinaryTemplate( reader, templateInfo.Value );
                    if ( template == null ) throw new DeserializeTemplateException( templateInfo.Value );

                    list.Add( template );
                }
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align( 0x8 );

            return list;
        }

        public static HashMap<T> DeserializeHashMap<T>( BinaryReader reader, FieldInfo field, NMSAttribute settings, long templateStartOffset, NMSTemplate parent ) {
            long listPosition = reader.BaseStream.Position;

            long listStartOffset = reader.ReadInt64();
            int numEntries = reader.ReadInt32();
            uint endPaddingLShift = reader.ReadUInt32();

            // Skip the last 0x20 bytes
            long listEndPosition = reader.BaseStream.Position + 0x20;

            reader.BaseStream.Position = listPosition + listStartOffset;
            HashMap<T> hashMap = new HashMap<T>();
            for ( int i = 0; i < numEntries; i++ ) {
                var template = DeserializeValue( reader, field.FieldType.GetGenericArguments()[0], settings, templateStartOffset, field, parent );
                if ( template == null ) throw new DeserializeTypeException( typeof( T ) );

                var type = template.GetType().BaseType;
                if ( type == typeof( NMSTemplate ) ) ((NMSTemplate) template).FinishDeserialize();

                hashMap.Elements.Add( (T) template );
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align( 0x8 );

            return hashMap;
        }

        public static List<T> DeserializeList<T>( BinaryReader reader, FieldInfo field, NMSAttribute settings, long templateStartOffset, NMSTemplate parent ) {
            long listPosition = reader.BaseStream.Position;
            DebugLogTemplate( $"DeserializeList\tstart\t0x{listPosition:X}" );

            long listStartOffset = reader.ReadInt64();
            int numEntries = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if ( (listMagic & 0xFF) != 1 ) throw new InvalidListException( listMagic, reader.BaseStream.Position );

            long listEndPosition = reader.BaseStream.Position;

            reader.BaseStream.Position = listPosition + listStartOffset;
            var list = new List<T>();
            for ( int i = 0; i < numEntries; i++ ) {
                // todo: get rid of DeserializeGenericList? this seems like it would work fine with List<NMSTemplate>
                var template = DeserializeValue( reader, field.FieldType.GetGenericArguments()[0], settings, templateStartOffset, field, parent );
                if ( template == null ) throw new DeserializeTypeException( typeof( T ) );

                var type = template.GetType().BaseType;
                if ( type == typeof( NMSTemplate ) ) ((NMSTemplate) template).FinishDeserialize();

                list.Add( (T) template );
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align( 0x8 );

            return list;
        }

        public void SerializeValue(
            BinaryWriter writer,
            Type fieldType,
            object fieldData,
            NMSAttribute settings,
            FieldInfo field,
            ref List<Tuple<long, object>> additionalData,
            ref int addtDataIndex,
            UInt32 listEnding = 0xAAAAAA01,
            byte paddingByte = 0
        ) {
            //Logger.LogDebug( $"{field?.DeclaringType.Name}.{field?.Name}\ttype:\t{fieldType.Name}\tadditionalData.Count:\t{additionalData?.Count ?? 0}\taddtDataIndex:\t{addtDataIndex}" );

            if (CustomSerialize(writer, fieldType, fieldData, settings, field, ref additionalData, ref addtDataIndex)) return;

            switch ( fieldType.Name ) {
                case "String":
                case "Byte[]":
                    int size = settings?.Size ?? 0;
                    bool ignore = settings?.Ignore ?? false;

                    if ( fieldType.Name == "String" ) {
                        writer.WriteString( (string) fieldData, Encoding.UTF8, size, false, paddingByte );
                    } else {
                        byte[] bytes = (byte[]) fieldData;
                        if (ignore != true) size = bytes?.Length ?? 0;
                        Array.Resize( ref bytes, size);
                        writer.Write( bytes );
                    }
                    break;
                case "Single":
                    writer.Align( 4, field?.Name ?? fieldType.Name, paddingByte );
                    writer.Write( (Single) fieldData );
                    break;
                case "Boolean":
                    var value = (bool) fieldData;
                    writer.Write( value ? (byte) 1 : (byte) 0 );
                    break;
                case "Byte":
                    writer.Write( (Byte) fieldData );
                    break;
                case "SByte":
                    writer.Write( (SByte) fieldData );
                    break;
                case "Int16":
                case "UInt16":
                    writer.Align( 2, field?.Name ?? fieldType.Name, paddingByte );
                    if ( fieldType.Name == "Int16" ) {
                        writer.Write( (Int16) fieldData );
                    } else {
                        writer.Write( (UInt16) fieldData );
                    }
                    break;
                case "Int32":
                case "UInt32":
                    writer.Align( 4, field?.Name ?? fieldType.Name, paddingByte );
                    if ( fieldType.Name == "Int32" ) {
                        writer.Write( (Int32) fieldData );
                    } else {
                        writer.Write( (UInt32) fieldData );
                    }
                    break;
                case "Int64":
                case "UInt64":
                    writer.Align( 8, field?.Name ?? fieldType.Name, paddingByte );
                    if ( fieldType.Name == "Int64" ) {
                        writer.Write( (Int64) fieldData );
                    } else {
                        writer.Write( (UInt64) fieldData );
                    }
                    break;
                case "Colour32":
                    Colour32 colour = (Colour32)fieldData;
                    uint col = (uint)(colour.A << 24) + (uint)(colour.B << 16) + (uint)(colour.G << 8) + colour.R;
                    writer.Write(col);
                    break;
                case "List`1":
                    writer.Align( 8, field?.Name ?? fieldType.Name, paddingByte );
                    if ( field != null && field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof( List<> ) ) {
                        // write empty list header
                        long listPos = writer.BaseStream.Position;
                        writer.Write( (Int64) 0 ); // listPosition
                        writer.Write( (Int32) 0 ); // listCount
                        writer.Write( listEnding );
                        IList listData = (IList) fieldData;

                        if ( listData == null ) break;
                        if ( listData.Count == 0 ) break;

                        var data = new Tuple<long, object>( listPos, listData );
                        if ( addtDataIndex >= additionalData.Count ) {
                            additionalData.Add( data );
                        } else {
                            additionalData.Insert( addtDataIndex, data );
                        }
                        addtDataIndex++;
                    }
                    break;
                case "HashMap`1":
                    writer.Align( 8, field?.Name ?? fieldType.Name, paddingByte );

                    var templ = (IHashMap)fieldData;

                    // Add the contained list data to the addtionalData object then write the header.
                    var hmData = new Tuple<long, object>( writer.BaseStream.Position, templ );

                    writer.Write((ulong) 0);
                    writer.Write((uint)templ.Count);
                    writer.Write((uint)templ.EndPaddingLShift);
                    writer.Write(new byte[0x20]);
                    // Construct the correct number of bytes to store what I assume is the memory region the game uses when running to store the
                    // actual hashes.
                    IEnumerable<byte> start = Enumerable.Repeat((byte)0xD7, 4);
                    IEnumerable<byte> end = Enumerable.Repeat((byte)0xEB, 4);
                    byte[] hashPadding = start.Concat(new byte[(8 << (int)templ.EndPaddingLShift) - 8]).Concat(end).ToArray();
                    // This is always added at the start.
                    // Also set the offset as -8. This indicates that the value is an alignment value
                    // (+ve values are handled as offsets, -ve are handled as alignments).

                    additionalData.Insert( addtDataIndex, new Tuple<long, object>( -8, hashPadding ) );
                    addtDataIndex++;
                    if ( addtDataIndex >= additionalData.Count ) {
                        additionalData.Add( hmData );
                    } else {
                        additionalData.Insert( addtDataIndex, hmData );
                    }
                    addtDataIndex++;
                    break;
                case "EmptyNode":
                    break;

                case "NMSTemplate":
                    writer.Align( 8, field?.Name ?? fieldType.Name, paddingByte );
                    long refPos = writer.BaseStream.Position;

                    NMSTemplate template = (NMSTemplate) fieldData;
                    if ( template == null || template.GetType().Name == "EmptyNode" ) {
                        writer.Write( (long) 0 ); // listPosition
                        writer.Write(0); // NameHash
                        writer.Write(0xEEEEEE01);
                    } else {
                        writer.Write( (Int64) 0 );      // default value to be overridden later anyway
                        uint NameHash = template.GetType().GetCustomAttribute<NMSAttribute>()?.NameHash ?? 0;
                        writer.Write(NameHash);
                        writer.Write(0xEEEEEE01);

                        var data = new Tuple<long, object>( refPos, template );
                        if ( addtDataIndex >= additionalData.Count ) {
                            additionalData.Add( data );
                        } else {
                            additionalData.Insert( addtDataIndex, data );
                        }
                        addtDataIndex++;
                    }
                    break;
                default:
                    if (typeof(INMSVariableLengthString).IsAssignableFrom(fieldType)) {
                        writer.Align( 0x8, field?.Name ?? fieldType.Name, paddingByte );
                        // write empty DynamicString header
                        long fieldPos = writer.BaseStream.Position;
                        writer.Write( (Int64) 0 ); // listPosition
                        writer.Write( (Int32) 0 ); // String length
                        writer.Write( listEnding );
                        var fieldValue = (INMSVariableLengthString) fieldData;
                        if (fieldType.Name == "VariableSizeString" && (fieldValue == null || fieldValue.String == "" || fieldValue.String == null)) {
                            // Do nothing since in this case we don't want to insert anything...
                        } else if (fieldType.Name == "HashedString") {
                            // Write some extra fields.
                            HashedString _fieldValue = (HashedString)fieldValue;
                            writer.Write(_fieldValue.Hash());
                            writer.Write(0xAAAAAAAA);
                            additionalData.Insert( addtDataIndex++, new Tuple<long, object>( fieldPos, fieldValue ) );
                        }
                        else {
                            additionalData.Insert( addtDataIndex++, new Tuple<long, object>( fieldPos, fieldValue ) );
                        }
                    } else if ( fieldType.IsArray ) {
                        Type arrayType = fieldType.GetElementType();
                        Array array = (Array) fieldData;
                        int length = GetEnumNames( field.Name, settings ).Length;
                        if ( array == null ) array = Array.CreateInstance( arrayType, length );

                        foreach ( var obj in array ) {
                            long fieldPos = writer.BaseStream.Position;
                            var realObj = obj;
                            if ( realObj == null ) realObj = Activator.CreateInstance( arrayType );
                            SerializeValue( writer, realObj.GetType(), realObj, realObj.GetType().GetCustomAttribute<NMSAttribute>(), field, ref additionalData, ref addtDataIndex, listEnding, paddingByte );
                        }
                    } else if ( fieldType.IsEnum ) {
                        Type enumType = Enum.GetUnderlyingType(field.FieldType);
                        writer.Align( AlignOf(enumType), field?.Name ?? fieldType.Name, paddingByte );
                        if (enumType.Name == "UInt32") {
                            writer.Write((uint)Enum.Parse(field.FieldType, fieldData.ToString()));
                        } else if (enumType.Name == "UInt16") {
                            writer.Write((ushort)Enum.Parse(field.FieldType, fieldData.ToString()));
                        } else if (enumType.Name == "Byte") {
                            writer.Write((byte)Enum.Parse(field.FieldType, fieldData.ToString()));
                        } else {
                            // Fall back to int parsing just in case the enum has no type specified.
                            writer.Write((int)Enum.Parse(field.FieldType, fieldData.ToString()));
                        }

                    } else if ( fieldType.BaseType == typeof( NMSTemplate ) ) {
                        var realData = (NMSTemplate) fieldData;
                        if ( realData == null ) realData = (NMSTemplate) Activator.CreateInstance( fieldType );
                        writer.Align( AlignOf(realData.GetType()), field?.Name ?? fieldType.Name, paddingByte );
                        realData.AppendToWriter( writer, ref additionalData, ref addtDataIndex, GetType(), listEnding, paddingByte );
                    } else {
                        throw new UnknownTypeException( fieldType, field?.Name );
                    }
                    break;
            }
        }

        public void AppendToWriter( BinaryWriter writer, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex, Type parent, UInt32 listEnding = 0xAAAAAA01, byte paddingByte = 0 ) {
            long templatePosition = writer.BaseStream.Position;
            #if DEBUG_TEMPLATE
            Logger.LogDebug( $"[C] writing {GetType().Name} to offset 0x{templatePosition:X} (parent: {parent.Name})" );
            #endif
            var type = GetType();
            var fields = type.GetFields().OrderBy( field => field.MetadataToken ); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            if ( type.Name != "EmptyNode" ) {
                foreach ( var field in fields ) {
                    var fieldAddr = writer.BaseStream.Position - templatePosition;      // location of the data within the struct
                    //Logger.LogDebug($"fieldAddr: 0x{fieldAddr:X}, templatePos: 0x{templatePosition:X}, name: {field.FieldType.Name}, value: {field.GetValue(this)}");
                    NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                    var fieldData = field.GetValue(this);
                    SerializeValue( writer, field.FieldType, fieldData, settings, field, ref additionalData, ref addtDataIndex, listEnding, paddingByte );
                }
                writer.Align( AlignOf(type), type.Name, paddingByte ); // This is to remove the need for end padding
            } else {
                SerializeValue( writer, type, null, null, null, ref additionalData, ref addtDataIndex, listEnding, paddingByte );
            }
        }

        public void SerializeGenericList( BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData, int addtDataIndex, UInt32 listEnding, byte paddingByte = 0 )
        // This serialises a List of NMSTemplate objects
        {
            writer.Align( 0x8, list.GetType().Name, paddingByte );       // Make sure that all c~ names are offset at 0x8.
            long listPosition = writer.BaseStream.Position;

            DebugLogTemplate( $"SerializeList\tstart:\t{$"0x{listPosition - MBINHeader.HEADER_SIZE:X},",-10}\theader:\t{$"0x{listHeaderPosition - MBINHeader.HEADER_SIZE:X},",-10}\tcount:\t{list.Count}");

            writer.BaseStream.Position = listHeaderPosition;

            // write the list header into the template
            if ( list.Count > 0 ) {
                //DebugLog($"SerializeList start 0x{listPosition:X}, header 0x{listHeaderPosition:X}");
                writer.Write( listPosition - listHeaderPosition );
            } else {
                writer.Write( (long) 0 ); // lists with 0 entries have offset set to 0
            }

            writer.Write( (Int32) list.Count );
            writer.Write( listEnding );

            // reserve space for list offsets + name hash
            writer.BaseStream.Position = listPosition;
            writer.Write( new byte[list.Count * 0x10] );              // this seems to need to be reserved even if there are no elements (check?)

            //var entryOffsetNamePairs = new Dictionary<long, string>();
            List<KeyValuePair<long, String>> entryOffsetNamePairs = new List<KeyValuePair<long, String>>();
            foreach ( var entry in list ) {
                int addtDataIndexThis = 0;
                string entryName = entry.GetType().Name;
                writer.Align( AlignOf(entry.GetType()), entryName, paddingByte );
                entryOffsetNamePairs.Add( new KeyValuePair<long, string>( writer.BaseStream.Position, entryName) );

                var template = (NMSTemplate) entry;
                var listObjects = new List<Tuple<long, object>>();     // new list of objects so that this data is serialised first
                var addtData = new Dictionary<long, object>();
                #if DEBUG_TEMPLATE
                Logger.LogDebug( $"[C] writing {template.GetType().Name} to offset 0x{writer.BaseStream.Position:X}" );
                #endif
                // pass the new listObject object in place of additionalData so that this branch is serialised before the whole layer
                template.AppendToWriter( writer, ref listObjects, ref addtDataIndexThis, GetType(), paddingByte: paddingByte );
                for ( int i = 0; i < listObjects.Count; i++ ) {
                    var data = listObjects[i];
                    //writer.BaseStream.Position = additionalDataOffset; // addtDataOffset gets updated by child templates
                    if (typeof(INMSVariableLengthString).IsAssignableFrom(data.Item2.GetType())) {
                        var str = (INMSVariableLengthString) data.Item2;

                        long stringPos = writer.BaseStream.Position;
                        writer.WriteString( str.StringValue(), Encoding.UTF8, null, true, paddingByte );
                        long stringEndPos = writer.BaseStream.Position;

                        writer.BaseStream.Position = data.Item1;
                        writer.Write( stringPos - data.Item1 );
                        writer.Write( (Int32) (stringEndPos - stringPos) );
                        writer.Write( listEnding );

                        writer.BaseStream.Position = stringEndPos;
                    } else if ( data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof( List<> ) ) {
                        Type itemType = data.Item2.GetType().GetGenericArguments()[0];
                        if ( itemType == typeof( NMSTemplate ) ) {
                            SerializeGenericList( writer, (IList) data.Item2, data.Item1, ref listObjects, i + 1, listEnding, paddingByte );
                        } else {
                            SerializeList( writer, (IList) data.Item2, data.Item1, ref listObjects, i + 1, listEnding, paddingByte );
                        }
                    } else {
                        writer.Align( AlignOf(data.Item2.GetType()), data.Item2.GetType().Name, paddingByte );
                        long origPos = writer.BaseStream.Position;
                        // first, write the correct offset at the correct location
                        long headerPos = data.Item1;
                        writer.BaseStream.Position = headerPos;
                        long offset = origPos - headerPos;
                        writer.Write( offset );
                        writer.BaseStream.Position = origPos;
                        var GenericObject = data.Item2;
                        int newDataIndex = i + 1;
                        SerializeValue( writer, GenericObject.GetType(), GenericObject, null, null, ref listObjects, ref newDataIndex, listEnding, paddingByte );
                    }
                }

            }

            long dataEndOffset = writer.BaseStream.Position;

            writer.BaseStream.Position = listPosition;
            foreach ( KeyValuePair<long, string> kvp in entryOffsetNamePairs ) {
                // Iterate through the list headers and write the correct data
                if ( kvp.Value != "EmptyNode" ) {
                    writer.Align( 0x8, kvp.Value.GetType().Name, paddingByte );
                    // in this case, we have an actual non-empty header.
                    long position = writer.BaseStream.Position;
                    long offset = kvp.Key - position; // get offset of this entry from the current offset
                    writer.Write( offset );
                    // Get the NameHash
                    uint NameHash = GetTemplateType(kvp.Value)?.GetCustomAttribute<NMSAttribute>()?.NameHash ?? 0;
                    writer.Write(NameHash);
                    writer.Write(0xEEEEEE01);
                } else {
                    // this is called when the header 0x10 bytes is empty because it is an empty node.
                    // This does however have the ending 4 bytes which indicate a list, even though it's empty...
                    writer.WriteString("", Encoding.UTF8, 0xC, false, paddingByte);
                    writer.Write(0xEEEEEE01);
                }
            }

            writer.BaseStream.Position = dataEndOffset;
        }

        public void SerializeList( BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData, int addtDataIndex, UInt32 listEnding = 0xAAAAAA01, byte paddingByte = 0, bool writingHashMap = false  ) {
            // first thing we want to do is align the writer with the location of the first element of the list
            if ( list.Count != 0 ) {
                writer.Align( AlignOf(list[0].GetType()), list[0].GetType().Name, paddingByte );
            }

            long listPosition = writer.BaseStream.Position;
            //Logger.LogDebug( $"SerializeList\tstart:\t{$"0x{listPosition:X},",-10}\theader:\t{$"0x{listHeaderPosition:X},",-10}\tcount:\t{list.Count}" );

            writer.BaseStream.Position = listHeaderPosition;

            // write the list header into the template
            if ( list.Count > 0 ) {
                writer.Write( listPosition - listHeaderPosition );
            } else if ( list.Count == 0 && writingHashMap) {
                // For some reason an empty HashMap still has a size of 50...
                writer.Write( 0x50 );
            } else {
                writer.Write( (long) 0 ); // lists with 0 entries have offset set to 0
            }
            writer.Write( (Int32) list.Count );
            if (!writingHashMap) writer.Write( listEnding );

            writer.BaseStream.Position = listPosition;

            var listObjects = new List<Tuple<long, object>>();     // new list of objects so that this data is serialised first

            int addtDataIndexThis = addtDataIndex;

            foreach ( var entry in list ) {
                #if DEBUG_TEMPLATE
                DebugLogTemplate( $"[C] writing {entry.GetType().Name} to offset 0x{writer.BaseStream.Position:X}" );
                #endif
                SerializeValue( writer, entry.GetType(), entry, null, null, ref additionalData, ref addtDataIndexThis, listEnding, paddingByte );
            }
        }

        public byte[] SerializeBytes() {
            using ( var stream = new MemoryStream() )
            using ( var writer = new BinaryWriter( stream, Encoding.ASCII ) ) {
                var additionalData = new List<Tuple<long, object>>();

                UInt32 listEnding = 0xAAAAAA01;
                List<long> listOrder = new List<long>{};
                bool reorderList = false;
                byte paddingByte = 0;

                // Note: The list reorderings are determined by hand for the two cases.
                // This is done by looking at the order it should be in, and then writing the sequences of
                // indexes which specify what index to put in the current spot.

                if ( GetType() == typeof( NMS.Toolkit.TkAnimMetadata ) ) {
                    listEnding = 0xFEFEFE01;
                    listOrder = new List<long>{0x40, 0x30, 0x00, 0x10, 0x20};
                    reorderList = true;
                    paddingByte = 0xFE;
                } else if ( GetType() == typeof( NMS.Toolkit.TkGeometryStreamData ) || GetType() == typeof( NMS.Toolkit.TkGeometryData ) ) {
                    listEnding = 0x00000001;
                    paddingByte = 0xFE;
                    if (GetType() == typeof( NMS.Toolkit.TkGeometryData )) {
                        // TODO: Figure out new version...
                        listOrder = new List<long>{
                            0x100, 0xF0, 0xD0, 0xC0, 0x60, 0x40, 0x50, 0x80, 0x110, 0xE0, 0xB0, 0xA0, 0x90, 0x20, 0x00, 0x70, 0x120
                        };
                        reorderList = true;
                    }
                }

                int i = 0;
                // write primary template + any embedded templates
                AppendToWriter( writer, ref additionalData, ref i, GetType(), listEnding, paddingByte );

                // now write values of lists etc

                // Reorder the list if it's required.
                // This generally isn't but Animation and Geometry files are in "MXML-order", so we need to fix them.
                if (reorderList) {
                    additionalData.Sort((x, y) => listOrder.IndexOf(x.Item1).CompareTo(listOrder.IndexOf(y.Item1)));
                }

                for ( i = 0; i < additionalData.Count; i++ ) {
                    var data = additionalData[i];
                    //DebugLog($"Current i: {i}");
                    //DebugLog(data);
                    //writer.BaseStream.Position = additionalDataOffset; // addtDataOffset gets updated by child templates

                    if ( data.Item2 == null ) {
                        SerializeList( writer, new List<int>(), data.Item1, ref additionalData, i + 1, listEnding, paddingByte );  // pass an empty list. Data type doesn't matter...
                        continue;
                    }

                    NMSAttribute attributes = data.Item2?.GetType().GetCustomAttribute<NMSAttribute>();

                    if ( typeof(INMSVariableLengthString).IsAssignableFrom(data.Item2.GetType()) ) {
                        var str = (INMSVariableLengthString) data.Item2;
                        #if DEBUG_TEMPLATE
                        Logger.LogDebug($"[C+] Writing {str.StringValue()} to 0x{writer.BaseStream.Position:X}");
                        #endif
                        long stringPos = writer.BaseStream.Position;
                        writer.WriteString(str.StringValue(), Encoding.UTF8, null, true, paddingByte);
                        long stringEndPos = writer.BaseStream.Position;

                        writer.BaseStream.Position = data.Item1;
                        writer.Write(stringPos - data.Item1);
                        writer.Write((Int32) (stringEndPos - stringPos));
                        writer.Write(listEnding);

                        writer.BaseStream.Position = stringEndPos;
                    } else if ( data.Item2.GetType().BaseType == typeof( NMSTemplate ) ) {
                        // HashMap's look like this. We'll serialize them like a list though...
                        if (data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof(HashMap<>)) {
                            SerializeList( writer, (IList) ((IHashMap)data.Item2).GetElements(), data.Item1, ref additionalData, i + 1, listEnding, paddingByte, true );
                            continue;
                        }
                        writer.Align( AlignOf(data.Item2.GetType()), data.Item2.GetType().Name, paddingByte );
                        long pos = writer.BaseStream.Position;
                        var template = (NMSTemplate) data.Item2;
                        int i2 = i + 1;
                        template.AppendToWriter( writer, ref additionalData, ref i2, GetType(), listEnding, paddingByte );
                        long endPos = writer.BaseStream.Position;
                        writer.BaseStream.Position = data.Item1;
                        writer.Write( pos - data.Item1 );
                        uint NameHash = attributes?.NameHash ?? 0;
                        writer.Write(NameHash);
                        writer.Write(0xEEEEEE01);
                        writer.BaseStream.Position = endPos;
                    } else if ( data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof( List<> ) ) {
                        // this will serialise a dynamic length list of either a generic type, or a specific type
                        Type itemType = data.Item2.GetType().GetGenericArguments()[0];
                        if ( itemType == typeof( NMSTemplate ) ) {
                            // this is serialising a list of generic type
                            SerializeGenericList( writer, (IList) data.Item2, data.Item1, ref additionalData, i + 1, listEnding, paddingByte );
                        } else {
                            // This is serialising a list of a particular type
                            SerializeList( writer, (IList) data.Item2, data.Item1, ref additionalData, i + 1, listEnding, paddingByte );
                        }

                    } else if ( data.Item2.GetType() == typeof( byte[] ) ) {
                        // write the offset in the list header
                        long dataPosition = writer.BaseStream.Position;
                        if (data.Item1 >= 0) {
                            writer.BaseStream.Position = data.Item1;
                            writer.Write( dataPosition - data.Item1 );
                            writer.BaseStream.Position = dataPosition;
                        } else {
                            // We'll use the absolute value of the "position" as the alignment value as a lazy hack...
                            writer.Align((int)Math.Abs(data.Item1), data.Item2.GetType().Name, paddingByte);
                        }
                        SerializeValue( writer, data.Item2.GetType(), data.Item2, attributes, null, ref additionalData, ref i, paddingByte: paddingByte );     // passing i here *should* be fine as we will only be writing bytes which can't affect i

                    } else {
                        throw new UnknownTypeException( data.Item2.GetType() );

                    }

                }

                return stream.ToArray();
            }
        }
        
        /// <summary>
        /// .
        /// </summary>
        /// <param name="fieldType">The field type of the field.</param>
        /// <param name="field">A field.</param>
        /// <param name="settings">The settings of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="IncludeTypeInfo">If true, type info is written to the MXML file.</param>
        public MXmlBase SerializeMXmlValue(Type fieldType, FieldInfo field, NMSAttribute settings, object value, bool IncludeTypeInfo)
        {
            string t = fieldType.Name;
            int i = 0;
            string valueString = String.Empty;

            string fieldName = field.GetCustomAttribute<NMSAttribute>()?.MxmlName ?? field.Name;

            switch (fieldType.Name)
            {
                case "String":
                case "Boolean":
                case "Byte":
                case "SByte":
                case "Int16":
                case "UInt16":
                case "Int32":
                case "UInt32":
                case "Int64":
                case "UInt64":
                    valueString = value?.ToString() ?? "";
                    if (fieldType.Name == "Boolean") valueString = valueString.ToLower();
                    if (fieldType.Name != "Int32") break;

                    if ((int) value == -1 ) break;

                    break;
                case "Single":
                    // prefer the default, short-form string format
                    valueString = ((float) value).ToString( "0.000000", System.Globalization.CultureInfo.InvariantCulture);
                    if ( float.Parse( valueString ) != (float) value ) { // the default string format may not be accurate
                        // if it's not accurate enough, then use the full-precision format
                        valueString = ((float) value).ToString( "G9", System.Globalization.CultureInfo.InvariantCulture );
                    }
                    break;
                case "Double":
                    // prefer the default, short-form string format
                    valueString = ((double) value).ToString( System.Globalization.CultureInfo.InvariantCulture);
                    if ( double.Parse( valueString ) != (double) value ) { // the default string format may not be accurate
                        // if it's not accurate enough, then use the full-precision format
                        valueString = ((double) value).ToString( "G17", System.Globalization.CultureInfo.InvariantCulture );
                    }
                    break;
                case "Byte[]":
                    valueString = value == null ? null : Convert.ToBase64String((byte[])value);
                    break;
                case "GcSeed":
                    GcSeed seed = (GcSeed)value;
                    valueString = (seed.Seed == 0 && !seed.UseSeedValue) ? "NONE" : seed.Seed.ToString();
                    break;
                case "GcResource":
                    // Don't return anything. We won't write this to MXML since the data is only used internally
                    // and isn't serialized by the game either.
                    return null;
                case "Colour32":
                    // Handle the Colour32 explicitly since we want to write floats to the MXML, not ints.
                    Colour colour = new Colour((Colour32)value);
                    MXmlProperty colour_field = (MXmlProperty)colour.SerializeMXml( true, false, IncludeTypeInfo );
                    colour_field.Name = fieldName;
                    return colour_field;
                case "LinkableNMSTemplate":
                    LinkableNMSTemplate linkedTemplate = (LinkableNMSTemplate) value;
                    if (linkedTemplate.Template != null) {
                        MXmlProperty templateXmlData = (MXmlProperty)linkedTemplate.Template.SerializeMXml( true, true, IncludeTypeInfo );
                        templateXmlData.Name = fieldName;
                        templateXmlData.Value = linkedTemplate.Template.GetType().Name;
                        if (linkedTemplate.Linked.StringValue() != "") {
                            templateXmlData.Linked = linkedTemplate.Linked.StringValue();
                        }
                        return templateXmlData;
                    } else {
                        MXmlProperty linkedProp = new MXmlProperty()
                        {
                            Name = fieldName,
                        };
                        return linkedProp;
                    }
                case "List`1":
                    var listType = field.FieldType.GetGenericArguments()[0];
                    MXmlProperty listProperty = new MXmlProperty {
                        Name = fieldName
                    };

                    IList templates = (IList)value;
                    if ( templates != null ) {
                        i = 0;
                        if ( typeof(INMSString).IsAssignableFrom(listType) ) {
                            // For lists of strings, just write the data directly.
                            foreach ( var template in templates ) {
                                MXmlProperty data = new MXmlProperty {
                                    Name = fieldName,
                                    Value = ((INMSString)template).StringValue(),
                                    Index = i.ToString()
                                };
                                listProperty.Elements.Add( data );
                                i++;
                            }
                        } else {
                            Dictionary<string, uint> IdCounter = new Dictionary<string, uint>{};
                            foreach ( var template in templates ) {
                                MXmlProperty data = (MXmlProperty)SerializeMXmlValue( listType, field, settings, template, IncludeTypeInfo );
                                data.Name = fieldName;
                                string typeIdField = TypeHasID(listType);
                                if (typeIdField != null) {
                                    MXmlProperty IdData = (MXmlProperty)data.Elements.Where(
                                        element => element.Name == typeIdField
                                    ).First();
                                    if (IdData != null) {
                                        data.ID = IdData.Value;
                                        if (!IdCounter.ContainsKey(IdData.Value)) {
                                            IdCounter.Add(IdData.Value, 1);
                                        } else if (!(listType == typeof(NMSTemplate) || listType == typeof(LinkableNMSTemplate))) {
                                            data.Index = IdCounter[IdData.Value].ToString();
                                            IdCounter[IdData.Value] = IdCounter[IdData.Value] + 1;
                                        }
                                    }
                                } else if (!(listType == typeof(NMSTemplate) || listType == typeof(LinkableNMSTemplate))) {
                                    data.Index = i.ToString();
                                }
                                listProperty.Elements.Add( data );
                                i++;
                            }
                        }
                    }

                    return listProperty;
                case "NMSTemplate":
                    if ( value != null ) {
                        NMSTemplate template = (NMSTemplate) value;

                        MXmlProperty templateXmlData = (MXmlProperty)template.SerializeMXml( true, true, IncludeTypeInfo );
                        templateXmlData.Name = fieldName;
                        templateXmlData.Value = template.GetType().Name;

                        return templateXmlData;
                    }
                    return null;
                default:
                    if (typeof(INMSString).IsAssignableFrom(fieldType))
                    {
                        // We will shortcut the deserialization by simply assigning the value
                        valueString = ((INMSString)value).StringValue();
                        break;
                    }
                    if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(HashMap<>)){
                        var instance = Activator.CreateInstance(fieldType);
                        Type hashMapType = field.FieldType.GetGenericArguments()[0];

                        // We basically treat the hashmap as an enumerable (so like a List<T>).
                        MXmlProperty listProp = new MXmlProperty { Name = fieldName };

                        // Get the name of the field which is used as the id so we can extract it out of the deserialized data in a few lines.
                        string id_field = field.GetCustomAttribute<NMSAttribute>()?.KeyField ?? "";

                        foreach ( var template in (IEnumerable)value ) {
                            MXmlProperty data = (MXmlProperty)SerializeMXmlValue( hashMapType, field, settings, template, IncludeTypeInfo );

                            // Get aforementioned id field and write to the `_id` attribute.
                            MXmlProperty IdData = (MXmlProperty)data.Elements.Where(
                                element => element.Name == id_field
                            ).First();
                            if (IdData != null) {
                                data.ID = IdData.Value;
                            }

                            listProp.Elements.Add( data );
                        }
                        return listProp;

                    }
                    if ( fieldType.BaseType.Name == "NMSTemplate" ) {
                        NMSTemplate template;
                        if ( value is null ) {
                            template = TemplateFromName( fieldType.Name );
                        } else {
                            template = (NMSTemplate) value;
                        }
                        var templateXmlData = template.SerializeMXml( true, false, IncludeTypeInfo );
                        templateXmlData.Name = fieldName;

                        return templateXmlData;
                    } else if ( fieldType.IsArray ) {
                        var arrayType = field.FieldType.GetElementType();
                        MXmlProperty arrayProperty = new MXmlProperty {
                            Name = fieldName
                        };

                        if (IncludeTypeInfo) {
                            arrayProperty.ArraySize = field.GetCustomAttribute<NMSAttribute>()?.Size.ToString();
                        }

                        Array array = (Array) value;
                        string[] names = GetEnumNames( field.Name, array.Length, settings );
                        i = 0;
                        foreach ( var template in array ) {
                            MXmlProperty data = (MXmlProperty)SerializeMXmlValue( arrayType, field, settings, template, IncludeTypeInfo );
                            // Only change the name if we have an associated enum.
                            string overwriteName = names[i];
                            if (overwriteName != null && overwriteName != "") {
                                data.Name = overwriteName;
                            } else {
                                data.Index = i.ToString();
                            }

                            arrayProperty.Elements.Add( data );
                            i++;
                        }

                        return arrayProperty;
                    } else if ( fieldType.IsEnum ) {
                        valueString = value?.ToString();
                        break;
                    } else {
                        throw new UnknownTypeException( field.FieldType, field.Name );
                    }
            }

            return new MXmlProperty {
                Name = fieldName,
                Value = valueString
            };
        }

        /// <summary>
        /// Gets an array of named indices for an EnumArray.
        /// If the field is not an EnumArray, the names of the indices will be null.
        /// </summary>
        private static string[] GetEnumNames( string fieldName, NMSAttribute settings ) {
            return GetEnumNames( fieldName, settings?.Size ?? 0, settings );
        }

        /// <summary>
        /// Gets an array of named indices for an EnumArray.
        /// If the field is not an EnumArray, the names of the indices will be null.
        /// </summary>
        private static string[] GetEnumNames( string fieldName, int arrayLength, NMSAttribute settings ) {
            // handle EnumArray names
            string[] names = new string[arrayLength]; // default is all nulls
            int length = 0;
            Type enumType = settings?.EnumType;
            if ( enumType != null ) { // has EnumType setting
                if ( !enumType.IsEnum ) {
                    throw new APIException( $"Invalid type: {enumType}\n" +
                                            $"The EnumType attribute for {fieldName} must be an Enum type!" );
                }
                names = Enum.GetNames( enumType );
                if (enumType.IsDefined(typeof(FlagsAttribute), inherit: false)) {
                    // For flag types, we don't want the first element.
                    List<string> list = new List<string>(names);
                    list.RemoveAt(0); // Removes the element at index 0 (the first element)
                    names = list.ToArray();
                }
                length = names.Length;
            }

            if ( (length == 0) && (arrayLength == 0) ) {
                // Invalid, can't determine array size
                throw new APIException( $"The array {fieldName} must have an NMSAttribute with a Size or EnumType setting" );

            } else if ( length != 0 ) {
                // Validate that length matches, unless arrayLength is 0 (auto/don't care)
                if ( (arrayLength != 0) && (arrayLength != length) ) {
                    string enumTypeName = enumType?.ToString() ?? "EnumValue";
                    EmitWarning( $"The defined Size for {fieldName} does not match the length of {enumTypeName}!\n" +
                                            $"{"0x" + arrayLength.ToString("X")} != {"0x" + length.ToString("X")}" );
                }
            }

            return names;
        }

        private static void EmitWarning( string msg ) {
            #if DEBUG
                throw new APIException( msg );
            #else
                Logger.LogWarning( msg + "\nThis is NOT an issue with your MBIN or MXML file and can be ignored.\nIf you are seeing this message however, please report it.");
            #endif
        }

        private static void EmitError( string msg ) {
            #if DEBUG
                throw new APIException( msg );
            #else
                Logger.LogError( msg );
            #endif
        }

        private static int GetArrayLength( string fieldName, NMSAttribute settings ) {
            return GetEnumNames( fieldName, settings ).Length;
        }

        /// <summary>
        /// .
        /// </summary>
        /// <param name="isChildTemplate">If true, </param>
        /// <param name="isGenericTemplate">If true, </param>
        /// <param name="IncludeTypeInfo">If true, type info is written to the MXML file.</param>
        public MXmlBase SerializeMXml(bool isChildTemplate, bool isGenericTemplate = false, bool IncludeTypeInfo = false) {
            Type type = GetType();
            string typeName = type.Name != "NMSString0x20A" ? type.Name : "NMSString0x20";
            MXmlBase xmlData = new MXmlProperty {};
            // Only add the type as a value if we need to.
            if (!FakeTypes.Contains(typeName)) {
                ((MXmlProperty)xmlData).Value = typeName;
            }
            MXmlBase subElement = null;
            if ( isGenericTemplate ) {
                xmlData = new MXmlProperty { Name = typeName };
                subElement = new MXmlProperty { Name = typeName };
                xmlData.Elements.Add(subElement);
            }

            if ( !isChildTemplate ) {
                xmlData = new MXmlData { Template = "c" + type.Name };
            }

            var fields = type.GetFields().OrderBy(field => field.GetCustomAttribute<NMSAttribute>()?.Index ?? field.MetadataToken); // Order fields in declared order

            foreach ( var field in fields ) {
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                settings ??= new NMSAttribute();
                if ( settings.Ignore ) continue;
                if ( field.IsInitOnly ) continue;

                if ( isGenericTemplate ) {
                    subElement.Elements.Add( SerializeMXmlValue( field.FieldType, field, settings, field.GetValue( this ), IncludeTypeInfo ) );
                } else {
                    xmlData.Elements.Add( SerializeMXmlValue( field.FieldType, field, settings, field.GetValue( this ), IncludeTypeInfo ) );
                }
            }

            return xmlData;
        }

        public static object DeserializeMXmlValue(MXmlProperty xmlProperty, NMSTemplate template, Type fieldType, FieldInfo field, Type templateType, NMSAttribute settings)
        {
            switch (fieldType.Name)
            {
                case "String":
                    return xmlProperty.Value;
                case "Single":
                    return float.Parse(xmlProperty.Value);
                case "Double":
                    return double.Parse(xmlProperty.Value);
                case "Boolean":
                    return bool.Parse(xmlProperty.Value);
                case "Byte":
                    return byte.Parse(xmlProperty.Value);
                case "SByte":
                    return sbyte.Parse(xmlProperty.Value);
                case "Int16":
                    return short.Parse(xmlProperty.Value);
                case "UInt16":
                    return ushort.Parse(xmlProperty.Value);
                case "Int32":
                    var valuesMethod = templateType.GetMethod(field.Name + "Values");

                    if ( valuesMethod != null ) {
                        if ( String.IsNullOrEmpty( xmlProperty.Value ) ) return -1;

                        string[] values = (string[]) valuesMethod.Invoke( template, null );
                        return Array.FindIndex( values, v => v == xmlProperty.Value );
                    } else {
                        return int.Parse( xmlProperty.Value );
                    }
                case "UInt32":
                    return uint.Parse(xmlProperty.Value);
                case "Int64":
                    return long.Parse(xmlProperty.Value);
                case "UInt64":
                    return ulong.Parse(xmlProperty.Value);
                case "Byte[]":
                    return xmlProperty.Value == null ? null : Convert.FromBase64String(xmlProperty.Value);
                case "GcSeed":
                    string value = xmlProperty.Value;
                    if (value == "NONE") {
                        return new GcSeed { Seed = 0, UseSeedValue = false};
                    } else {
                        return new GcSeed { Seed = ulong.Parse(xmlProperty.Value), UseSeedValue = true};
                    }
                case "List`1":
                case "HashMap`1":
                    Type elementType = fieldType.GetGenericArguments()[0];
                    IList list = null;
                    if (fieldType.Name == "HashMap`1") {
                        Type listType = typeof(List<>);
                        Type hmType = listType.MakeGenericType(elementType);
                        list = (IList)Activator.CreateInstance(hmType);
                    } else {
                        list = (IList)Activator.CreateInstance(fieldType);
                    }
                    foreach (var innerXmlData in xmlProperty.Elements) // child templates
                    {
                        object element = null;
                        MXmlProperty data = innerXmlData as MXmlProperty;


                        if (ValueSerializable(elementType)) {
                            element = DeserializeMXmlValue(data, template, elementType, field, templateType, settings);
                        } else {
                            Type listType = elementType;
                            if (elementType == typeof(NMSTemplate) || elementType == typeof(LinkableNMSTemplate)) {
                                // Read the type from the "value"

                                string genericType = data.Value;
                                if (genericType != null) {
                                    listType = GetTemplateType(genericType);
                                    data = (MXmlProperty)innerXmlData.Elements[0];
                                } else {
                                    if (innerXmlData.Elements.Count == 0) {
                                        // In this case we have a dummy template... :/
                                        if (elementType == typeof(NMSTemplate)) {
                                            element = new NMSTemplate();
                                        } else {
                                            element = new LinkableNMSTemplate {Template = null, Linked = ""};
                                        }
                                        list.Add(element);
                                        continue;
                                    } else {
                                        // TODO: Throwing this doesn't actually help....
                                        Console.WriteLine("Unable to determine the type of a generic template...");
                                        throw new UnknownGenericTypeException(data.Name);
                                    }
                                }
                            }
                            element = DeserializeMXml(data, listType);

                            string linked = null;
                            // Need to handle the LinkableNMSTemplate in a special way to let the list be created...
                            if (elementType == typeof(LinkableNMSTemplate)) {
                                // Get the linked attribute if there is one...
                                linked = ((MXmlProperty)innerXmlData).Linked;
                                element = new LinkableNMSTemplate
                                {
                                    Template = (NMSTemplate)element,
                                    Linked = linked,
                                };
                            }
                            
                        }
                        // } else if (type == typeof(MXmlMeta)) {
                        //     DebugLogComment(((MXmlMeta)innerXmlData).Comment);
                        // }

                        if ( element == null) throw new TemplateException( "element == null ??!" );

                        list.Add(element);
                    }
                    return list;
                default:
                    if (typeof(INMSString).IsAssignableFrom(fieldType))
                    {
                        object stringObj = (INMSString)Activator.CreateInstance(fieldType);
                        FieldInfo valueField = stringObj.GetType().GetField("Value");
                        valueField.SetValue(stringObj, xmlProperty.Value);
                        return stringObj;
                    }
                    if (field.FieldType.IsArray) {
                        int length = GetArrayLength( field.Name, settings );
                        Type arrayType = field.FieldType.GetElementType();
                        Array array = Array.CreateInstance(arrayType, length);
                        List<MXmlBase> data = xmlProperty.Elements.ToList();
                        int numMeta = 0;
                        bool valueSerializable = ValueSerializable(arrayType);

                        for (int i = 0; i < data.Count; ++i) {
                            if (data[i].GetType() == typeof(MXmlProperty)) {
                                object element = null;
                                if (valueSerializable) {
                                    element = DeserializeMXmlValue((MXmlProperty)data[i], template, arrayType, field, templateType, settings);
                                } else {
                                    element = DeserializeMXml(data[i], arrayType);
                                }
                                array.SetValue(element, i - numMeta);
                            } else if (data[i].GetType() == typeof(MXmlMeta)) {
                                DebugLogComment(((MXmlMeta)data[i]).Comment);
                                numMeta += 1;           // increment so that the actual data is still placed at the right spot
                            }
                        }
                        return array;
                    } else if (field.FieldType.IsEnum) {
                        try {
                            Type enumType = Enum.GetUnderlyingType(field.FieldType);
                            if (enumType.Name == "UInt32") {
                                return (uint)Enum.Parse(field.FieldType, xmlProperty.Value);
                            } else if (enumType.Name == "UInt16") {
                                return (ushort)Enum.Parse(field.FieldType, xmlProperty.Value);
                            } else if (enumType.Name == "Byte") {
                                return (byte)Enum.Parse(field.FieldType, xmlProperty.Value);
                            } else {
                                // Fall back to int parsing just in case the enum has no type specified.
                                return (int)Enum.Parse(field.FieldType, xmlProperty.Value);
                            }
                        } catch (ArgumentException) {
                            // material flags can have a custom suffix
                            if ( field.FieldType == typeof( libMBIN.NMS.Toolkit.TkMaterialFlags.MaterialFlagEnum ) ) {
                                // if we got here, then we know that Value is an identifier and not an integer
                                // trim the custom suffix
                                return (int) Enum.Parse( field.FieldType, xmlProperty.Value.Substring( 0, 5 ) ); // "_FXX_"
                            } else {
                                throw new InvalidEnumValueException(xmlProperty.Value.ToString(), field);
                            }
                        }
                    } else {
                        return fieldType.IsValueType ? Activator.CreateInstance(fieldType) : null;
                    }
            }
        }

        public static NMSTemplate DeserializeMXml( MXmlBase xmlData, Type templateTypeKnown = null) {
            // This is the inital code that is run when converting mxml to mbin.
            // This code is run to parse over the mxml file and put it into a data structure that is processed by SerializeBytes()

            NMSTemplate template = null;
            Type templateType = null;

            if (templateTypeKnown != null) {
                if (templateTypeKnown != typeof(NMSTemplate)) {
                    template = TemplateFromType(templateTypeKnown);
                    templateType = templateTypeKnown;
                }
            } else {
                if ( xmlData.GetType() == typeof( MXmlData ) ) {
                    template = TemplateFromName( ((MXmlData) xmlData).Template[1..] );
                } else if ( xmlData.GetType() == typeof( MXmlProperty ) ) {
                    string value = ((MXmlProperty) xmlData).Value;
                    if (value == null && templateTypeKnown != null) {
                        template = TemplateFromName(templateTypeKnown.Name);
                    }
                } else if ( xmlData.GetType() == typeof( MXmlMeta ) ) {
                    DebugLogComment( ((MXmlMeta) xmlData).Comment );
                }
                if (template != null) {
                    templateType = template.GetType();
                }
            }

            if (template == null) return null;

            using ( var indentScope = new Logger.IndentScope() ) {
                // Loop over the child elements of the xml node.
                foreach ( var xmlElement in xmlData.Elements ) {
                    if ( xmlElement.GetType() == typeof( MXmlProperty ) ) {
                        MXmlProperty xmlProperty = (MXmlProperty) xmlElement;
                        string fieldName = xmlProperty.Name.Replace(" ", "");
                        if (char.IsNumber(fieldName[0])) {
                            fieldName = "_" + fieldName;
                        }
                        FieldInfo field = templateType.GetField(fieldName);
                        if (field == null) {
                            // The MXML file contains a field which is no longer in the class definition.
                            // Raise a more helpful error.
                            // TODO: Raise as an actual exception.
                            // Console.WriteLine($"[ERROR] The field '{xmlProperty.Name}' no longer exists in the class '{templateType.Name}'");
                            EmitError($"The field '{xmlProperty.Name}' no longer exists in the class '{templateType.Name}'");
                        }
                        object fieldValue = null;
                        Type fieldType = field.FieldType;

                        // Deserialize the field type from MXML to some value.
                        if (
                            (fieldType == typeof( NMSTemplate ) || fieldType.BaseType == typeof( NMSTemplate ))
                            && !typeof(INMSString).IsAssignableFrom(fieldType)
                            && fieldType != typeof(GcSeed)
                            && !(fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(HashMap<>))
                        ) {
                            if (fieldType == typeof(NMSTemplate) || fieldType == typeof(LinkableNMSTemplate)) {
                                // Read the type from the "value"
                                Type genericTemplateType = GetTemplateType(xmlProperty.Value);
                                // Pass in the first element of the child elements due to how they are serialized.
                                fieldValue = DeserializeMXml(xmlProperty.Elements[0], genericTemplateType);
                            } else {
                                fieldValue = DeserializeMXml(xmlProperty, fieldType);
                            }
                        } else {
                            NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                            if (templateType == typeof(Colour32)) {
                                // We have written `Colour32` fields to MXML as float, so we have to read them back specially.
                                fieldValue = (byte)(255f * (float)DeserializeMXmlValue( xmlProperty, template, typeof(float), field, templateType, settings ));
                            } else {
                                fieldValue = DeserializeMXmlValue( xmlProperty, template, fieldType, field, templateType, settings );
                            }
                        }

                        if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(HashMap<>)) {
                            // For the HashMap we need to do some funky stuff to get the actual object by constructing it and passing in the List<T>
                            // of data.
                            // This would be easier if we could cast, but not sure how to do that with generics...
                            var constructors = fieldType.GetConstructors(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                            ConstructorInfo ctor = null;
                            foreach (ConstructorInfo constr in constructors) {
                                // IMPORTANT: If the HashMap class gets any more constructors this may break...
                                if (constr.GetParameters().Length == 1) {
                                    ctor = constr;
                                }
                            }
                            if (ctor != null) {
                                var hashmap = ctor.Invoke(new object[] { fieldValue } );
                                field.SetValue( template, hashmap );
                            }
                        } else {
                            field.SetValue( template, fieldValue );
                        }
                    } else if ( xmlElement.GetType() == typeof( MXmlData ) ) {
                        // TODO: This will never be hit as we never have data child elements
                        MXmlData innerXmlData = (MXmlData) xmlElement;
                        FieldInfo field = templateType.GetField( innerXmlData.Name.Replace(" ", "") );
                        NMSTemplate innerTemplate = DeserializeMXml( innerXmlData );
                        field.SetValue( template, innerTemplate );
                    } else if ( xmlElement.GetType() == typeof( MXmlMeta ) ) {
                        MXmlMeta xmlMeta = (MXmlMeta) xmlElement;
                        string comment = xmlMeta.Comment;
                        DebugLogComment( comment );
                    }
                }

            }

            return template;
        }
        
        /// <summary>
        /// Serialises the NMSTemplate object to a .mbin file with default header information.
        /// </summary>
        /// <param name="outputpath">The location to write the .mbin file.</param>
        public void WriteToMbin(string outputpath)
        {
            using (var file = new MBINFile(outputpath))
            {
                file.Header = new MBINHeader();
                var type = this.GetType();
                file.Header.SetDefaults(type);
                file.SetData(this);
                file.Save();
            }
        }

        /// <summary>
        /// Writes the NMSTemplate object to an .mxml file.
        /// </summary>
        /// <param name="outputpath">The location to write the .mxml file.</param>
        /// <param name="hideVersionInfo">If true, version info is not written to the MXML file.</param>
        /// <param name="IncludeTypeInfo">If true, type info is written to the MXML file.</param>
        public void WriteToMxml(string outputpath, bool hideVersionInfo, bool IncludeTypeInfo)
        {
            var data = MXmlFile.WriteTemplate(this, hideVersionInfo, IncludeTypeInfo);
            File.WriteAllText(outputpath, data);
        }

        // func thats run after template is deserialized, can be used for checks etc
        public void FinishDeserialize() { }

        public virtual object CustomDeserialize( BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo ) {
            return null;
        }

        public virtual bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
        {
            return false;
        }
    }
}
