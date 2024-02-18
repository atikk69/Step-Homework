using CodeFirst;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var connectionString = "data source=localhost; initial catalog=academy; integrated security=true; trust server certificate = true;";


void InsertProduct(Product product)
{
    string sql = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";

    using (var connection = new SqlConnection(connectionString))
    {
        connection.Open();
        connection.Execute(sql, product);
    }
}

 List<Product> GetAllProducts()
{
    string sql = "SELECT * FROM Products";

    using (var connection = new SqlConnection(connectionString))
    {
        connection.Open();
        return connection.Query<Product>(sql).ToList();
    }
}
void UpdateProduct(Product product)
{
    string sql = "UPDATE Products SET Name = @Name, Price = @Price WHERE Id = @Id";

    using (var connection = new SqlConnection(connectionString))
    {
        connection.Open();
        connection.Execute(sql, product);
    }
}

 void DeleteProduct(int productId)
{
    string sql = "DELETE FROM Products WHERE Id = @Id";

    using (var connection = new SqlConnection(connectionString))
    {
        connection.Open();
        connection.Execute(sql, new { Id = productId });
    }
}
