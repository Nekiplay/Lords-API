using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.pointers
{
    public class UserPointers
    {
        public IntPtr powerAdress;
        public IntPtr staminaAdress;
        public IntPtr gemsAdress;
        public IntPtr attacksAdress;
        public UserPointers(VAMemory memory, Modules modules)
        {
            powerAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.user, 0x898 });
            staminaAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.user, 0x7E4 });
            gemsAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.user, 0x824 });
            attacksAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.watchTower, 0xA48 });
        }
    }
}
