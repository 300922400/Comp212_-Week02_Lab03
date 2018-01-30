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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cboSemester.ItemsSource = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };
            lstCourses.ItemsSource = new List<string> { "COMP100", "COMP213", "COMP120", "COMP125", "COMP123", "COMP122", "MATH185", "COMM171" };
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ClickClearBtn(object sender, RoutedEventArgs e)
        {
            cboSemester.SelectedIndex = 1;
            txtName.Text = "Narendra Pershad";
            lstCourses.UnselectAll();
            rbtnDomestic.IsChecked = true;
        }

        private void ClickOkBtn(object sender, RoutedEventArgs e)
        {
            String result = "";

            result += txtName.Text;
            
            result += "\nYour selected semester is "+cboSemester.Text + " ";

            result += (rbtnDomestic.IsChecked ?? true) ? " (DOM)" : " (INT)";

            foreach (string item in lstCourses.SelectedItems)
                result += item + ", ";

            MessageBox.Show(result, "User data", MessageBoxButton.OK);
        }
    }
}
