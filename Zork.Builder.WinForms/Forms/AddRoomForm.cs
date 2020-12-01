using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    internal partial class AddRoomForm : Form
    {
        public string RoomName
        {
            get => roomNameTextBox.Text;
            set => roomNameTextBox.Text = value;
        }

        public AddRoomForm()
        {
            InitializeComponent();
        }
    }
}
