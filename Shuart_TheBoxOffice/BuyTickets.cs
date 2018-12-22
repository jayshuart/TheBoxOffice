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
    public partial class BuyTickets : Form
    {
        Decimal[] tickets = new Decimal[5];
        String[] movies = new string[5];
        List<String> sales = new List<String>();

        public BuyTickets()
        {
            InitializeComponent();
        }

        public BuyTickets(String[] movies, Decimal[] ticketsAvailable)
        {
            //normal init
            InitializeComponent();

            //set up options - passed in from theatre set up
            comboMovieSelect.Items.AddRange(movies);
            comboMovieSelect.SelectedIndex = 0; //set first item to be selected
            this.movies = movies;

            //define inital range
            tickets = ticketsAvailable;
            numTickets.Maximum = ticketsAvailable[0];
            txtAvailable.Text = "/" + tickets[0].ToString();

        }

        private void btnCountSales_Click(object sender, EventArgs e)
        {
            //generate report form
            Report details = new Report(sales, movies);

            //switch forms
            details.Show();
            this.Hide();
        }

        private void BuyTickets_Load(object sender, EventArgs e)
        {

        }

        private void comboMovieSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update max able 
            numTickets.Maximum = tickets[comboMovieSelect.SelectedIndex];
            txtAvailable.Text = "/" + tickets[comboMovieSelect.SelectedIndex].ToString();

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //check if we can buy the ticket
            if (numTickets.Value <= tickets[comboMovieSelect.SelectedIndex] && tickets[comboMovieSelect.SelectedIndex] != 0)
            {
                //add sale to list of sales
                String sale = comboMovieSelect.SelectedItem.ToString() + ": " + numTickets.Value.ToString();
                sales.Add(sale);

                //down count of tickets
                tickets[comboMovieSelect.SelectedIndex] -= (Decimal)numTickets.Value;

                //reset form fields
                comboMovieSelect.SelectedIndex = 0;
                numTickets.Value = 0;
                numTickets.Maximum = tickets[0];
                txtAvailable.Text = "/" + tickets[0].ToString();
            }
           
        }
    }
}
