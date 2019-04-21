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

namespace BookProject.Views.Admin.HomeView
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book = db.Books.FirstOrDefault(x => x.Status.ToString() == "2");
            label1.Text = book.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book = db.Books.FirstOrDefault(x => x.Status.ToString() == "3");
            label1.Text = book.ToString();
        }
    }
}
