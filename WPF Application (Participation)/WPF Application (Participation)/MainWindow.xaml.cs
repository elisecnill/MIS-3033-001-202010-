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

namespace WPF_Application__Participation_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Elise Nill
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this is where we will calculate age
            var dob = DateTime.Now - dtp.SelectedDate.Value;
            var age = dob.TotalDays / 365;
            MessageBox.Show(Convert.ToString(age));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button(object sender, MouseEventArgs e)
       {
            btngo.Background = new SolidColorBrush(Colors.Yellow);
        }
    }
}
