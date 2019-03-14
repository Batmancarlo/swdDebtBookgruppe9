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
using System.Windows.Shapes;

namespace Debtbook
{
    /// <summary>
    /// Interaction logic for DebitorWindow.xaml
    /// </summary>
    public partial class DebitorWindow : Window
    {
        public DebitorWindow()
        {
            InitializeComponent();
        }

        private void DgDebitors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
