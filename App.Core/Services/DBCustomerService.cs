using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;


namespace App.Core.Services
{
    public class DBCustomerService : ICustomerService
    {
        private readonly string _connectionString;

        public DBCustomerService(string connectionString)
        {
            _connectionString = connectionString;
        }

        Customer ICustomerService.Add(Customer customer)
        {
            customer.Id = "c_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Customer(Id, Name, Email, Phone, Address, Status) " +
                             "VALUES(@Id, @Name, @Email, @Phone, @Address, @Status)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters.AddWithValue("@Status", customer.Status.ToString());

                int rows = cmd.ExecuteNonQuery();
                return rows > 0 ? customer : null;
            }
        }

        bool ICustomerService.Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Customer WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        List<Customer> ICustomerService.GetAll()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer c = new Customer();
                    c.Id = reader["Id"].ToString();
                    c.Name = reader["Name"].ToString();
                    c.Email = reader["Email"].ToString();
                    c.Phone = reader["Phone"].ToString();
                    c.Address = reader["Address"].ToString();
                    c.Status = Enum.TryParse<CustomerStatus>(
                                   reader["Status"].ToString(), out var s)
                                   ? s : CustomerStatus.Active;
                    customers.Add(c);
                }
            }

            return customers;
        }

        Customer ICustomerService.GetById(string id)
        {
            Customer customer = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Customer WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    customer = new Customer();
                    customer.Id = reader["Id"].ToString();
                    customer.Name = reader["Name"].ToString();
                    customer.Email = reader["Email"].ToString();
                    customer.Phone = reader["Phone"].ToString();
                    customer.Address = reader["Address"].ToString();
                    customer.Status = Enum.TryParse<CustomerStatus>(
                                         reader["Status"].ToString(), out var s)
                                         ? s : CustomerStatus.Active;
                }
            }

            return customer;
        }

        List<Customer> ICustomerService.Search(string query)
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM Customer
                               WHERE Name  LIKE @Query
                               OR  Email   LIKE @Query
                               OR  Phone   LIKE @Query";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Query", "%" + query + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer c = new Customer();
                    c.Id = reader["Id"].ToString();
                    c.Name = reader["Name"].ToString();
                    c.Email = reader["Email"].ToString();
                    c.Phone = reader["Phone"].ToString();
                    c.Address = reader["Address"].ToString();
                    c.Status = Enum.TryParse<CustomerStatus>(
                                   reader["Status"].ToString(), out var s)
                                   ? s : CustomerStatus.Active;
                    customers.Add(c);
                }
            }

            return customers;
        }

        bool ICustomerService.Update(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE Customer " +
                             "SET Name=@Name, Email=@Email, Phone=@Phone, " +
                             "    Address=@Address, Status=@Status " +
                             "WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters.AddWithValue("@Status", customer.Status.ToString());

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
    }
}