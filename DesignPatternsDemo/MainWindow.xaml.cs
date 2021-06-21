using System.ComponentModel;
using System.Windows;

namespace DesignPatternsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private string _userInput;
        public string UserInput
        {
            get => _userInput;
            set
            {
                if (value != _userInput)
                {
                    _userInput = value;
                    OnPropertyChanged(nameof(UserInput));
                    OnPropertyChanged(nameof(ProgramOutput));
                }
                
            }
        }

        public string ProgramOutput
        {
            get => GetProgramOutput();
        }

        private string GetProgramOutput()
        {
            switch (_userInput) 
            {
                case "Factory Method":
                    return new DesignPatterns.CreationalPatterns.FactoryMethod.Client().FactoryMethod();
                case "Abstract Factory":
                    return new DesignPatterns.CreationalPatterns.AbstractFactory.Client().AbstractFactory();
                default:
                    return "";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
