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
    public partial class TheatreSetUp : Form
    {
        public TheatreSetUp()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //build array of movie options
            String[] movies = { txtShowingOne.Text, txtShowingTwo.Text, txtShowingThree.Text, txtShowingFour.Text, txtShowingFive.Text};

            // build array of seats available at each showing
            Decimal[] seats = { numTixOne.Value, numTixTwo.Value, numTixThree.Value, numTixFour.Value, numTixFive.Value};

            //build next form
            BuyTickets tix = new BuyTickets(movies, seats);

            //switch forms
            tix.Show();
            this.Hide();
        }
    }
}
