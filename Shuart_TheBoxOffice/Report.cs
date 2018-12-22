using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuart_TheBoxOffice
{
    public partial class Report : Form
    {
        private List<String> sales = new List<string>();

        public Report()
        {
            InitializeComponent();
        }

        public Report(List<String> sales, String[] movies, int totalTickets)
        {
            //base init
            InitializeComponent();

            //set up options - passed in from theatre set up
            comboTheatreSelect.Items.Add("All Sales");
            comboTheatreSelect.Items.AddRange(movies);
            comboTheatreSelect.SelectedIndex = 0; //set first item to be selected

            //save sales info for rest of this class
            this.sales = sales;

            //build string for whats shown in details text block
            String details = "";
            foreach (String sale in sales)
            {
                details += sale.ToString() + " \r\n"; //concatinates full details string and creates new line
            }

            //apply built string to details block
            txtDetails.Text = details;

            //define total sales
            txtTotalSales.Text = sales.Count().ToString();
            txtTotalTickets.Text = totalTickets.ToString();
        }

        private void comboTheatreSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //build string for whats shown in details text block
            String details = "";
            foreach (String sale in sales)
            {
                //check against movie filter
                String movie = sale.ToString().Split(':')[0]; //get everything before the ':'
                if(comboTheatreSelect.SelectedItem.ToString() == movie || comboTheatreSelect.SelectedItem.ToString() == "All Sales")
                {
                    //concatinates full details string and creates new line
                    details += sale.ToString() + " tickets \r\n"; 
                }
            }

            //apply built string to details block
            txtDetails.Text = details;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
