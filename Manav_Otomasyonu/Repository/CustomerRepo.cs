using Manav_Otomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav_Otomasyonu.Repository
{
    using Entities;
    using System.Data.SqlClient;
    using System.Data;
    public class CustomerRepo : RepositoryBase, IRepository<Customer>
    {

        public CustomerRepo() : base()
        {

        }
        public void Create(Customer item)
        {

            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Get()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                SqlCommand command = new SqlCommand("select MusteriID,FirstName,LastName,Country,City,Region,PostalCode,Phone,Address from customer", this.con);
                if (this.con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = CustomerMapping(reader);
                    customers.Add(customer);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return customers;
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }
        private Customer CustomerMapping(SqlDataReader reader)
        {
            Customer customer = new Customer() { MusteriID = Convert.ToInt32(reader["MusteriID"]), FirstName = reader["FirstName"].ToString(), LastName = reader["LastName"].ToString(), Country = reader["Country"].ToString(), City = reader["City"].ToString(), Region = reader["Region"].ToString(), PostalCode = reader["PostalCode"].ToString(), Phone = reader["Phone"].ToString(), Address = reader["Address"].ToString() };
            return customer;
        }
    }
}
