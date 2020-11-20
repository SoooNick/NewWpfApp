using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace NewWpfApp.Base
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        private Window _window;

        public BaseViewModel(Window window)
        {
            _window = window ?? throw new ArgumentNullException(nameof(window));
        }

        public void CloseWindow()
        {
            _window.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
