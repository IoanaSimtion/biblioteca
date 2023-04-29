using library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.biblioteca
{
    public class BookLibrary
    {
        private List<Book> books;

        public BookLibrary()
        {
            books = new List<Book>();

            load();
        }


        public void load()
        {
            Book book1 = new Book("The Silent Patient", "Alex Michaelides", "psychological thriller", 2019);
            Book book2 = new Book("Perfume", " Patrick Süskind", "mystery", 1985);
            Book book3 = new Book("The Picture of Dorian Gray", "Oscar Wilde", "fiction", 1890);

            this.books.Add(book1);
            this.books.Add(book2);
            this.books.Add(book3);
        }

        public void addBook(Book book)
        {
            this.books.Add(book);
        }

        public void createTable(ListView table)
        {
            table.Clear();
            table.Columns.Add("Title",220,HorizontalAlignment.Center);
            table.Columns.Add("Author",200,HorizontalAlignment.Center);
            table.Columns.Add("Genre", 200, HorizontalAlignment.Center);
            table.Columns.Add("Year",200, HorizontalAlignment.Center);

            foreach(Book book in books)
            {
                ListViewItem line=new ListViewItem();
                line.Text = book.getTitle();
                line.SubItems.Add(book.getAuthor());
                line.SubItems.Add(book.getGenre());
                line.SubItems.Add(book.getYear().ToString());

                table.Items.Add(line);
            }
        }
    }
}
