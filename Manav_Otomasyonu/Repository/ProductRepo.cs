using Manav_Otomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Manav_Otomasyonu.Repository
{
    public class ProductRepo : RepositoryBase, IRepository<Product>
    {
        public int Create(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Get()
        {
            List<Product> products = new List<Product>();
            try
            {
                SqlCommand command = new SqlCommand("select ProductID,ProductName,CategoryID,UnitPrice,UnitsInStock from Product", this.con);
                if (this.con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = ProductMapping(reader);
                    products.Add(product);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                if (this.con.State==ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return products;
        }

        private Product ProductMapping(SqlDataReader reader)
        {
            Product product = new Product() {ProductID=Convert.ToInt32(reader["ProductID"]),ProductName=reader["ProductName"].ToString(),CategoryID=Convert.ToInt32(reader["CategoryID"]),UnitPrice=Convert.ToDecimal(reader["UnitPrice"]),UnitsInStock=Convert.ToInt32(reader["UnitsInStock"]) };
            return product;
        }

        public Product GetById(int id)
        {
            Product product = new Product();
            try
            {
                SqlCommand command = new SqlCommand("select ProductID,ProductName,CategoryID,UnitPrice,UnitsInStock from Product where ProductID=@ProductID", this.con);
                command.Parameters.AddWithValue("@ProductID", id);
                if (this.con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    product = ProductMapping(reader);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (this.con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return product;
        }

        public int Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
