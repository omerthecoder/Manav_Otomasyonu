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
    public class CategoryRepo : RepositoryBase, IRepository<Category>
    {
        public void Create(Category item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> Get()
        {
            List<Category> categories = new List<Category>();
            try
            {
                SqlCommand command = new SqlCommand("select CategoryID,CategoryName from Categories", this.con);
                if (this.con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Category category = CategoryMapping(reader);
                    categories.Add(category);
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
            return categories;
        }

        private Category CategoryMapping(SqlDataReader reader)
        {
            Category category = new Category() { CategoryID=Convert.ToInt32(reader["CategoryID"]),CategoryName=reader["CategoryName"].ToString() };
            return category;

        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
