using System;
using System.Diagnostics;

namespace Lords_API
{
    public class Pointers
    {
        public IntPtr gameAssembly;

        public IntPtr staminaAdress;
        public Pointers(Process game, VAMemory memory) 
        {
            gameAssembly = LordsAPI.getModuleAdress("GameAssembly.dll", game);
            staminaAdress = LordsAPI.PointRead(memory, gameAssembly, new int[] { 0x02DF3878, 0x7E4 });
        }
    }

}
