using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadPizzaInvoice
{
    public class PizzaDB
    {
        public static SqlConnection GetPizzaConnection()
        {
            // connection string
            // remote
            //string connectionString = @"Data Source=pizzaEmporium.db.2823567.hostedresource.com;Initial Catalog=pizzaEmporium;Persist Security Info=True;User ID=pizzaEmporium;Password=C#1434!spring";
           string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=N:\1434\Spring2019TH\ReadPizzaData\PizzaEmporiumData\ReadPizzaInvoice\Invoices.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}
