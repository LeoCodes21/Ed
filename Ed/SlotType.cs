﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ed
{
    public partial class EdTypes
    {
        public class SlotType // a.k.a. Spoiler Type
        {
            public uint CarTypeNameHash;
            public uint Unk1;
            public uint CarTypeNameHash2;
            public uint SpoilerHash; // SPOILER, SPOILER_CARRERA, SPOILER_HATCH, SPOILER_PORSCHES
            public uint SpoilerAutoSculptHash; // SPOILER_AS2, SPOILER_CARRERA_AS2, SPOILER_HATCH_AS2, SPOILER_PORSCHES_AS2
            public uint Unk2; // 0xC2F6EBB0 = SMYTINM??
            public uint Unk3Zero;
            public uint Unk4Zero;
            public uint Unk5Zero;
        }
    }
}