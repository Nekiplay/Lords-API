using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.pointers
{
    public class Modules
    {
        public IntPtr gameAssembly;

        public Modules(Process game, VAMemory memory)
        {
            gameAssembly = LordsAPI.getModuleAdress("GameAssembly.dll", game);
        }
    }
}
