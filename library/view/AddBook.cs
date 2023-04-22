using library.biblioteca;
using library.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.view
{
    public partial class AddBook : Form
    {
        private BookLibrary bookLibrary;

        public AddBook()
        {
            InitializeComponent();
        }

        public AddBook(BookLibrary bookLibrary)
        {
            InitializeComponent();
            this.bookLibrary = bookLibrary;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validateForm() == true) 
            {
                Book book = new Book();

                book.setTitle(txtTitle.Text);
                book.setAuthor(txtAuthor.Text);
                book.setGenre(txtGenre.Text);
                book.setYear(Int32.Parse(txtYear.Text));

                this.bookLibrary.addBook(book);

                this.DialogResult = DialogResult.OK;

                MessageBox.Show("Book added", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private bool validateForm()
        {
            String text = "";

            if (txtTitle.Text.Equals(""))
            {
                text += "Enter the title of the book\n";
            }

            if (txtAuthor.Text.Equals(""))
            {
                text += "Entre the author of the book\n";
            }

            if (txtGenre.Text.Equals(""))
            {
                text += "Enter the genre of the book\n";
            }

            if (txtYear.Text.Equals(""))
            {
                text += "Enter the year the book was published\n";
            }

            if (text.Length > 0)
            {
                MessageBox.Show(text,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
