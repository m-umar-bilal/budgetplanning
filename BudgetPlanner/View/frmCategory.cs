using BudgetPlanner.Controller;
using BudgetPlanner.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlanner.View
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            LstCat.DataSource = null;
            LstCat.DataSource = CategoryDb.getCategoriesInList();
            LstCat.DisplayMember = "Name";
            LstCat.ValueMember = "CID";


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Name = txtCategory.Text;
            CategoryDb.addCategory(c);
            Category cat = new Category();
            cat.Name = txtCategory.Text;
            init();
            //CategoryDb.getCategoriesInList().Add(cat);

        }
    }
}
