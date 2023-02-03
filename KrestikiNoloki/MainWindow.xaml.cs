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
using System.Threading;

namespace KrestikiNoloki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool robot_play = true;
        public string devil_znakP = " ";
        public bool user_play = false;
        public string devil_znakB = " ";
        public string win = "";
        public Random rnd = new Random();
        public int random_number;
        public List<int> LISTKNOPOK = new List<int>();
        public List<Button> listOfButtons = new List<Button>();

        // Adding elements to List



        public MainWindow()
        {
            
            InitializeComponent();
            listOfButtons.Add(Butto_1);
            listOfButtons.Add(Butto_2);
            listOfButtons.Add(Butto_3);
            listOfButtons.Add(Butto_4);
            listOfButtons.Add(Butto_5);
            listOfButtons.Add(Butto_6);
            listOfButtons.Add(Butto_7);
            listOfButtons.Add(Butto_8);
            listOfButtons.Add(Butto_9);
        }

        private void Butto_Start_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                LISTKNOPOK.Add(i);
            }
            WinText.Text = "Крестики нолики";
            devil_znakP = " ";
            devil_znakB = " ";
            win = "";
            random_number = rnd.Next(1, 9);
            user_play = !user_play;
            robot_play = !user_play;
            Butto_1.IsEnabled = true;
            Butto_2.IsEnabled = true;
            Butto_3.IsEnabled = true;
            Butto_4.IsEnabled = true;
            Butto_5.IsEnabled = true;
            Butto_6.IsEnabled = true;
            Butto_7.IsEnabled = true;
            Butto_8.IsEnabled = true;
            Butto_9.IsEnabled = true;
            Butto_1.Content = string.Empty;
            Butto_2.Content = string.Empty;
            Butto_3.Content = string.Empty;
            Butto_4.Content = string.Empty;
            Butto_5.Content = string.Empty;
            Butto_6.Content = string.Empty;
            Butto_7.Content = string.Empty;
            Butto_8.Content = string.Empty;
            Butto_9.Content = string.Empty;
            if (user_play == true)
            {
                devil_znakB = "O";
                devil_znakP = "X";
            }
            if (robot_play == true)
            {
                devil_znakB = "X";
                devil_znakP = "O";
                Hod_bota();
            }
        }

        private void Hod_bota()
        {
            

            int random_numbere = rnd.Next(1,9);
            
            bool f = true;
            if (listOfButtons[random_numbere].Content != "X" && listOfButtons[random_numbere].Content != "O")
            {

                listOfButtons[random_numbere].Content = devil_znakB;
                listOfButtons[random_numbere].IsEnabled = false;
                if (listOfButtons[random_numbere].Content != "X" && listOfButtons[random_numbere].Content != "O")
                {
                    listOfButtons[random_numbere].Content = devil_znakB;
                    listOfButtons[random_numbere].IsEnabled = false;
                }
            }
            else
            {
                random_numbere = random_number;
                if (listOfButtons[random_numbere].Content != "X" && listOfButtons[random_numbere].Content != "O")
                {
                    listOfButtons[random_numbere].Content = devil_znakB;
                    listOfButtons[random_numbere].IsEnabled = false;
                }
            }



        }

        private void Butto_Click(object sender, RoutedEventArgs e)
        {
            if (win == "")
            {
                if ((sender as Button).Name == "Butto_1")
                {
                    (sender as Button).Content = devil_znakP;
                    (sender as Button).IsEnabled = false;
                    Who_Win();
                    Hod_bota();
                    Who_Win();
                }
                else if ((sender as Button).Name == "Butto_2")
                {
                    (sender as Button).Content = devil_znakP;
                    (sender as Button).IsEnabled = false;
                    Who_Win();
                    Hod_bota();
                    Who_Win();
                }
                else if ((sender as Button).Name == "Butto_3")
                {
                    (sender as Button).Content = devil_znakP;
                    (sender as Button).IsEnabled = false;
                    Who_Win();
                    Hod_bota();
                    Who_Win();
                }
                else if ((sender as Button).Name == "Butto_4")
                {
                    (sender as Button).Content = devil_znakP;
                    (sender as Button).IsEnabled = false;
                    Who_Win();
                    Hod_bota();
                    Who_Win();
                }
                else if ((sender as Button).Name == "Butto_5")
                {
                    (sender as Button).Content = devil_znakP;
                    (sender as Button).IsEnabled = false;
                    Who_Win();
                    Hod_bota();
                    Who_Win();
                }
                else if ((sender as Button).Name == "Butto_6")
                {
                    (sender as Button).Content = devil_znakP;
                    (sender as Button).IsEnabled = false;
                    Who_Win();
                    Hod_bota();
                    Who_Win();
                }
                else if ((sender as Button).Name == "Butto_7")
                {
                    (sender as Button).Content = devil_znakP;
                    (sender as Button).IsEnabled = false;
                    Who_Win();
                    Hod_bota();
                    Who_Win();
                }
                else if ((sender as Button).Name == "Butto_8")
                {
                    (sender as Button).Content = devil_znakP;
                    (sender as Button).IsEnabled = false;
                    Who_Win();
                    Hod_bota();
                    Who_Win();
                }
                else if ((sender as Button).Name == "Butto_9")
                {
                    (sender as Button).Content = devil_znakP;
                    (sender as Button).IsEnabled = false;
                    Who_Win();
                    Hod_bota();
                    Who_Win();
                }
            }
        }
        private void Who_Win()
        {
            if ((Butto_1.Content as string) == devil_znakB && (Butto_4.Content as string) == devil_znakB && (Butto_7.Content as string) == devil_znakB)
            {
                win = "Я";
                WinText.Text = "Крестики нолики\nВы победили";
            }
            else if ((Butto_2.Content as string) == devil_znakB && (Butto_5.Content as string) == devil_znakB && (Butto_8.Content as string) == devil_znakB)
            {
                win = "Я";
                WinText.Text = "Крестики нолики\nВы победили";
            }
            else if ((Butto_3.Content as string) == devil_znakB && (Butto_6.Content as string) == devil_znakB && (Butto_9.Content as string) == devil_znakB)
            {
                win = "Я";
                WinText.Text = "Крестики нолики\nВы победили";
            }
            else if ((Butto_1.Content as string) == devil_znakB && (Butto_2.Content as string) == devil_znakB && (Butto_3.Content as string) == devil_znakB)
            {
                win = "Я";
                WinText.Text = "Крестики нолики\nВы победили";
            }
            else if ((Butto_4.Content as string) == devil_znakB && (Butto_5.Content as string) == devil_znakB && (Butto_6.Content as string) == devil_znakB)
            {
                win = "Я";
                WinText.Text = "Крестики нолики\nВы победили";
            }
            else if ((Butto_7.Content as string) == devil_znakB && (Butto_8.Content as string) == devil_znakB && (Butto_9.Content as string) == devil_znakB)
            {
                win = "Я";
                WinText.Text = "Крестики нолики\nВы победили";
            }
            else if ((Butto_1.Content as string) == devil_znakB && (Butto_5.Content as string) == devil_znakB && (Butto_9.Content as string) == devil_znakB)
            {
                win = "Я";
                WinText.Text = "Крестики нолики\nВы победили";
            }
            else if ((Butto_3.Content as string) == devil_znakB && (Butto_5.Content as string) == devil_znakB && (Butto_7.Content as string) == devil_znakB)
            {
                win = "Я";
                WinText.Text = "Крестики нолики\nВы победили";
            }


            else if ((Butto_1.Content as string) == devil_znakP && (Butto_4.Content as string) == devil_znakP && (Butto_7.Content as string) == devil_znakP)
            {
                win = "Bot";
                WinText.Text = "Крестики нолики\nПобедил я";
            }
            else if ((Butto_2.Content as string) == devil_znakP && (Butto_5.Content as string) == devil_znakP && (Butto_8.Content as string) == devil_znakP)
            {
                win = "Bot";
                WinText.Text = "Крестики нолики\nПобедил я";
            }
            else if ((Butto_3.Content as string) == devil_znakP && (Butto_6.Content as string) == devil_znakP && (Butto_9.Content as string) == devil_znakP)
            {
                win = "Bot";
                WinText.Text = "Крестики нолики\nПобедил я";
            }
            else if ((Butto_1.Content as string) == devil_znakP && (Butto_2.Content as string) == devil_znakP && (Butto_3.Content as string) == devil_znakP)
            {
                win = "Bot";
                WinText.Text = "Крестики нолики\nПобедил я";
            }
            else if ((Butto_4.Content as string) == devil_znakP && (Butto_5.Content as string) == devil_znakP && (Butto_6.Content as string) == devil_znakP)
            {
                win = "Bot";
                WinText.Text = "Крестики нолики\nПобедил я";

            }
            else if ((Butto_7.Content as string) == devil_znakP && (Butto_8.Content as string) == devil_znakP && (Butto_9.Content as string) == devil_znakP)
            {
                win = "Bot";
                WinText.Text = "Крестики нолики\nПобедил я";
            }
            else if ((Butto_1.Content as string) == devil_znakP && (Butto_5.Content as string) == devil_znakP && (Butto_9.Content as string) == devil_znakP)
            {
                win = "Bot";
                WinText.Text = "Крестики нолики\nПобедил я";
            }
            else if ((Butto_3.Content as string) == devil_znakP && (Butto_5.Content as string) == devil_znakP && (Butto_7.Content as string) == devil_znakP)
            {
                win = "Bot";
                WinText.Text = "Крестики нолики\nПобедил я";
            }
            else if (Butto_1.IsEnabled == false && Butto_2.IsEnabled == false && Butto_3.IsEnabled == false && Butto_4.IsEnabled == false && Butto_5.IsEnabled == false && Butto_6.IsEnabled == false && Butto_7.IsEnabled == false && Butto_8.IsEnabled == false && Butto_9.IsEnabled == false || win == "ничья")
            {
                win = "?";
                WinText.Text = "Крестики нолики\n Ничья";
            }
            Thread.Sleep(500);
        }
    }
}
