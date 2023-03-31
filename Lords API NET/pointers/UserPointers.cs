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
        //public IntPtr attacksAdress;
        public UserPointers(VAMemory memory, Modules modules)
        {
            powerAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.user, 0x8A8 });
            staminaAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.user, 0x7E4 + 0x4 });
            gemsAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.user, 0x834 });
            //attacksAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.watchTower, 0x834 });
        }
    }
}
