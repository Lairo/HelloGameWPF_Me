using System;
using System.Collections.Generic;
using System.Linq;
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

namespace HelloGameWPF_Me
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HelloGame helloGame = new HelloGame();
        public MainWindow()
        {
            InitializeComponent();            
            Start();
        }

        void Start()
        {
            helloGame.Hint();
            pot.Text = $"The pot {helloGame.Pot}.";
            currentNumber.Text = $"Current Number\n{helloGame.CurrentNumber}";            

        }
        private void Higher_Click(object sender, RoutedEventArgs e)
        {
            prompt.Text = helloGame.Guess(true).ToString();
            pot.Text = helloGame.Pot.ToString();
            nextNumber.Text = $"Next Number ?";
            currentNumber.Text = $"Current Number\n{helloGame.CurrentNumber}";
        }

        private void Lower_Click(object sender, RoutedEventArgs e)
        {
            prompt.Text = helloGame.Guess(false).ToString(); 
            pot.Text = helloGame.Pot.ToString();
            nextNumber.Text = $"Next Number ?";
            currentNumber.Text = $"Current Number\n{helloGame.CurrentNumber}";
        }

        private void Hint_Click(object sender, RoutedEventArgs e)
        {

            pot.Text = helloGame.Pot.ToString();
            nextNumber.Text = helloGame.Hint();
        }

        private void Cheat_Click(object sender, RoutedEventArgs e)
        {
            Start();
            cheatOutput.Text = helloGame.Cheat();
            pot.Text = helloGame.Pot.ToString();
        }
    }
}
