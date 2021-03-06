// <auto-generated />
using PipeLines.Model;
using PipeLines.ViewModel;
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

namespace PipeLines
{
    /// <summary>
    /// This page contains 3 buttons, to start the medium maps.
    /// </summary>

    public partial class Page2 : Page
    {
        GameWindowViewModel gwvm;
        public Page2()
        {
            InitializeComponent();
            gwvm = new GameWindowViewModel();
            gwvm.Diff = "MEDIUM";
        }

        private void click4(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow(LevelNumber.lvl_4, gwvm);
            gameWindow.Show();
        }

        private void click5(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow(LevelNumber.lvl_5, gwvm);
            gameWindow.Show();
        }

        private void click6(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow(LevelNumber.lvl_6, gwvm);
            gameWindow.Show();
        }
    }
}
