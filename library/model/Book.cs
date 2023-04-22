using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.model
{
    public class Book
    {
        private string title;
        private string author;
        private string genre;
        private int year;

        public Book()
        {

        }

        public Book(string title, string author, string genre, int year)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.year = year;
        }


        //metode:

        public void setTitle(String title)
        {
            this.title=title;
        }

        public void setAuthor(String author)
        {
            this.author=author;
        }

        public void setGenre(String genre)
        {
            this.genre = genre;
        }

        public void setYear(int year)
        {
            this.year=year; 
        }

        public string getTitle()
        {
            return this.title;
        }

        public string getAuthor()
        {
            return this.author;
        }

        public string getGenre()
        {
            return this.genre;
        }

        public int getYear()
        {
            return this.year;
        }
    }
}
