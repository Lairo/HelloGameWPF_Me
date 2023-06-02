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
        public MainWindow()
        {
            InitializeComponent();            
            Start();
            
        }

        void Start()
        {
            HelloGame.Hint();
            pot.Text = $"The pot {HelloGame.GetPot()}.";
            currentNumber.Text = $"Current Number\n{HelloGame.CurrentNumber()}";            

        }
        private void Higher_Click(object sender, RoutedEventArgs e)
        {
            prompt.Text = HelloGame.Guess(true).ToString();
            pot.Text = HelloGame.GetPot().ToString();
            nextNumber.Text = $"Next Number ?";
            currentNumber.Text = $"Current Number\n{HelloGame.CurrentNumber()}";
        }

        private void Lower_Click(object sender, RoutedEventArgs e)
        {
            prompt.Text = HelloGame.Guess(false).ToString(); 
            pot.Text = HelloGame.GetPot().ToString();
            nextNumber.Text = $"Next Number ?";
            currentNumber.Text = $"Current Number\n{HelloGame.CurrentNumber()}";
        }

        private void Hint_Click(object sender, RoutedEventArgs e)
        {

            pot.Text = HelloGame.GetPot().ToString();
            nextNumber.Text = HelloGame.Hint();
        }

        private void Cheat_Click(object sender, RoutedEventArgs e)
        {
            cheatOutput.Text = HelloGame.Cheat();
            pot.Text = HelloGame.GetPot().ToString();
        }
    }
}
