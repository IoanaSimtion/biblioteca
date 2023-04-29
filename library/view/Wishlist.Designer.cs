namespace library.view
{
    partial class Wishlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListView();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(755, 292);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(202, 45);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Add Book";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstBooks.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBooks.Location = new System.Drawing.Point(12, 12);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(945, 259);
            this.lstBooks.TabIndex = 3;
            this.lstBooks.UseCompatibleStateImageBehavior = false;
            this.lstBooks.View = System.Windows.Forms.View.Details;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveBook.Location = new System.Drawing.Point(755, 343);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(202, 45);
            this.btnRemoveBook.TabIndex = 4;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBook.Location = new System.Drawing.Point(755, 395);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(202, 40);
            this.btnUpdateBook.TabIndex = 5;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // Wishlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 447);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.btnCreate);
            this.Name = "Wishlist";
            this.Text = "WISHLIST";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCreate;
        private ListView lstBooks;
        private Button btnRemoveBook;
        private Button btnUpdateBook;
    }
}