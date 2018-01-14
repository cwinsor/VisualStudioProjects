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

namespace Wpf06_Controls
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Full Name: ");
            sb.Append(FullName.Text);
            sb.Append(" Gender: ");
            sb.Append( (bool) MaleRadioButton.IsChecked ? "Male" : "Female");
            sb.Append(" Devices: ");
            sb.Append((bool)CheckboxDesktop.IsChecked ? "Desktop" : "");
            sb.Append((bool)CheckboxLaptop.IsChecked ? "Laptop" : "");
            sb.Append((bool)CheckboxTablet.IsChecked ? "Tablet" : "");
            sb.Append(" Job: ");
            sb.Append(JobComboBox.Text.ToString());
            sb.Append(" Delivery Date: ");
            sb.Append(DeliveryDate.ToString());
            MessageBox.Show(sb.ToString());
            


        }

        private void JobComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newlySelectedItem = e.AddedItems[0];
            MessageBox.Show(newlySelectedItem.ToString());

        }
    }
}
