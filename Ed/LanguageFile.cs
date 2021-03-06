﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ed
{
    public class LanguageFile
    {
        public int ChunkID; // [0x00039000 - BCHUNK_LANGUAGE]
        public int ChunkSize;
        public int UnknownData; // (MW) 0x10
        public int NumberOfEntries;
        public int HashBlockPosition;
        public int TextBlockPosition;
        public byte[] LanguageFileType = new byte[16]; // NFSC/PS/UC??

        public class HashInfo
        {
            public uint StringHash;
            public uint OffsetInTextBlock;
        }
    }
}
