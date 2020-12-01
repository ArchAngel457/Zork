using System.Reflection;
using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    internal partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

            titleLabel.Text = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
            versionLabel.Text = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>().Version;
            copyrightLabel.Text = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            productDescriptionLabel.Text = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyDescriptionAttribute>().Description;
        }
    }
}