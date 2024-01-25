using System.Data.SqlClient;
using System.Threading.Channels;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.AddJsonFile("appsettings.json");
var config = builder.Build();

using SqlConnection conn = new(config.GetConnectionString("Default"));

conn.Open();

    var command = new SqlCommand("select * from People",conn);
{
   using var res = command.ExecuteReader();

    while (res.Read())
    {
        Console.WriteLine($"{res[0]}\t{res[1]}");
    }
}

command = new SqlCommand("insert into People (Name,Surname,Age) values (N'Shagman',N'Garakishiyev',31)", conn);
var res2 = command.ExecuteNonQuery();
Console.WriteLine(res2);

command = new SqlCommand("insert into People (Name,Surname,Age) values (N'test1',N'test1',32)", conn);
var res7 = command.ExecuteNonQuery();
Console.WriteLine(res7);
command = new SqlCommand("insert into People (Name,Surname,Age) values (N'test1',N'test1',32)", conn);   
var res6 = command.ExecuteNonQuery();
Console.WriteLine(res6);


command = new SqlCommand("select COUNT(*) from People", conn);

var res3 = command.ExecuteScalar();
Console.WriteLine(res3);

command = new SqlCommand("select MAX(Age) from People", conn);

var res4 = command.ExecuteScalar();    
Console.WriteLine(res4);
command = new SqlCommand("select MIN(Age) from People", conn);

var res5 = command.ExecuteScalar();    
Console.WriteLine(res5);













