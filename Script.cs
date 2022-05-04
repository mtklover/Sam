namespace bellatrix
{
    internal class Script
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Command>? Commands { get; set; }

        internal Script(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}