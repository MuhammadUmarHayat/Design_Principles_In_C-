using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;
using System.Xml.Linq;


namespace RepositoryExmple1
{
    internal class CustomerRepository:ICustomer
    {
        private string conString = @"";
        public IEnumerable<Customer> GetAllCustomers()
        {
            using (var connection = new SqlConnection(conString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Customers", connection);
                var reader = command.ExecuteReader();
                var customers = new List<Customer>();

                while (reader.Read())
                {
                    customers.Add(new Customer
                    {
                        customerId = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2)
                    });
                }

                return customers;
            }
        }
        public Customer GetById(int id)
        {
                using (var connection = new SqlConnection(conString))
                {
                    connection.Open();
                    var command = new SqlCommand("SELECT * FROM Customers WHERE CustomerId = @CustomerId", connection);
                    command.Parameters.AddWithValue("@CustomerId", id);
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Customer
                        {
                            customerId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Email = reader.GetString(2)
                        };
                    }

                    return null;
                }
            }
          public   Boolean addCustomer(Customer customer)
        {
            try {
                SqlConnection sqlConn = new SqlConnection(conString);

                sqlConn.Open();
                string query = "insert into customers(name,email) values('"+customer.Name+"','"+customer.Email+"')";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.ExecuteNonQuery();
                sqlConn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            

        }
       public  Boolean updateCustomer(Customer customer)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(conString);

                sqlConn.Open();
                string query = "";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.ExecuteNonQuery();
                sqlConn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
       public  Boolean deleteCustomer(int id)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(conString);

                sqlConn.Open();
                string query = "";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.ExecuteNonQuery();
                sqlConn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
