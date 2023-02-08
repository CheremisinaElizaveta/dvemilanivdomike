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

namespace крестики_нолики_2
{
    public partial class MainWindow : Window
    {
        private List<Button> buts = new List<Button>();
        private int step = 1;
        private string znak = "X";
        public MainWindow()
        {
            InitializeComponent();
            KNOPKI();
        }
        private void KNOPKI()
        {
            buts.Add(button1);
            buts.Add(button2);
            buts.Add(button3);
            buts.Add(button4);
            buts.Add(button5);
            buts.Add(button6);
            buts.Add(button7);
            buts.Add(button8);
            buts.Add(button9);
        }
        private void bstart_Click(object sender, RoutedEventArgs e)
        {

            gamestart.IsEnabled = false;
            foreach (Button b in buts)
            {
                b.IsEnabled = true;
            }

            if (znak == "0")
            {
                znak = "X";
            }
            else
            {
                znak = "0";
                Botyara();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sender.GetType().GetProperty("Content").SetValue(sender, znak);
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            buts.Remove(sender as Button);
            Botyara();
            win();
        }

        private void win()
        {

            if (button1.Content == "X" && button1.Content == button2.Content && button2.Content == button3.Content)
            {
                text1.Text = "Победили крестики";
                Restart();
            }
            if (button4.Content == "X" && button4.Content == button5.Content && button5.Content == button6.Content)
            {
                text1.Text = "Победили крестики";
                Restart();
            }
            if (button7.Content == "X" && button7.Content == button8.Content && button8.Content == button9.Content)
            {
                text1.Text = "Победили крестики";
                Restart();
            }
            if (button1.Content == "X" && button1.Content == button4.Content && button4.Content == button7.Content)
            {
                text1.Text = "Победили крестики";
                Restart();
            }
            if (button2.Content == "X" && button2.Content == button5.Content && button5.Content == button8.Content)
            {
                text1.Text = "Победили крестики";
                Restart();
            }
            if (button3.Content == "X" && button3.Content == button6.Content && button6.Content == button9.Content)
            {
                text1.Text = "Победили крестики";
                Restart();
            }
            if (button1.Content == "X" && button1.Content == button5.Content && button5.Content == button9.Content)
            {
                text1.Text = "Победили крестики";
                Restart();
            }
            if (button3.Content == "X" && button3.Content == button5.Content && button5.Content == button7.Content)
            {
                text1.Text = "Победили крестики";
                Restart();
            }

            if (button1.Content == "0" && button1.Content == button2.Content && button2.Content == button3.Content)
            {
                text1.Text = "Победили нолики";
                Restart();
            }
            if (button4.Content == "0" && button4.Content == button5.Content && button5.Content == button6.Content)
            {
                text1.Text = "Победили нолики";
                Restart();
            }
            if (button7.Content == "0" && button7.Content == button8.Content && button8.Content == button9.Content)
            {
                text1.Text = "Победили нолики";
                Restart();
            }
            if (button1.Content == "0" && button1.Content == button4.Content && button4.Content == button7.Content)
            {
                text1.Text = "Победили нолики";
                Restart();
            }
            if (button2.Content == "0" && button2.Content == button5.Content && button5.Content == button8.Content)
            {
                text1.Text = "Победили нолики";
                Restart();
            }
            if (button3.Content == "0" && button3.Content == button6.Content && button6.Content == button9.Content)
            {
                text1.Text = "Победили нолики";
                Restart();
            }
            if (button1.Content == "0" && button1.Content == button5.Content && button5.Content == button9.Content)
            {
                text1.Text = "Победили нолики";
                Restart();
            }
            if (button3.Content == "0" && button3.Content == button5.Content && button5.Content == button7.Content)
            {
                text1.Text = "Победили нолики";
                Restart();
            }
            if(buts.Count == 0)
            {
                text1.Text = "Ничья";
                Restart();
            }

        }
        private void Botyara()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, buts.Count);
            buts[x].IsEnabled = false;
            if (znak == "0")
            {
                buts[x].Content = "X";
            }
            else
            {
                buts[x].Content = "0";
            }
            buts.RemoveAt(x);

        }
        private void Restart()
        {
            gamestart.IsEnabled = true;
            KNOPKI();
            foreach (Button b in buts)
            {
                b.Content = "";
                b.IsEnabled = false;
            }
        }
    }
}

