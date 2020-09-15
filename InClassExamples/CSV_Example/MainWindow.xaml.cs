using System;
using System.Collections.Generic;
using System.IO;
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

namespace CSV_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declared here so all methods can use it
        string filePath = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            filePath = txtFilePath.Text;

            //did they give us a valid file path
            if(File.Exists(filePath) == true)
            {
                btnProcess.IsEnabled = true;
                btnValidate.IsEnabled = false;
                txtFilePath.IsEnabled = false;

            }
            else
            {
                MessageBox.Show("Invalid file path. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
               
                //these all do the same thing -- clearing the textbox
                txtFilePath.Clear();
                txtFilePath.Text = "";
                txtFilePath.Text = string.Empty;
                txtFilePath.Focus();
            }
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            //when they click process button that is when file is read
            string[] lines = File.ReadAllLines(filePath);
            double sum = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                var pieces = line.Split(',');
                double price;

                if(double.TryParse(pieces[2], out price) == true)
                {
                    sum += Convert.ToDouble(pieces[2]);
                }
                else
                {
                    //this is i + 1 because the list starts at index 0
                    MessageBox.Show($"Sorry, there was an invalid price on line {i + 1}");
                }
                lstFile.Items.Add(pieces[1]); //add the current line to the list box
                
            }
            MessageBox.Show($"The sum of all the product prices is {sum.ToString("C2")}");
        }
    }
}
