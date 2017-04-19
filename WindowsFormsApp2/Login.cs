using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        private Database db;

        public Login()
        {
            InitializeComponent();
            db = new Database();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.loginDBDataSet.Table);

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (textEmail.Text == "" || textPass.Text == "")

            {
                MessageBox.Show("Please provide UserName and Password");
                return;

            }
            try
            {
                //Create SqlConnection
                if(db.login(textEmail.Text, textPass.Text))
                this.Hide();

            } 

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {           
            this.Hide();
            Register page = new Register();
            page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorForm page = new InstructorForm();
            page.Show();
        }


    }
}
