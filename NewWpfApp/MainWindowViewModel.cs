using NewWpfApp.Base;
using NewWpfApp.Opening;
using System.Collections;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace NewWpfApp
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel(Window window) : base(window)
        {
        }

        #region 

        public ICommand OpenWebsiteCommand
        {
            get
            {
                return new CommandHandler(
                    () => { OpenWebsiteExecute(); },
                    () => { return true; });
            }
        }

        public void OpenWebsiteExecute()
        {
            Process.Start("https://analmed.pl/");
        }

        #endregion

        #region CloseCommand
        public ICommand CloseCommand
        {
            get
            {
                return new CommandHandler(
                    () => { CloseExecute(); },
                    () => { return CanExecuteClose; });
            }
        }

        public void CloseExecute()
        {
            var result = MessageBox.Show("Czy na pewno zamknąć program?", "Pytanie", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                base.CloseWindow();
            }
        }

        public bool CanExecuteClose
        {
            get
            {
                return true;
            }
        }
        #endregion

        #region CloseCommand
        public ICommand OpenCommand
        {
            get
            {
                return new CommandHandler(
                    () => { OpenExecute(); },
                    () => { return CanExecuteOpen; });
            }
        }

        public void OpenExecute()
        {
            var openWindow = new OpenWindow();
            openWindow.Show();
            CloseWindow();
        }

        public bool CanExecuteOpen
        {
            get
            {
                return true;
            }
        }
        #endregion

        #region DataGrid


        public IEnumerable Items => DefaultData.DefaultData.Appointments;


        #endregion
    }
}
