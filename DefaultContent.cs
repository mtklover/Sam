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
            new Command("AT+SWVER", "Check Software Information")
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
        };
    }
}