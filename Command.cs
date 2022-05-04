namespace bellatrix
{
    internal class Command
    {
        public string Instruction { get; set; }
        public string Description { get; set; }
        public int? Delay { get; set; }

        internal Command(string instruction, string description)
        {
            Instruction = instruction;
            Description = description;
        }
    }
}