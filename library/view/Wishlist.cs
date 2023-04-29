
using library.biblioteca;
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
    public partial class Wishlist : Form
    {

        private BookLibrary bookLibrary;
        public Wishlist()
        {
            InitializeComponent();

            this.bookLibrary = new BookLibrary();

            this.bookLibrary.createTable(lstBooks);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddBook newBook=new AddBook(this.bookLibrary);

            if (newBook.ShowDialog() == DialogResult.OK)
            {
                this.bookLibrary.createTable(lstBooks);
            }
        }
    }
}
