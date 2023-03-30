using Binarysharp.MemoryManagement;
using Lords_API.implementation;
using System;
using System.Diagnostics;

namespace Lords_API
{
    public class LordsAPI
    {
        private Process game;
        private MemorySharp memorySharp;
        private Pointers pointers;

        public User user = null;

        public LordsAPI(Process gameProcess)
        {
            SetNewGameProcess(gameProcess);
        }

        public void SetNewGameProcess(Process gameProcess)
        {
            game = gameProcess;
            memorySharp = new MemorySharp(game);
            pointers = new Pointers(game, memorySharp);
            user = new User(memorySharp, pointers);
        }

        public static IntPtr PointRead(MemorySharp memory, IntPtr baseAddres, int[] offsets)
        {
            for (int i = 0; i < offsets.Count() - 1; i++)
            {
                baseAddres = (IntPtr)memory.Read<long>(IntPtr.Add(baseAddres, offsets[i]));
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