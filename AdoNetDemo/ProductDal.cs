using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
        private void ConnectionControl()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
                _sqlConnection.Open();
        }
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("select * from Products", _sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Product> products = new List<Product>();

            while (sqlDataReader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name = sqlDataReader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"])
                };
                products.Add(product);
            }

            sqlDataReader.Close();
            _sqlConnection.Close();
            return products; ;
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand(
                "Insert into Products values(@name,@unitPrice,@stockAmount)",_sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand(
                "Update Products set Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount where Id=@id", _sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", product.Id);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public DataTable GetAll2()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
                _sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Products", _sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            sqlDataReader.Close();
            _sqlConnection.Close();
            return dataTable;
        }
    }
}
