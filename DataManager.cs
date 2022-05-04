using System.Xml;
using System.Xml.Linq;

namespace bellatrix
{
    internal class DataManager
    {
        private DefaultContent defaultContent = new();

        // unsure how to handle this warning
        private static string Path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();

        private string Commands = Path + "\\Commands.xml";

        private string Scripts = Path + "\\Scripts.xml";

        public void FileCheck()
        {
            if (!File.Exists(Commands))
            {
                CreateFile(Commands, "Command List", "Commands");
                foreach (Command command in defaultContent.DefaultCommands)
                {
                    AddCommand(command);
                }
            }
            if (!File.Exists(Scripts))
            {
                CreateFile(Scripts, "Script List", "Scripts");
                foreach (Script script in defaultContent.DefaultScripts)
                {
                    AddScript(script);
                }
            }
        }

        public void CreateFile(string file, string list, string items)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter(file, System.Text.Encoding.UTF8) { Formatting = Formatting.Indented };
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment(list);
            xmlWriter.WriteStartElement(items);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }

        public List<Command> LoadCommands()
        {
            List<Command> commands = new List<Command>();

            XDocument document = XDocument.Load(Commands);

            foreach (XElement element in document.Descendants("Command"))
            {
                Command command = new Command(
                    element.Element("Instruction").Value,
                    element.Element("Description").Value);
                commands.Add(command);
            }

            return commands;
        }

        public void AddCommand(Command command)
        {
            XDocument document = XDocument.Load(Commands);

            // unsure how to handle this warning
            XElement node = (from x in document.Descendants("Command")
                             where x.Element("Instruction").Value == command.Instruction
                             select x).FirstOrDefault();

            if (node != null)
            {
                node.Remove();
            }

            XElement root = document.Element("Commands");
            root.Add(
                new XElement("Command",
                new XElement("Instruction", command.Instruction),
                new XElement("Description", command.Description),
                new XElement("Delay", command.Delay.ToString())
                ));
            document.Save(Commands);
        }

        public void RemoveCommand(string instruction)
        {
            XDocument document = XDocument.Load(Commands);

            XElement node = (from x in document.Descendants("Command")
                             where x.Element("Instruction").Value == instruction
                             select x).FirstOrDefault();

            if (node != null)
            {
                node.Remove();
            }

            document.Save(Commands);
        }

        public List<Script> LoadScripts()
        {
            List<Script> scripts = new List<Script>();

            XDocument document = XDocument.Load(Scripts);

            foreach (XElement element in document.Descendants("Script"))
            {
                List<Command> commands = new List<Command>();

                foreach (XElement item in element.Descendants("Command"))
                {
                    Command command = new Command(
                        item.Element("Instruction").Value,
                        item.Element("Description").Value,
                        Convert.ToInt32(item.Element("Delay").Value));
                    commands.Add(command);
                }

                Script script = new Script(
                    element.Element("Name").Value,
                    element.Element("Description").Value,
                    commands);

                scripts.Add(script);
            }

            return scripts;
        }

        public void AddScript(Script script)
        {
            XDocument document = XDocument.Load(Scripts);

            // unsure how to handle this warning
            XElement node = (from x in document.Descendants("Script")
                             where x.Element("Name").Value == script.Name
                             select x).FirstOrDefault();

            if (node != null)
            {
                node.Remove();
            }

            XElement root = document.Element("Scripts");
            root.Add(
                new XElement("Script",
                new XElement("Name", script.Name),
                new XElement("Description", script.Description),
                new XElement("Commands", from command in script.Commands
                                         select new XElement("Command",
                                         new XElement("Instruction", command.Instruction),
                                         new XElement("Description", command.Description),
                                         new XElement("Delay", command.Delay)
                                         ))));
            document.Save(Scripts);
        }

        public void RemoveScript(string name)
        {
            XDocument document = XDocument.Load(Scripts);

            XElement node = (from x in document.Descendants("Script")
                             where x.Element("Name").Value == name
                             select x).FirstOrDefault();

            if (node != null)
            {
                node.Remove();
            }

            document.Save(Scripts);
        }
    }
}