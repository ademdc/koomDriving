using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        private string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adem Dinarević\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        private Database db;
        public Register()
        {
            InitializeComponent();
            db = new Database();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            
            if (textPass.Text != textPass2.Text)
            {
                MessageBox.Show("Please provide same passwords");
                return;
            }

            if (textName.Text == "" || textSurname.Text == "" || textPass.Text == "")
            {
                MessageBox.Show("Enter values for all fields");
                return;
            }
            if (mailIsDuplicate(textEmail.Text))
                return;

            string gender;
            if (radioMale.Checked)
                gender = "male";
            else
                gender = "female";

            db.registerUser(textName.Text, textSurname.Text, textEmail.Text, textPass.Text, gender);

            Login page = new Login();
            this.Hide();
            page.Show();


            sendMail(textEmail.Text);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login page = new Login();
            page.Show();
            this.Hide();
        }

        private void sendMail(string mail)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("koomdriving@gmail.com", "koomdriving..!");

            MailMessage mm = new MailMessage("koomdriving@gmail.com", mail, "Succesfull registration to KoomDriving", "Thank you for registering to koomDriving.com.\n" +
                "You are now able to do lots of amazing things with us. Want to book a new car driving lesson? You are on the right spot!" +
                "\n\n\n Development team of KoomDriving");
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }
        
        private bool mailIsDuplicate(string email)
        {
            SqlConnection con = new SqlConnection(cs);
            string sql1 = "SELECT COUNT (email) FROM tbl_Register WHERE email = '" + email + "' ";
            SqlCommand cmd = new SqlCommand(sql1, con);
            con.Open();
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (temp > 0)
            {
                MessageBox.Show("That e-mail is already registered");
                return true;
            }

            return false;
        }

        
    }
}
