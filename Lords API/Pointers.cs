using Binarysharp.MemoryManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API
{
    public class Pointers
    {
        public IntPtr gameAssembly;
        public Pointers(Process game, MemorySharp memory) 
        {
            gameAssembly = LordsAPI.getModuleAdress("GameAssembly.dll", game);
        }
    }

}
