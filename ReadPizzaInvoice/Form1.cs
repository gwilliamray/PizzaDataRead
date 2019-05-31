using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPizzaInvoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<InvoiceData> invoices = new List<InvoiceData>();
        private void Form1_Load(object sender, EventArgs e)
        {
            invoices = InvoiceDA.GetAllInvoices();

            ShowAllInvoices();
        }

        private void ShowAllInvoices()
        {
            lstAllInvoices.Items.Clear();
            foreach(InvoiceData i in invoices)
            {
                lstAllInvoices.Items.Add(i);
            }
        }
    }
}
