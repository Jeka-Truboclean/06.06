using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _06._06
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
        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string product = ProductTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(product))
            {
                ListItem listItem = new ListItem(new Paragraph(new Run(product)));
                productList.ListItems.Add(listItem);
                ProductTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a product name.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}