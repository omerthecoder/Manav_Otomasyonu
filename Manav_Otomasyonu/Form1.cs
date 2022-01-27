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
            else if(tcManav.SelectedTab.Name == "tpProduct")
            {
                ProductForm pf = new ProductForm();
                pf.ShowDialog();
                FillProductGrid();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tcManav.SelectedTab.Name == "tpCustomer")
            {
                if (grdCustomers.SelectedRows[0].Index>-1)
                {
                    DialogResult dr=MessageBox.Show("Silmek istediğinize emin misiniz?","Uyarı!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (dr==DialogResult.Cancel)
                    {
                        return;
                    }
                    CustomerDelete();
                    FillCustomerGrid();
                }
            }
            else if (tcManav.SelectedTab.Name == "tpProduct")
            {
                if (grdProducts.SelectedRows[0].Index > -1)
                {
                    DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    ProductDelete();
                    FillProductGrid();
                }
            }
        }

        private void ProductDelete()
        {
            Product product = (grdProducts.DataSource as List<Product>)[grdProducts.SelectedRows[0].Index];
            pr.Delete(product.ProductID);
        }

        private void CustomerDelete()
        {
            Customer customer = (grdCustomers.DataSource as List<Customer>)[grdCustomers.SelectedRows[0].Index];
            cr.Delete(customer.MusteriID);
        }

        private void grdProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            ProductForm pf = new ProductForm();
            Product product = (grdProducts.DataSource as List<Product>)[e.RowIndex];
            pf.Tag = product.ProductID;
            pf.ShowDialog();
            FillProductGrid();
        }
    }
}
