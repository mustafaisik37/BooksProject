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

namespace BookProject.Views.Admin.CategoryView
{
    public partial class CategoryPage : Form
    {
        public CategoryPage()
        {
            InitializeComponent();
        }

        private void grplist_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        ProjectContext db = new ProjectContext();
        public void TexBoxEraser()
        {
            foreach (Control item in grpadd.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        } // TEXT BOX İÇİNİ TEMİZLEME METHODU
        public void CategoryList()
        {
            dataGridView1.DataSource = db.Categories.Where(x => x.Status == DAL.ORM.Enum.Status.Active || x.Status == DAL.ORM.Enum.Status.Updated).ToList();

        } // KATEGORİ LİSTELEME İŞLEMİ METHODU
        private void btncatadd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = textadd.Text;
            category.Description = textdecad.Text;

            db.Categories.Add(category);
            db.SaveChanges();

            CategoryList();
            TexBoxEraser();
        } // EKLEME İŞLEMİ

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            CategoryList();
        } // YÜKLENİRKEN EKRANI VERİ GELİYOR
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textnameaup.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();

            textdeup.Text= dataGridView1.CurrentRow.Cells["Description"].Value.ToString();

            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            textdel.Text= dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        } // SEÇTİGİMİZ YER CELL CLİCK İŞLEMİ

        private void buttonup_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);

            category.CategoryName = textnameaup.Text;
            category.Description = textdeup.Text;
            category.UpdateDate = DateTime.Now;
            category.DeleteDate = DateTime.Now;
            category.Status = DAL.ORM.Enum.Status.Updated;
            db.SaveChanges();

            CategoryList();
            TexBoxEraser();
        } // UPDATE İŞLEMİ

        private void buttondel_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x=> x.ID==id);
            category.Status = DAL.ORM.Enum.Status.Deleted;
            category.DeleteDate = DateTime.Now;

            db.SaveChanges();
            CategoryList();
            TexBoxEraser();
        } //DELETE İŞLEMİ
    }
}
