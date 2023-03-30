using Lords_API.implementation;
using System;
using System.Diagnostics;
using System.Linq;

namespace Lords_API
{
    public class LordsAPI
    {
        public VAMemory memory = new VAMemory();
        public bool ProcOpen = false;
        private Process game;
        private Pointers pointers;

        public User user = null;

        public LordsAPI(Process gameProcess)
        {
            SetNewGameProcess(gameProcess);
        }

        public void SetNewGameProcess(Process gameProcess)
        {
            memory = new VAMemory(gameProcess.ProcessName);
            game = gameProcess;
            pointers = new Pointers(game, memory);
            user = new User(memory, pointers);
        }

        public static IntPtr PointRead(VAMemory memory, IntPtr baseAddres, int[] offsets)
        {
            for (int i = 0; i < offsets.Count() - 1; i++)
            {
                baseAddres = (IntPtr)memory.ReadLong(IntPtr.Add(baseAddres, offsets[i]));
            }
            return baseAddres + offsets[offsets.Count() - 1];
        }

        public static IntPtr getModuleAdress(string modulname, Process proc)
        {
            IntPtr result = IntPtr.Zero;
            for (int i = 0; i < proc.Modules.Count; i++)
            {
                if (proc.Modules[i].ModuleName == modulname)
                {
                    result = proc.Modules[i].BaseAddress;
                    break;
                }
            }
            return result;
        }
    }
}