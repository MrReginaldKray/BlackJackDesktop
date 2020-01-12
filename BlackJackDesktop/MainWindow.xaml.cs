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

namespace BlackJackDesktop
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        CCardDeck newGame;
        CPlayer player1;
        CPlayer player2;
        CPlayer player3;
        CPlayer player4;
        CPlayer player5;

        bool isGameRunning = false;

        private void btn_joinPlayer1_Click(object sender, RoutedEventArgs e)
        {
            btn_joinPlayer1.Visibility = Visibility.Collapsed;
        }

        private void btn_joinPlayer2_Click(object sender, RoutedEventArgs e)
        {
            btn_joinPlayer2.Visibility = Visibility.Collapsed;
        }

        private void btn_joinPlayer3_Click(object sender, RoutedEventArgs e)
        {
            btn_joinPlayer3.Visibility = Visibility.Collapsed;
        }

        private void btn_joinPlayer4_Click(object sender, RoutedEventArgs e)
        {
            btn_joinPlayer4.Visibility = Visibility.Collapsed;
        }

        private void btn_joinPlayer5_Click(object sender, RoutedEventArgs e)
        {
            btn_joinPlayer5.Visibility = Visibility.Collapsed;
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            if (!btn_joinPlayer1.IsVisible || !btn_joinPlayer2.IsVisible || !btn_joinPlayer3.IsVisible || 
                !btn_joinPlayer4.IsVisible || !btn_joinPlayer5.IsVisible)
            {
                if (!btn_joinPlayer1.IsVisible)
                {
                    txt_namePlayer1.IsReadOnly = true;
                    player1 = new CPlayer(txt_namePlayer1.Text, Int32.Parse(txt_coinsPlayer1.Text));
                }
                else
                {
                    btn_joinPlayer1.IsEnabled = false;
                }

                if (!btn_joinPlayer2.IsVisible)
                {
                    txt_namePlayer2.IsReadOnly = true;
                    player2 = new CPlayer(txt_namePlayer2.Text, Int32.Parse(txt_coinsPlayer2.Text));
                }
                else
                {
                    btn_joinPlayer2.IsEnabled = false;
                }

                if (!btn_joinPlayer3.IsVisible)
                {
                    txt_namePlayer3.IsReadOnly = true;
                    player3 = new CPlayer(txt_namePlayer3.Text, Int32.Parse(txt_coinsPlayer3.Text));
                }
                else
                {
                    btn_joinPlayer3.IsEnabled = false;
                }

                if (!btn_joinPlayer4.IsVisible)
                {
                    txt_namePlayer4.IsReadOnly = true;
                    player4 = new CPlayer(txt_namePlayer4.Text, Int32.Parse(txt_coinsPlayer4.Text));
                }
                else
                {
                    btn_joinPlayer4.IsEnabled = false;
                }

                if (!btn_joinPlayer5.IsVisible)
                {
                    txt_namePlayer5.IsReadOnly = true;
                    player5 = new CPlayer(txt_namePlayer5.Text, Int32.Parse(txt_coinsPlayer5.Text));
                }
                else
                {
                    btn_joinPlayer5.IsEnabled = false;
                }
            }
            else
            {
                MessageBox.Show("No player on the table.", "Error");
            }
        }

        private void btn_cancelPlayer1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_cancelPlayer2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_cancelPlayer3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_cancelPlayer4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_cancelPlayer5_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
