using System.ComponentModel;

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
            new Command("AT+SYSSCOPE=1,0", "Have information on this command? Visit the repo and submit a pull request with your changes to DefaultContent!"),
            new Command("AT+KSTRINGB=0,3", "Have information on this command? Visit the repo and submit a pull request with your changes to DefaultContent!"),
            new Command("AT+DUMPCTRL=1,0", "Have information on this command? Visit the repo and submit a pull request with your changes to DefaultContent!"),
            new Command("AT+SWATD=0", "Have information on this command? Visit the repo and submit a pull request with your changes to DefaultContent!"),
            new Command("AT+ACTIVATE=0,0,0", "Have information on this command? Visit the repo and submit a pull request with your changes to DefaultContent!"),
            new Command("AT+SWATD=1", "Have information on this command? Visit the repo and submit a pull request with your changes to DefaultContent!"),
            new Command("AT+DEBUGLVC=0,5", "Have information on this command? Visit the repo and submit a pull request with your changes to DefaultContent!"),
            new Command("AT+SERIALNO", "Check Serial Number"),
            new Command("AT+BATGETLEVEL?", "Check Battery Information"),
            new Command("AT+IMEINUM", "Check IMEI Information"),
            new Command("AT+SWVER", "Check Software Information"),

            // ADB Prompt Commands

            // AOS 9
            new Command("AT+CTSA=2,750,1300", "SM-G950U AOS-9 ADB Prompt"),

            //// AOS 10
            new Command("AT+CTSA=2,600,2100", "SM-G781U AOS-10 ADB Prompt"),
            new Command("AT+CTSA=2,600,2100", "SM-G981U AOS-10 ADB Prompt"),
            new Command("AT+CTSA=2,700,2100", "SM-G986U AOS-10 ADB Prompt"),
            new Command("AT+CTSA=2,800,2125", "SM-N986U AOS-10 ADB Prompt"),
            new Command("AT+CTSA=2,700,2100", "SM-G988U AOS-10 ADB Prompt"),

            //// AOS 11
            new Command("AT+CTSA=2,600,2100", "SM-G781U AOS-11 ADB Prompt"),
            new Command("AT+CTSA=2,600,2100", "SM-G981U AOS-11 ADB Prompt"),
            new Command("AT+CTSA=2,700,2100", "SM-G986U AOS-11 ADB Prompt"),
            new Command("AT+CTSA=2,800,2125", "SM-N986U AOS-11 ADB Prompt"),
            new Command("AT+CTSA=2,700,2100", "SM-G988U AOS-11 ADB Prompt"),
            new Command("AT+CTSA=2,600,2100", "SM-G991U AOS-11 ADB Prompt"),
            new Command("AT+CTSA=2,700,2100", "SM-G996U AOS-11 ADB Prompt"),
            new Command("AT+CTSA=2,700,2100", "SM-G998U AOS-11 ADB Prompt"),

            //// AOS 12
            new Command("AT+CTSA=2,600,2100", "SM-G781U AOS-12 ADB Prompt"),
            new Command("AT+CTSA=2,600,2100", "SM-G981U AOS-12 ADB Prompt"),
            new Command("AT+CTSA=2,700,2100", "SM-G986U AOS-12 ADB Prompt"),
            new Command("AT+CTSA=2,800,2125", "SM-N986U AOS-12 ADB Prompt"),
            new Command("AT+CTSA=2,700,2100", "SM-G988U AOS-12 ADB Prompt"),
            new Command("AT+CTSA=2,600,2100", "SM-G991U AOS-12 ADB Prompt"),
            new Command("AT+CTSA=2,700,2100", "SM-G996U AOS-12 ADB Prompt"),
            new Command("AT+CTSA=2,700,2100", "SM-G998U AOS-12 ADB Prompt")
        };

        public List<Script> DefaultScripts = new()
        {
            new Script("Pull Information", "Pulls all information from included commands",
                new BindingList<Command>
                {
                    new Command("AT+DEVCONINFO", "Check Basic Information", 3000),
                    new Command("AT+REACTIVE=1,0,0", "Check Factory Reset Protection", 3000),
                    new Command("AT+SIZECHECK=?", "Check Storage Size", 3000),
                    new Command("AT+SVCIFPGM=1,4", "Check Network Lock", 3000),
                    new Command("AT+VERSNAME=3,2,3", "Check Android Version", 3000),
                }),

            new Script("Enable USB Debugging", "MUST GO TO DIALER ON SETUP SCREEN AND TYPE *#0*# I am still experimenting with this script, " +
                "some commands are missing which might cause lower end phones to not work, this will be fixed soon! There is believed to be several " +
                "versions of running this script",
                new BindingList<Command>
                {
                    new Command("AT+SYSSCOPE=1,0", "?", 5000),
                    // THESE MIGHT BE STEPS FOR OLDER PHONES BUT NOT IN THE CORRECT ORDER
                    // WILL GET BACK TO THIS AS SOON AS IM IN FRONT OF MORE DEVICES
                    new Command("AT+KSTRINGB=0,3", "?", 5000),
                    new Command("AT+DUMPCTRL=1,0", "?", 3000),
                    new Command("AT+SWATD=0", "?", 5000),
                    new Command("AT+ACTIVATE=0,0,0", "?", 10000),
                    new Command("AT+SWATD=1", "?", 5000),
                    new Command("AT+DEBUGLVC=0,5", "?", 5000)
                }),

            // Dialer Touch Scripts

            // AOS 9 
            new Script("SM-G950U AOS-9 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,300,2100", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,300,1700", "*", 1000),
                    new Command("AT+CTSA=2,750,1700", "#", 1000),
                    new Command("AT+CTSA=2,500,1700", "0", 1000),
                    new Command("AT+CTSA=2,300,1700", "*", 1000),
                    new Command("AT+CTSA=2,750,1700", "#", 1000)
                }),

            // AOS 10
            new Script("SM-G781U AOS-10 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000)
                }),
            new Script("SM-G981U AOS-10 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000)
                }),
            new Script("SM-G986U AOS-10 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000)
                }),
            new Script("SM-N986U AOS-10 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000)
                }),
            new Script("SM-G988U AOS-10 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000)
                }),

            // AOS 11
            new Script("SM-G781U AOS-11 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000)
                }),
            new Script("SM-G981U AOS-11 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000)
                }),
            new Script("SM-G986U AOS-11 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000)
                }),
            new Script("SM-N986U AOS-11 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000)
                }),
            new Script("SM-G988U AOS-11 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000)
                }),
            new Script("SM-G991U AOS-11 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000)
                }),
            new Script("SM-G996U AOS-11 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000)
                }),
            new Script("SM-G998U AOS-11 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000)
                }),

            // AOS 12
            new Script("SM-G781U AOS-12 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000)
                }),
            new Script("SM-G981U AOS-12 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000)
                }),
            new Script("SM-G986U AOS-12 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000)
                }),
            new Script("SM-N986U AOS-12 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,900,1825", "#", 1000)
                }),
            new Script("SM-G988U AOS-12 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,300,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,300,1700", "*", 1000),
                    new Command("AT+CTSA=2,750,1700", "#", 1000),
                    new Command("AT+CTSA=2,500,1700", "0", 1000),
                    new Command("AT+CTSA=2,300,1700", "*", 1000),
                    new Command("AT+CTSA=2,750,1700", "#", 1000)
                }),
            new Script("SM-G991U AOS-12 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,600,2025", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000),
                    new Command("AT+CTSA=2,600,1825", "0", 1000),
                    new Command("AT+CTSA=2,100,1825", "*", 1000),
                    new Command("AT+CTSA=2,750,1750", "#", 1000)
                }),
            new Script("SM-G996U AOS-12 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,300,2100", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,300,1700", "*", 1000),
                    new Command("AT+CTSA=2,750,1700", "#", 1000),
                    new Command("AT+CTSA=2,500,1700", "0", 1000),
                    new Command("AT+CTSA=2,300,1700", "*", 1000),
                    new Command("AT+CTSA=2,750,1700", "#", 1000)
                }),
            new Script("SM-G996U AOS-12 Dialer", "Opens the dialer menu from setup screen.",
                new BindingList<Command>
                {
                    new Command("AT+CTSA=2,300,2100", "Emergency Dialer", 1000),
                    new Command("AT+CTSA=2,300,1700", "*", 1000),
                    new Command("AT+CTSA=2,750,1700", "#", 1000),
                    new Command("AT+CTSA=2,500,1700", "0", 1000),
                    new Command("AT+CTSA=2,300,1700", "*", 1000),
                    new Command("AT+CTSA=2,750,1700", "#", 1000)
                }),
        };
    }
}