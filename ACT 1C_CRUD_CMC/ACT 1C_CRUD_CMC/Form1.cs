using MySql.Data.MySqlClient;
namespace ACT_1C_CRUD_CMC
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=calmadb;username=root;password=;");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chbShowPassword.Checked)
            {
             txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
