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
    using Repository;
    using Entities;
    public partial class Form1 : Form
    {
        CustomerRepo cr;
        ProductRepo pr;
        CategoryRepo catr;
        public Form1()
        {
            InitializeComponent();
            cr = new CustomerRepo();
            pr = new ProductRepo();
            catr = new CategoryRepo();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (tcManav.SelectedTab.Name=="tpCustomer")
            {
                CustomerForm cf = new CustomerForm();
                cf.ShowDialog();
                FillCustomerGrid();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrids();
        }

        private void FillGrids()
        {
            FillCustomerGrid();
            FillProductGrid();
            FillCategoryGrid();
        }

        private void FillCategoryGrid()
        {
            grdCategories.DataSource = catr.Get();
        }

        private void FillProductGrid()
        {
            grdProducts.DataSource = pr.Get();
        }

        private void FillCustomerGrid()
        {
            
            grdCustomers.DataSource = cr.Get();
        }

        private void grdCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            Customer customer = (grdCustomers.DataSource as List<Customer>)[e.RowIndex];
            CustomerForm cf = new CustomerForm();
            cf.Tag = customer.MusteriID;
            cf.ShowDialog();
            FillCustomerGrid();
        }
    }
}
