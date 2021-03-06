﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPizzaInvoice
{
    public class InvoiceDA
    {
        public static List<InvoiceData> GetAllInvoices()
        {
            List<InvoiceData> allInvoice = new List<InvoiceData>();

            SqlConnection conn = PizzaDB.GetPizzaConnection();

            string selectString = "Select * from summerOrder Order by BranchName";

            SqlCommand selectCommand = new SqlCommand(selectString, conn);

            // moved the try catch to the form

                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while(reader.Read())
                {
                    InvoiceData i = new InvoiceData();
                    i.Id = Convert.ToInt16(reader["Id"]);
                    i.SellDate = Convert.ToDateTime(reader["SellDate"]);
                    i.BranchName = reader["BranchName"].ToString();
                    i.TotalOrder = Convert.ToDecimal(reader["TotalOrder"]);

                    allInvoice.Add(i);

                }
                conn.Close();
           

            return allInvoice;
        }
    }
}
