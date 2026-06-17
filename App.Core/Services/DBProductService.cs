using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Windows.Controls;
using System.Security.AccessControl;


namespace App.Core.Services
{
    public class DBProductService : IProductService
    {
        Product IProductService.Add(Product product)
        {
            product.Id = "p_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string str = $"INSERT INTO PRODUCT(Id,Name,Category,Price,Stock,Status) VALUES(@Id,@Name,@Cat,@Price,@Stock,@Status)";

                SqlCommand cmd = new SqlCommand(str, conn)
                    ;
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Cat", product.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Status", product.Status.ToString());
                cmd.Parameters.AddWithValue("@Stock", product.Stock);

                int rows = cmd.ExecuteNonQuery();
                if
                    (rows > 0) return product;
                else
                    return null;
            }

        }

        bool IProductService.Delete(String id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Product WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("id", id);
                int check = cmd.ExecuteNonQuery();
                if (check <= 0)
                    return false;
                else
                    return true;
            }
        }

        //List<Product> IProductService.GetAll()
        //{
        //    //throw new NotImplementedException();
        //    List<Product> products = new List<Product>();
        //    using(SqlConnection conn =  new SqlConnection(_connectionString)){
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = "Select *  from Product";
        //        cmd.Connection = _connectionString;



        //    }
        //}


        List<Product> IProductService.GetAll()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Product", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product();

                    p.Id = reader["Id"].ToString();
                    p.Name = reader["Name"].ToString();
                    p.Category = Enum.TryParse<ProductCategoryEnum>(reader["Category"].ToString(), out var cat) ? cat : ProductCategoryEnum.Electronics;
                    p.Price = Convert.ToDecimal(reader["Price"]);
                    p.Stock = Convert.ToInt32(reader["Stock"]);
                    p.Status = Enum.TryParse<ProductCategoryStatus>(reader["Status"].ToString(), out var statusEnum) ? statusEnum : ProductCategoryStatus.Active;

                    products.Add(p);
                }
            }

            return products;
        }
        public DBProductService(string consString)
        {
            _connectionString = consString;

        }

        //Product IProductService.GetById(string id)
        //{
        //    throw new NotImplementedException();
        //}

        Product IProductService.GetById(string id)
        {
            Product product = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Product WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    product = new Product();

                    product.Id = reader["Id"].ToString();
                    product.Name = reader["Name"].ToString();

                    product.Category = Enum.TryParse<ProductCategoryEnum>(
                        reader["Category"].ToString(),
                        out var cat)
                        ? cat
                        : ProductCategoryEnum.Electronics;

                    product.Price = Convert.ToDecimal(reader["Price"]);
                    product.Stock = Convert.ToInt32(reader["Stock"]);

                    product.Status = Enum.TryParse<ProductCategoryStatus>(
                        reader["Status"].ToString(),
                        out var statusEnum)
                        ? statusEnum
                        : ProductCategoryStatus.Active;
                }
            }

            return product;
        }

        //List<Product> IProductService.Search(string text, ProductCategoryEnum? category, ProductCategoryStatus? status)
        //{

        //    return null;
        //}

        List<Product> IProductService.Search(string text, ProductCategoryEnum? category, ProductCategoryStatus? status)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = @"SELECT * FROM Product
                         WHERE Name LIKE @Text";

               

                SqlCommand cmd = new SqlCommand(query, conn);

               
               cmd.Parameters.AddWithValue("@Text", "%" + text + "%");

               

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product();

                    p.Id = reader["Id"].ToString();
                    p.Name = reader["Name"].ToString();

                    p.Category = Enum.TryParse<ProductCategoryEnum>(
                        reader["Category"].ToString(),
                        out var cat)
                        ? cat
                        : ProductCategoryEnum.Electronics;

                    p.Price = Convert.ToDecimal(reader["Price"]);
                    p.Stock = Convert.ToInt32(reader["Stock"]);

                    p.Status = Enum.TryParse<ProductCategoryStatus>(
                        reader["Status"].ToString(),
                        out var statusEnum)
                        ? statusEnum
                        : ProductCategoryStatus.Active;

                    products.Add(p);
                }
            }

            return products;
        }

        bool IProductService.Update(Product product)
        {
            using(SqlConnection conn = new SqlConnection(_connectionString)) 
            {
                conn.Open();
                string query = "UPDATE Product SET Name=@Name, Category=@Cat, Price=@Price, Status=@Status WHERE Id=@id ";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Cat", product.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Status", product.Status.ToString());
                cmd.Parameters.AddWithValue("@Stock", product.Stock);

                int rows = cmd.ExecuteNonQuery();
                return (rows > 0);



                throw new NotImplementedException();
            }
             }
        private readonly String _connectionString;

    }
}