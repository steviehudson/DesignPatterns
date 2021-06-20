using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesignPatterns.CreationalPatterns.FactoryMethod;

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
                    return new Client().FactoryMethod();
                default:
                    return "";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
