using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompilerTests.Database {

    public abstract class AbstractRecord {

        internal abstract string[] GetColumnHeadings();

        internal AbstractRecord() { }
        internal AbstractRecord( string[] fields ) { SetFields( fields ); }

        internal abstract void SetFields( string[] fields );
        internal abstract string[] GetFields();

        public static implicit operator string[]( AbstractRecord record ) { return record.GetFields(); }
   }

}
