using Lords_API.implementation;
using Lords_API.pointers;
using System;
using System.Diagnostics;

namespace Lords_API
{
    public class Pointers
    {
        public Modules modules;
        public UserPointers user;
        public ClanPointers clan;
        public Pointers(Process game, VAMemory memory) 
        {
            modules = new Modules(game, memory);
            user = new UserPointers(memory, modules);
            clan = new ClanPointers(game, memory, modules);
        }
    }

}
