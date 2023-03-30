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
        public IntPtr staminaAdress;
        public IntPtr gemsAdress;
        public UserPointers(Process game, VAMemory memory, Modules modules)
        {
            staminaAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { 0x02DF3878, 0x7E4 });
            gemsAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { 0x02DF3878, 0x824 });
        }
    }
}
