
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
using static HomeLibrary.MainWindow;

namespace HomeLibrary
{
    /// <summary>
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        public AddItemDelegate AddItemCallback;
        public AddBookWindow()
        {
            InitializeComponent();
            MarkComboBox.Visibility = System.Windows.Visibility.Collapsed;
            PriorityComboBox.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void ReadedComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ReadedComboBox.SelectedItem as string == "Yes")
            {
                MarkComboBox.Visibility = System.Windows.Visibility.Visible;
                PriorityComboBox.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                PriorityComboBox.Visibility = System.Windows.Visibility.Visible;
                MarkComboBox.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void ReadedComboBoxLoad(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Yes");
            data.Add("No");
            ReadedComboBox.ItemsSource = data;
        }

        private void PriorityComboBoxLoad(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Must");
            data.Add("NotMust");
            data.Add("ICan");
            PriorityComboBox.ItemsSource = data;
        }

        private void MarkComboBoxLoad(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("VeryPoor ");
            data.Add("Poor");
            data.Add("Fair");
            data.Add("Good");
            data.Add("VeryGood");
            data.Add("Excellent");
            MarkComboBox.ItemsSource = data;
        }

        private void OkButtonClick(object sender, RoutedEventArgs e)
        {
            AddItemCallback();
            this.Close();
        }
    }
}
