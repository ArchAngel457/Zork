using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    internal partial class GameView : UserControl
    {
        public GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                mViewModel = value;
                if (value != null)
                {
                    gameViewModelBindingSource.DataSource = ViewModel;
                }
            }
        }

        public GameView()
        {
            InitializeComponent();
        }

        private GameViewModel mViewModel;
    }
}
