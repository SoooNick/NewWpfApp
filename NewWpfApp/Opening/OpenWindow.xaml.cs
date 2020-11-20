using System.Windows;

namespace NewWpfApp.Opening
{
    /// <summary>
    /// Interaction logic for OpenWindow.xaml
    /// </summary>
    public partial class OpenWindow : Window
    {
        public OpenWindow()
        {
            InitializeComponent();
            DataContext = new OpenViewModel(this);
        }
    }
}
