﻿using System;
using System.Collections.Generic;
using System.Text;
using DIaLOGIKa.b2xtranslator.StructuredStorage.Reader;
using DIaLOGIKa.b2xtranslator.OfficeGraph;

namespace DIaLOGIKa.b2xtranslator.Spreadsheet.XlsFileFormat
{
    public class OfficeGraphBiffRecordSequence
    {
        IStreamReader _reader;
        public IStreamReader Reader
        {
            get { return _reader; }
            set { this._reader = value; }
        }

        public OfficeGraphBiffRecordSequence(IStreamReader reader)
        {
            _reader = reader;
        }

        public OfficeGraphBiffRecord GetNextRecord()
        {
            throw new NotImplementedException();
        }
    }
}
