using System;
using System.Collections.Generic;
using System.Linq;
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
using Prism.Mvvm;
using Lioranboard_1_Json_to_2.ViewModels;

namespace Lioranboard_1_Json_to_2.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LB2Box_OnGotFocus(object sender, RoutedEventArgs e)
        {
            LB2Box.SelectAll();
        }

        private void LB1Box_OnGotFocus(object sender, RoutedEventArgs e)
        {
            LB1Box.SelectAll();
        }

        private void LB2Box_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LB2Box.SelectAll();
        }

        private void LB1Box_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LB1Box.SelectAll();
        }

        private void LB2Box_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!LB2Box.IsKeyboardFocusWithin)
            {
                e.Handled = true;
                LB2Box.Focus();
            }
        }

        private void LB1Box_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!LB1Box.IsKeyboardFocusWithin)
            {
                e.Handled = true;
                LB1Box.Focus();
            }
        }

        private void LB1Box_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LB2Box.Focus();
                (DataContext as MainWindowViewModel).ConvertJsonCommand.Execute();
            }
        }
    }
}
