﻿using System;
using System.Diagnostics;

namespace Lords_API.pointers
{
    public class ColisiumPointers
    {
        public IntPtr rankAdress;
        public ColisiumPointers(Process game, VAMemory memory, Modules modules)
        {
            rankAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.colisium, 0xB8, 0x0, 0x24 });
        }
    }
}
