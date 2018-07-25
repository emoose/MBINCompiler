using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompilerTests {

    //public struct TemplateSizeRecord {
    //    public string TemplateName { get; set; }
    //    public int Size { get; set; }

    //    public TemplateSizeRecord( string name, int size ) {
    //        this.TemplateName = name;
    //        this.Size = size;
    //    }

    //    public TemplateSizeRecord( string name, string size ) : this( name, int.Parse( size ) ) { }

    //    public static explicit operator TemplateSizeRecord( string[] fields ) {
    //        return new TemplateSizeRecord( fields[0], fields[1] );
    //    }

    //    public static implicit operator string[]( TemplateSizeRecord record ) {
    //        return new string[] { record.TemplateName, record.Size.ToString() };
    //    }
    //}

    //public class TemplateSizeTable : AbstractDataTable {

    //    // string TemplateName, int ByteSize
    //    private static string[] COLUMN_HEADINGS = new string[] { "Template", "Size (bytes)" };
    //    public override string[] ColumnHeadings => COLUMN_HEADINGS;

    //    public void Add( string name, int size ) { base.Add( new string[] { name, size.ToString() } ); }
    //    public void Add( TemplateSizeRecord record ) { base.Add( record ); }
    //}

}
