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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<string> books = new List<string>();
        Window3 bookList = new Window3();
        public Window2()
        {
            InitializeComponent();
            bookList.Show();
        }
        public Window2(List<string> books)
        {
            //Second constructor takes a string list to edit books
            InitializeComponent();
            bookList.Show();
            this.books = books;
            foreach (string book in books)
            {
                bookList.AddBook(book);
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Remove all items from book combobox and add book values
            comboBox_book.Items.Clear();
            if (comboBox.SelectedIndex==0)
            {
                comboBox_book.Items.Add("Da Vinci Şifresi");
                comboBox_book.Items.Add("Melekler ve Şeytanlar");
                comboBox_book.Items.Add("Dijital Kale");
            }
            else if (comboBox.SelectedIndex==1)
            {
                comboBox_book.Items.Add("Muhteşem Gatsby");
                comboBox_book.Items.Add("Uğultulu Tepeler");
                comboBox_book.Items.Add("Moby Dick");
            }
            else
            {
                comboBox_book.Items.Add("Dune");
                comboBox_book.Items.Add("Karanlığın Son Eli");
                comboBox_book.Items.Add("Neuromancer");
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Add book to listbox of Window3 and books list
            books.Add(comboBox_book.SelectedItem.ToString());
            bookList.AddBook(comboBox_book.SelectedItem.ToString());
            MessageBox.Show("Book added.");
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            //Enabling button 1 when checkbox is checked
            if (checkBox.IsChecked.Value)
            {
                button1.IsEnabled = true;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Close this and bookList window then open Window4 with books parameter
            this.Close();
            bookList.Close();
            new Window4(books).Show();
        }
    }
}
