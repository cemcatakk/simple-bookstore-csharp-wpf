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

namespace Bookstore
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        List<string> books;
        public Window4(List<string> books)
        {
            //Get books list from parameter and add it to listbox
            InitializeComponent();
            this.books = books;
            foreach (string book in books)
            {
                listBox.Items.Add(book);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Close this form and pass books list to Window2 and open 
            this.Close();
            new Window2(books).Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            //If any item is selected, then remove book from both listbox and list
            if (listBox.SelectedIndex>=0)
            {
                listBox.Items.Remove(listBox.SelectedItem);
                books.Remove(listBox.SelectedItem.ToString());
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
