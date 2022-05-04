using System.Xml;
using System.Xml.Linq;

namespace bellatrix
{
    internal class DataManager
    {
        // unsure how to handle this warning
        private static string Path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();

        private string Commands = Path + "\\Commands.xml";
        private string Scripts = Path + "\\Scripts.xml";

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

        public void AddCommand(Command command)
        {
            if (File.Exists(Commands))
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
            else
            {
                CreateFile(Commands, "Command List", "Commands");
                AddCommand(command);
            }
        }

        public void AddScript(Script script)
        {
            if (File.Exists(Scripts))
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
            else
            {
                CreateFile(Scripts, "Script List", "Scripts");
                AddScript(script);
            }
        }
    }
}