using System.Reflection;

namespace bellatrix
{
    public partial class Bellatrix : Form
    {
        public Bellatrix()
        {
            InitializeComponent();
        }

        private void Bellatrix_Load(object sender, EventArgs e)
        {
            // get version info for label
            BellatrixLabel.Text = $"Bellatrix (v{Assembly.GetEntryAssembly()?.GetName().Version})";
        }
    }
}