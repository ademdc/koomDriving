using CloudinaryDotNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Database
    {
        private string cs;

        //constructor
        public Database(){
            cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adem Dinarević\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public bool login(string email, string pass)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("Select * from tbl_Register where email=@email and password=@password", con);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", pass);
            con.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            //If count is equal to 1, than show frmMain form

            if (count == 1)
            {
                MessageBox.Show("Login Successful!");
                
                CandidateForm fm = new CandidateForm(email);
                fm.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Incorrect password or e-mail!");
                return false;
            }
        }

        public void changePassword(string pass,string email)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("UPDATE tbl_Register SET password=@password WHERE email=@email", con);


            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Parameters.AddWithValue("@email", email);

            con.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapt.Fill(ds);
            con.Close();

            MessageBox.Show("Your password was succesfully changed");
        }

        public void deleteAccount(string email)
        {
            string query = "DELETE FROM tbl_Register WHERE email=@email";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", email);

            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
        }

        public void registerUser(string name, string surname, string email, string password, string gender)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
              new System.Data.SqlClient.SqlConnection(cs);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "INSERT tbl_Register (name, surname,email,password,gender) VALUES (@name, @surname,@email,@password,@gender)";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@gender", gender);
            

            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            MessageBox.Show("Succesfully Registered, please Login");
        }

        public int findId(string email)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("Select Id from tbl_Register where email=@email", con);

            cmd.Parameters.AddWithValue("@email", email);
            var userId = 0;

            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read(); // read first row
                userId = rd.GetInt32(0);
            }
            con.Close();
            

            int a = userId;
            return a;
        }

        public void insertProfilePicture(int id, string url)
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                  new System.Data.SqlClient.SqlConnection(cs);

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandText = "INSERT pictures (userId, url) VALUES (@id, @url)";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@url", url);

                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                MessageBox.Show("Succesfully uploaded pic");
            }catch(Exception ex)
            {
                MessageBox.Show("You can not change the photo here");
            }
        }

        public string getImageUrl(int idUser)
        {
            string a="";
            try
            {
                SqlConnection con = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("Select url from pictures where userId=@idUser", con);

                cmd.Parameters.AddWithValue("@idUser", idUser);
                string urlImage = "";

                con.Open();
                urlImage = (string)cmd.ExecuteScalar();
                con.Close();

                 a = urlImage.ToString();
            }
            catch(Exception ex)
            {
                //MessageBox.Show("You should upload a photo!");
            }
            return a;
        }

        public void changeProfilePicture(int id, PictureBox a)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("UPDATE pictures SET url=@url WHERE userId=@id", con);

            string url="";

            cmd.Parameters.AddWithValue("@url", url);
            cmd.Parameters.AddWithValue("@userId", id);

            con.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapt.Fill(ds);
            con.Close();

            MessageBox.Show("Your profile picture was changed");
        }
        /*
        public void cloudinary()
        {

            Account account = new Account(
            "adamdc",
            "372918989423237",
            "Rw-8vwL2VGknlBoC1dkKXMeealY");

            Cloudinary cloudinary = new Cloudinary(account);

            // open file dialog 
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // display image in picture box
            if (open.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(open.FileName);
                string imagePath = open.FileName;
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(imagePath),
                    PublicId = id.ToString()
                };
                var uploadResult = cloudinary.Upload(uploadParams);

                string imageUrl = "http://res.cloudinary.com/adamdc/image/upload/v1491249185/" + id + ".gif";
               
            }


        }
        */

    }

}
