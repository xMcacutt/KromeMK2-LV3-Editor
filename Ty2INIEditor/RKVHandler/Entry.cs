﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ty2INIEditor
{
    public class Entry
    {
        public string Name;
        public int NameTableOffset;
        public int GroupingReference;
        public int Size;
        public int Offset;
        public int crc32eth;
        public bool Extracted;
    }
}
