using BookProject.DAL.ORM.Context;
using BookProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Views.Admin.BookView
{
    public partial class BookPage : Form
    {
        public BookPage()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        void CategoryList()
        {
            cmbBookCategoriesAdd.DataSource = db.Categories.Where(x => x.Status == DAL.ORM.Enum.Status.Active).ToList();
            cmbBookCategoriesAdd.DisplayMember = "CategoryName";
            cmbBookCategoriesAdd.ValueMember = "Id";
            cmbBookCategoriesAdd.SelectedIndex = -1;
        }

        void AppUserList()
        {
            cmbBookAddAuthor.DataSource = db.AppUsers.Where(x => x.Status == DAL.ORM.Enum.Status.Active).ToList();
            cmbBookAddAuthor.Text = "FullName";
            cmbBookAddAuthor.DisplayMember = "FullName";
            cmbBookAddAuthor.ValueMember = "Id";
            cmbBookAddAuthor.SelectedIndex = -1;
        }

        public void TextBoxEraser()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox4.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public void BookTakeList()
        {
            dataGridView1.DataSource = db.Books.Where(x => x.Status == DAL.ORM.Enum.Status.Active).ToList();
        }
        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookName = txtBookNameAdd.Text;
            book.BookDescription = txtBookDescriptionAdd.Text;
            book.CategoryID = (int)cmbBookCategoriesAdd.SelectedValue;
            book.AppUserID = (int)cmbBookAddAuthor.SelectedValue;
            db.Books.Add(book);
            db.SaveChanges();

            BookTakeList();
            TextBoxEraser();
        }

        private void BookPage_Load(object sender, EventArgs e)
        {
            CategoryList();
            BookTakeList();
            AppUserList();
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            Book book = db.Books.FirstOrDefault(x => x.ID == id);
            book.BookName = txtBookNameUpdate.Text;
            book.BookDescription = txtBookDescriptionUpdate.Text;
        }
        int id;
        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            Book book = db.Books.FirstOrDefault(x => x.ID == id);
            book.Status = DAL.ORM.Enum.Status.Deleted;
            db.SaveChanges();
            BookTakeList();
            TextBoxEraser();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookNameUpdate.Text = dataGridView1.CurrentRow.Cells["BookName"].Value.ToString();
            txtBookDescriptionUpdate.Text = dataGridView1.CurrentRow.Cells["BookDescription"].Value.ToString();
            txBookDelete.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }
    }
}
