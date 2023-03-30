namespace Lords_API.implementation
{
    public class User
    {
        private VAMemory memory;
        private Pointers pointers;
        public User(VAMemory memory, Pointers pointers) {
            this.memory = memory;
            this.pointers = pointers;
        }

        public int Stamina
        {
            get
            {
                return memory.ReadInt32(pointers.staminaAdress);
            }
        }
    }
}
