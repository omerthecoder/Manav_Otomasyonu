using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav_Otomasyonu
{
    using Entities;
    using Repository;
    public partial class CategoryForm : Form
    {
        CategoryRepo catr;
        Category selectedCategory = null;
        public CategoryForm()
        {
            InitializeComponent();
            catr = new CategoryRepo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            int id = Convert.ToInt32(this.Tag);
            if (id>0)
            {
                selectedCategory=catr.GetById(id);
            }
            
        }
    }
}
