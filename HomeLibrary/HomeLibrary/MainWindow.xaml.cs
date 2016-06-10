using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace HomeLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Book> BooksList { get; set; }
        public delegate void AddItemDelegate();
        AddBookWindow addBookWindow;
        public MainWindow()
        {
            InitializeComponent();
            BooksList = new ObservableCollection<Book>();
            listView.ItemsSource = BooksList;
        }

        private void AddBookButtonClick(object sender, RoutedEventArgs e)
        {
            addBookWindow = new AddBookWindow();
            addBookWindow.Show();
            addBookWindow.AddItemCallback = new AddItemDelegate(AddNewBook);
        }

        private void AddNewBook()
        {
            Book newBook = null;
            string author = addBookWindow.AuthorTextBox.Text;
            string title = addBookWindow.TitleTextBox.Text;
            string year = addBookWindow.YeraTextBox.Text;
            int pages = 0;

            try
            {
                pages = int.Parse(addBookWindow.PagesTextBox.Text);
            }
            catch (Exception e)
            {
                pages = 0;
            }

            string readed = (string)addBookWindow.ReadedComboBox.SelectedItem;
            if (readed == "Yes")
            {
                Mark mark = SetMark();
                newBook = new ReadedBook(author, title, year, pages, mark);
            }
            else
            {
                Priority priority = SetPriority();
                newBook = new BookToRead(author, title, year, pages, priority);

            }

            BooksList.Add(newBook);
            SortBooks();
        }

        private Priority SetPriority()
        {
            Priority priority;
            if (addBookWindow.PriorityComboBox.SelectedItem != null)
            {
                priority = (Priority)Enum.Parse(typeof(Priority), (string)addBookWindow.PriorityComboBox.SelectedItem);
            }
            else
            {
                priority = Priority.ICan;
            }

            return priority;
        }

        private Mark SetMark()
        {
            Mark mark;
            if (addBookWindow.MarkComboBox.SelectedItem != null)
            {
                mark = (Mark)Enum.Parse(typeof(Mark), (string)addBookWindow.MarkComboBox.SelectedItem);

            }
            else
            {
                mark = Mark.VeryPoor;
            }

            return mark;
        }

        private void RemoveButtonClick(object sender, RoutedEventArgs e)
        {
            Book bookToRemove = listView.SelectedItem as Book;
            BooksList.Remove(bookToRemove);
            SortBooks();
        }

        private ObservableCollection<Book> SortBooks()
        {
            ObservableCollection<Book> bookSort = new ObservableCollection<Book>(
                BooksList.OrderBy(book => book)
            );
            BooksList = bookSort;
            listView.ItemsSource = BooksList;
            return BooksList;
        }

    }
}