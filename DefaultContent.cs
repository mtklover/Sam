using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bellatrix
{
    internal class DefaultContent
    {
        public List<Command> DefaultCommands = new()
        {
            new Command("AT+DEVCONINFO", "Basic Information"),
            new Command("AT+SUDDLMOD=0,0", "Download Mode"),
            new Command("AT+FACTORST=0,0", "Factory Reset")
        };

        public List<Script> DefaultScripts = new()
        {
            new Script("Test Script 1", "something something something1",
                new List<Command> 
                {
                    new Command("AT+DEVCONINFO", "Basic Information", 1111)
                }),
            new Script("Test Script 2", "something something something2",
                new List<Command>
                {
                    new Command("AT+SUDDLMOD=0,0", "Download Mode", 2222)
                }),
            new Script("Test Script 3", "something something something3",
                new List<Command>
                {
                    new Command("AT+FACTORST=0,0", "Factory Reset", 3333)
                })
        };
    }
}
