using Rrewusz.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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

namespace Rrewusz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player player;
        private Enemy enemy;
        public void LabelControl(string Text)
        {
            foreach (char c in Text)
            {
                Writer.Opacity = 100;
                Writer.Content = Text;
                Thread.Sleep(60);
            }
            Thread.Sleep(1500);
            Writer.Opacity = 0;
        }
        public MainWindow()
        {
            InitializeComponent();
            player = new Player(10, 4);
            enemy = new Enemy(10);
        }

        private void AttackBTN_Click(object sender, RoutedEventArgs e)
        {
            player.Attack(enemy);
            LabelControl($"You have hitted him! Now he has {enemy.GetHP} hp");
            enemy.PlayTurn(player);
        }
    }
}
