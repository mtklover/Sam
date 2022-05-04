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
            new Command("AT+DEVCONINFO", "Check Basic Information"),
            new Command("AT+REACTIVE=1,0,0", "Check Factory Reset Protection"),
            new Command("AT+SIZECHECK=?", "Check Storage Size"),
            new Command("AT+SVCIFPGM=1,4", "Check Network Lock"),
            new Command("AT+VERSNAME=3,2,3", "Check Android Version"),
            new Command("AT+SUDDLMOD=0,0", "Download Mode"),
            new Command("AT+FACTORST=0,0", "Factory Reset"),
            new Command("AT+CTSA=2,500,500", "Single Tap Screen"),
            new Command("AT+CTSA=3,500,500", "Double Tap Screen"),
            new Command("AT+CTSA=1,500,500;+CTSA=0,1000,1000", "Swipe Screen"),
        };

        public List<Script> DefaultScripts = new()
        {
            new Script("Pull Information", "Pulls all information from included commands",
                new List<Command> 
                {
                    new Command("AT+DEVCONINFO", "Check Basic Information", 3000),
                    new Command("AT+REACTIVE=1,0,0", "Check Factory Reset Protection", 3000),
                    new Command("AT+SIZECHECK=?", "Check Storage Size", 3000),
                    new Command("AT+SVCIFPGM=1,4", "Check Network Lock", 3000),
                    new Command("AT+VERSNAME=3,2,3", "Check Android Version", 3000),
                }),
            new Script("Test Script 2", "something something something2",
                new List<Command>
                {
                    new Command("AT+SUDDLMOD=0,0", "Download Mode", 2222),
                    new Command("AT+SUDDLMOD=0,0", "Download Mode", 2222),
                    new Command("AT+SUDDLMOD=0,0", "Download Mode", 2222)
                }),
            new Script("Test Script 3", "something something something3",
                new List<Command>
                {
                    new Command("AT+FACTORST=0,0", "Factory Reset", 3333),
                    new Command("AT+FACTORST=0,0", "Factory Reset", 3333),
                    new Command("AT+FACTORST=0,0", "Factory Reset", 3333),
                    new Command("AT+FACTORST=0,0", "Factory Reset", 3333),
                    new Command("AT+FACTORST=0,0", "Factory Reset", 3333)
                })
        };
    }
}
