using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Edit : Form
    {
        private string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adem Dinarević\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        private CandidateForm obj1;
        private Database db;
        private string email;
        public Edit()
        {        
            InitializeComponent();
        }
        public Edit(string email)
        {
            InitializeComponent();
            obj1 = new CandidateForm();
            db = new Database();
            this.email = email;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void editPassBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            CandidateForm page = new CandidateForm(email);
            page.Show();
        }

        private void DeleteAccBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.deleteAccount(email);
                this.Hide();
                Login page = new Login();
                page.Show();
            }
            else
            {
                return;
            }
        }

        private void editPassBtn_Click_1(object sender, EventArgs e)
        {
            if (textPass.Text != textPass2.Text)
            {
                MessageBox.Show("Passwords are not the same");
                return;
            }

            if (textPass.Text == "" || textPass2.Text == "")
            {
                MessageBox.Show("Enter values for all fields");
                return;
            }
            if (MessageBox.Show("Are you sure you want to change your password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.changePassword(textPass.Text,email);
            }
            else
            {
                return;
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void changePhotoBtn_Click_2(object sender, EventArgs e)
        {
           // db.changeProfilePicture(2);

        }
    }
}
