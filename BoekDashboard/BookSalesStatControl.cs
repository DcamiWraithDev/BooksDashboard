using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoekDashboard
{
    public partial class BookSalesStatControl : UserControl
    {
        public BookSalesStatControl()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            titleLbl.Text = title;
        }
        public void SetName(string name)
        {
            nameLbl.Text = name;
        }

        public void SetPrice(string price)
        {
            priceLbl.Text = price;
        }


        public void SetAmount(string amount)
        {
            amountLbl.Text = amount;
        }
    }

}
