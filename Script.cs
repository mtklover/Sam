using System.ComponentModel;

namespace bellatrix
{
    internal class Script
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public BindingList<Command> Commands { get; set; }

        internal Script(string name, string description, BindingList<Command> commands)
        {
            Name = name;
            Description = description;
            Commands = commands;
        }
    }
}