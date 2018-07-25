using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompilerTests.Database {

    public class Table<T> : IEnumerable<T> where T : AbstractRecord, new() {

        public string[] ColumnHeadings { get; }

        protected List<T> records;

        public int RecordCount => records.Count;

        public Table() {
            this.ColumnHeadings = new T().GetColumnHeadings();
            this.records = new List<T>();
        }

        public void Clear() { records.Clear(); }
        public void Add( T record ) { records.Add( record ); }
        public void Insert( int row, T record) { records.Insert( row, record ); }
        public void Remove( int row ) { records.RemoveAt( row ); }

        public T GetRecord( int row ) { return records[row]; }
        public void SetRecord( int row, T record ) { records[row] = record; }

        private string FieldsToTSV( string[] fields ) => String.Join( "\t", fields );
        private string[] FieldsFromTSV( string tsv ) => tsv.Split( new char[] { '\t' } ).Select( x => x.Trim( ' ' ) ).ToArray();

        public void Save( StreamWriter streamOut ) {
            if ( ColumnHeadings != null ) {
                streamOut.WriteLine( FieldsToTSV( ColumnHeadings.Select( x => "#" + x ).ToArray() ) );
            }
            foreach (var record in records) streamOut.WriteLine( FieldsToTSV( record ) );
        }

        public void Load( StreamReader streamIn ) {
            records.Clear();
            while (!streamIn.EndOfStream) {
                string tsv = streamIn.ReadLine().Trim( ' ' );
                if ( String.IsNullOrEmpty( tsv ) ) continue; // ignore blank lines

                if ( tsv.StartsWith( "#" ) ) continue; // ignore comment lines

                // record
                T record = new T();
                record.SetFields( FieldsFromTSV( tsv ) );
                records.Add( record );
            }
        }

        public IEnumerator<T> GetEnumerator() => records.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => records.GetEnumerator();
    }

}
