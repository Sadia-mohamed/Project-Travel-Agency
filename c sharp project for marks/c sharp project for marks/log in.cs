using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
namespace c_sharp_project_for_marks
{
    public partial class login : KryptonForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "abdalla" && txtpass.Text == "tijabo") 
            {
                new loading().Show();
              this.Hide();
            }
            else
            {
                MessageBox.Show("password kaga wuuqaldan yahy ku celi markale");
            }
        }

        private void chxshow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpass.Text = "";
            txtusername.Focus();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}