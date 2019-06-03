using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPizzaInvoice
{
    class Pizza
    {

        public PictureBox PizzaPicture { get; set; }

        public Pizza()
        {
            PizzaPicture.Image = Resource1.PizzaPic;

        }
        
    }
}
