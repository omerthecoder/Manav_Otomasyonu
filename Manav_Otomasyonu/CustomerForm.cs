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
    public partial class CustomerForm : Form
    {
        CustomerRepo cr;
        Customer SelectedCustomer = null;
        public CustomerForm()
        {
            InitializeComponent();
            cr = new CustomerRepo();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            int Id = Convert.ToInt32(this.Tag);
            if (Id>0)
            {
                Customer customer = cr.GetById(Id);
                if (customer!=null)
                {
                    SelectedCustomer = customer;

                    txtFirstName.Text = customer.FirstName;
                    txtLastName.Text = customer.LastName;
                    txtCountry.Text = customer.Country;
                    txtCity.Text = customer.City;
                    txtRegion.Text = customer.Region;
                    txtPostalCode.Text = customer.PostalCode;
                    txtPhone.Text = customer.Phone;
                    txtAddress.Text = customer.Address;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
        }

        private void FormSave()
        {
            if (SelectedCustomer==null)
            {
                SelectedCustomer = new Customer();
            }
            SelectedCustomer.FirstName = txtFirstName.Text;
            SelectedCustomer.LastName = txtLastName.Text;
            SelectedCustomer.Country = txtCountry.Text;
            SelectedCustomer.City = txtCity.Text;
            SelectedCustomer.Region = txtRegion.Text;
            SelectedCustomer.PostalCode = txtPostalCode.Text;
            SelectedCustomer.Phone = txtPhone.Text;
            SelectedCustomer.Address = txtAddress.Text;

            if (Convert.ToInt32(this.Tag) == 0)
            {
                SelectedCustomer.MusteriID = cr.Create(SelectedCustomer);
                this.Tag = SelectedCustomer.MusteriID;
            }
            else
            {
                cr.Update(SelectedCustomer);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
