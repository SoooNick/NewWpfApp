using NewWpfApp.Base;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace NewWpfApp.Opening
{
    public class OpenViewModel : BaseViewModel
    {
        private const string _file = "PlikTestowy.txt";
        public OpenViewModel(Window window) : base(window)
        {
            if (File.Exists(_file))
            {
                Text = File.ReadAllText(_file);
            }
        }


        public ICommand ZapiszCommand
        {
            get
            {
                return new CommandHandler(() => { SaveFile(); });
            }
        }


        private string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        public void SaveFile()
        {
            if (!File.Exists(_file))
            {
                using (var file = File.Create(_file))
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(Text);
                    file.Write(bytes, 0, bytes.Length);
                    file.Close();
                }
            }
            else
            {
                File.WriteAllText(_file, Text);
            }
            MessageBox.Show("Zapisałem!");
        }

    }
}
