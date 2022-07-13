using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;


namespace c_sharp_project_for_marks
{
    public partial class registration : KryptonForm
    {
        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {
            chxlugage.Checked = true;
            chxairmiles.Checked = true;
            chxtax.Checked = true;
            chxtravel.Checked = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdeparture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=travelagencyDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();

            string firstname = txtfname.Text;
            string surname = txtsurname.Text;
            string addresss = txtaddress.Text;
            string tel = txttell.Text;
            string email = txtemail.Text;

            string query = "	insert into registrationinfo (firstname,surname,addresss,tel,email) values ('"+firstname+"', '"+surname+"', '"+addresss+"', '"+tel+"', '"+email+"')";


            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("data daada wala xareeyay");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtsurname.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            txttell .Clear();
            txtfname.Focus();

            txtsubtotal.Text = "";
            txttax.Text = "";
            txttotal.Text = "";


            cmdeparture.Text = "none";
            cmaccom.Text = "none";
            cmdestination.Text = "none";

            chxlugage.Checked = true;
            chxtax.Checked = true;
            chxtravel.Checked = true;
            chxairmiles.Checked = true;


            rdeconomy.Checked = false;
            rdfirstclass.Checked = false;
            rdstandard.Checked = false;

            chxspecialneeds.Checked = false;
            chxsingle.Checked = false;
            chxreturn.Checked = false;
            chxchild.Checked = false;
            chxadult.Checked = false;




            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DialogResult iexit;

            iexit = MessageBox.Show("aqbal hadi ad rabto ina ka baxdo", "travel agency system",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (iexit == DialogResult.Yes)
            {
                Application.Exit();
            }

            
        }

        private void total_Click(object sender, EventArgs e)
        {
            Cprice travelprice = new Cprice();
            itax airtax = new itax();
            double[] travelcost = new double[20];
            double[] taxcost = new double[20];
            double total;

            if(cmdestination.Text == "hargeisa  5 days laascanood")
            {
                travelcost[0] = travelprice.hargeisa +travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance ;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0] ;

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "hargeisa  5 days berbera")
            {
                travelcost[0] = travelprice.hargeisa + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "hargeisa  5 days borama")
            {
                travelcost[0] = travelprice.hargeisa + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }


            if (cmdestination.Text == "mogadishu 5 days banaadir ")
            {
                travelcost[0] = travelprice.mogadishu + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "jabuuri 5 days ali sabiix ")
            {
                travelcost[0] = travelprice.jabuuti + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }




            if (cmdestination.Text == "jabuuti 4 days jabuuti ")
            {
                travelcost[0] = travelprice.jabuuti + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "rwanda 30 days gigali ")
            {
                travelcost[0] = travelprice.rwanda + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }


            if (cmdestination.Text == "south africa 5 day cape town  ")
            {
                travelcost[0] = travelprice.south_africa + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "south africa 4 days joahnburg")
            {
                travelcost[0] = travelprice.south_africa + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }



            if (cmdestination.Text == "nigeria - 6 days in lagos")
            {
                travelcost[0] = travelprice.nigeria + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }


            if (cmdestination.Text == "india 20 days new delhi")
            {
                travelcost[0] = travelprice.india + travelprice.airpot_tax + travelprice.air_miles + travelprice.lugage + travelprice.insurance;
                taxcost[0] = airtax.iFindTax(travelcost[0]);
                total = travelcost[0] + taxcost[0];

                txtsubtotal.Text = String.Format("{0:C}", travelcost[0]);
                txttax.Text = String.Format("{0:C}", taxcost[0]);
                txttotal.Text = String.Format("{0:C}", total);
            }

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            int num1;
            Random rnd = new Random();
            num1 = rnd.Next(4239, 34339);
            num1 = 1234 + num1;
            string refs = Convert.ToString(num1);



            string fullname = (txtfname.Text + txtsurname);
            string address = (txtaddress.Text);
            string tell = (txttell.Text);
            string email = (txtemail.Text);
            string rtax = (txttax.Text);
            string rsubtotal = (txtsubtotal.Text);
            string rtotal = (txttotal.Text);




        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
