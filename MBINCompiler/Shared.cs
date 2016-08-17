using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace MBINCompiler
{
    static class Shared
    {
        public static NMSTemplate TemplateFromName(string templateName)
        {
            switch (templateName)
            {
                case "MBINHeader":
                    return new MBINHeader();
                case "GcHUDComponent":
                    return new GcHUDComponent();
                case "GcHUDLayerData":
                    return new GcHUDLayerData();
                case "GcHUDImageData":
                    return new GcHUDImageData();
                case "GcTextPreset":
                    return new GcTextPreset();
                case "GcHUDTextData":
                    return new GcHUDTextData();
                case "GcEntitlementRewardsTable":
                    return new GcEntitlementRewardsTable();
                case "GcEntitlementRewardData":
                    return new GcEntitlementRewardData();
                case "GcSceneSettings":
                    return new GcSceneSettings();
                case "NMSString0x80":
                    return new NMSString0x80();
                case "NMSString0x10":
                    return new NMSString0x10();
                case "GcInventoryType":
                    return new GcInventoryType();
                case "GcTechnologyRequirement":
                    return new GcTechnologyRequirement();
                case "GcStatsTypes":
                    return new GcStatsTypes();
                case "GcStatsBonus":
                    return new GcStatsBonus();
                case "GcTechnology":
                    return new GcTechnology();
                case "GcTechnologyTable":
                    return new GcTechnologyTable();
                case "VariableSizeString":
                    return new VariableSizeString();
                case "Colour":
                    return new Colour();
                case "GcAlienRace":
                    return new GcAlienRace();
                case "GcAlienSpeechEntry":
                    return new GcAlienSpeechEntry();
                case "GcAlienSpeechTable":
                    return new GcAlienSpeechTable();
                case "GcInteractionType":
                    return new GcInteractionType();
                case "GcAlienPuzzleOption":
                    return new GcAlienPuzzleOption();
                case "GcAlienPuzzleEntry":
                    return new GcAlienPuzzleEntry();
                case "GcAlienPuzzleTable":
                    return new GcAlienPuzzleTable();
                case "TkPaletteTexture":
                    return new TkPaletteTexture();
                case "GcHeavyAirSettingValues":
                    return new GcHeavyAirSettingValues();
                case "GcHeavyAirSetting":
                    return new GcHeavyAirSetting();
                case "GcFogProperties":
                    return new GcFogProperties();
                case "GcColourModifier":
                    return new GcColourModifier();
                case "GcWeatherColourModifiers":
                    return new GcWeatherColourModifiers();
                case "GcHazardValues":
                    return new GcHazardValues();
                case "GcWeatherProperties":
                    return new GcWeatherProperties();
                case "GcPlanetWeatherColourData":
                    return new GcPlanetWeatherColourData();
                case "GcWeatherColourSettingList":
                    return new GcWeatherColourSettingList();
                case "TkLocalisationEntry":
                    return new TkLocalisationEntry();
                case "TkLocalisationTable":
                    return new TkLocalisationTable();
                case "GcCreatureStupidNameTable":
                    return new GcCreatureStupidNameTable();
                case "GcCreatureStupidName":
                    return new GcCreatureStupidName();
                case "TkProceduralTexture":
                    return new TkProceduralTexture();
                case "TkProceduralTextureLayer":
                    return new TkProceduralTextureLayer();
                case "TkProceduralTextureList":
                    return new TkProceduralTextureList();
            }

            return null;
        }
        public static NMSTemplate DeserializeTemplate(this BinaryReader reader, string templateName)
        {
            if (templateName.StartsWith("c") && templateName.Length > 1)
                templateName = templateName.Substring(1);

            NMSTemplate obj = TemplateFromName(templateName);

            if (obj == null)
                return null;

            long templatePosition = reader.BaseStream.Position;
            System.Diagnostics.Debug.Print(templateName + " position: " + templatePosition.ToString("X"));

            if(templateName == "VariableSizeString")
            {
                long stringPos = reader.ReadInt64();
                int stringLength = reader.ReadInt32();
                int unkC = reader.ReadInt32();
                reader.BaseStream.Position = templatePosition + stringPos;
                ((VariableSizeString)obj).Value = new string(reader.ReadChars(stringLength)).TrimEnd(new[] { '\0' });
                reader.BaseStream.Position = templatePosition + 0x10;
                return obj;
            }

            var type = obj.GetType();
            var fields = type.GetFields();
            foreach (var field in fields)
            {
                var fieldName = field.Name;
                var fieldType = field.FieldType.Name;
                switch (fieldType)
                {
                    case "String":
                    case "Byte[]":
                        int size = 0;
                        foreach (var attr in field.CustomAttributes)
                        {
                            if (attr.AttributeType.Name != "MarshalAsAttribute")
                                continue;
                            foreach (var named in attr.NamedArguments)
                            {
                                if (named.MemberName != "SizeConst")
                                    continue;
                                size = (int)named.TypedValue.Value;
                            }
                        }

                        if (fieldType == "String")
                        {
                            reader.Align(0x8, templatePosition);
                            var str = reader.ReadChars(size);
                            field.SetValue(obj, new string(str).TrimEnd(new[] { '\0' }));
                        }
                        else
                        {
                            var str = reader.ReadBytes(size);
                            field.SetValue(obj, str);
                        }
                        break;
                    case "Single":
                        reader.Align(4, templatePosition);
                        field.SetValue(obj, reader.ReadSingle());
                        break;
                    case "Boolean":
                        field.SetValue(obj, reader.ReadByte() != 0);
                        break;
                    case "Int16":
                        reader.Align(2, templatePosition);
                        field.SetValue(obj, reader.ReadInt16());
                        break;
                    case "Int32":
                        reader.Align(4, templatePosition);
                        field.SetValue(obj, reader.ReadInt32());
                        break;
                    case "Int64":
                        reader.Align(8, templatePosition);
                        field.SetValue(obj, reader.ReadInt64());
                        break;
                    case "List`1":
                        reader.Align(8, templatePosition);
                        if (field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            Type itemType = field.FieldType.GetGenericArguments()[0]; // use this...
                            if (itemType == typeof(NMSTemplate))
                                field.SetValue(obj, reader.DeserializeGenericList(templatePosition));
                            else
                            {
                                // todo: get rid of this nasty shit
                                MethodInfo method = typeof(Shared).GetMethod("DeserializeList", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                                                             .MakeGenericMethod(new Type[] { itemType });
                                var list = method.Invoke(null, new object[] { reader, templatePosition });
                                field.SetValue(obj, list);
                            }
                        }

                        break;
                    default:
                        if(fieldType == "Colour")
                            reader.Align(0x10, templatePosition);

                        var data = reader.DeserializeTemplate(fieldType);
                        if (data != null)
                            field.SetValue(obj, data);
                        break;
                }
            }

            return obj;
        }

        public static void Align(this BinaryReader reader, int alignBy, long templateStartOffset)
        {
            long offset = reader.BaseStream.Position - templateStartOffset;
            long mod = offset % alignBy;
            if (mod != 0)
                reader.BaseStream.Position += (alignBy - mod);
        }

        public static List<NMSTemplate> DeserializeGenericList(this BinaryReader reader, long templateStartOffset)
        {
            long listPosition = reader.BaseStream.Position;
            long templateNamesOffset = reader.ReadInt64(); // TODO: USE THIS!
            int numTemplates = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if (listMagic != 0xAAAAAA01)
                throw new Exception("Invalid generic list read, magic 0x" + listMagic.ToString("X") + " expected 0xAAAAAA01");

            long listEndPosition = reader.BaseStream.Position;

            System.Diagnostics.Debug.WriteLine("DeserializeGenericList start " + listPosition.ToString("X") + " end " + listEndPosition.ToString("X"));

            reader.BaseStream.Position = listPosition + templateNamesOffset;
            var list = new List<NMSTemplate>();
            if (numTemplates > 0)
            {
                Dictionary<long, string> templates = new Dictionary<long, string>();
                for (int i = 0; i < numTemplates; i++)
                {
                    long nameOffset = reader.BaseStream.Position;
                    long templateOffset = reader.ReadInt64();
                    var name = reader.ReadChars(0x40);
                    templates.Add(nameOffset + templateOffset, new string(name).TrimEnd(new[] { '\0' }));
                }

                long pos = reader.BaseStream.Position;

                foreach (var template in templates)
                {
                    reader.BaseStream.Position = template.Key;
                    list.Add(DeserializeTemplate(reader, template.Value));
                }
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x10, templateStartOffset);

            return list;
        }

        public static List<T> DeserializeList<T>(this BinaryReader reader, long templateStartOffset)
        {
            long listPosition = reader.BaseStream.Position;
            long listStartOffset = reader.ReadInt64(); // TODO: USE THIS!
            int numEntries = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if (listMagic != 0xAAAAAA01)
                throw new Exception("Invalid list read, magic 0x" + listMagic.ToString("X") + " expected 0xAAAAAA01");

            long listEndPosition = reader.BaseStream.Position;

            System.Diagnostics.Debug.WriteLine("DeserializeList start " + listPosition.ToString("X") + " end " + listEndPosition.ToString("X"));

            reader.BaseStream.Position = listPosition + listStartOffset;
            var list = new List<T>();
            for(int i = 0; i < numEntries; i++)
            {
                list.Add((T)(object)DeserializeTemplate(reader, typeof(T).Name));
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x10, templateStartOffset);

            return list;
        }
    }
}
