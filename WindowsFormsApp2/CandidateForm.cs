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
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Newtonsoft.Json.Linq;
using System.Net;

namespace WindowsFormsApp2
{
    public partial class CandidateForm : Form
    {

        private string email;
        private int id;
        Database db;
        private string imageUrl;

        public CandidateForm()
        { 
            InitializeComponent();
        }

        public CandidateForm(string email)
        {
            this.email = email;
            db = new Database();
            id = db.findId(email);
            imageUrl = db.getImageUrl(id);
            // Find url by using id
            

            InitializeComponent();

            loadProfilePicture();
            label2.Text = "Welcome " + email;
            label7.Text = email;

            if (imageUrl == "")
            {
                uploadButton.Visible = true;
            }
            else
                uploadButton.Visible = false;
        }

        public string getEmail()
        {
            return email;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login page = new Login();
            page.Show();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            cloudinary();
            // Cloudinary will give you a link URL
            // Insert into table pictures with ID and URL
        }

        private void CandidatePage_Load(object sender, EventArgs e)
        {

        }     
   
        private void seeInstructorBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The id is "+db.findId(email));
            MessageBox.Show("The image url is "+db.getImageUrl(id));
            

        }

        private void changeInfoLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit edit = new Edit(label7.Text);
            edit.Show();
        }

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
  
                string imageUrl = "http://res.cloudinary.com/adamdc/image/upload/v1491249185/"+id+".gif";
                db.insertProfilePicture(id, imageUrl);
            }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void loadProfilePicture()
        {
            try
            {
                imageUrl = db.getImageUrl(id);
                if (imageUrl == "")
                    return;

                var request = WebRequest.Create(imageUrl);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(stream);
                }
            }
            catch (Exception ex)
            {

            }
        }
        
    }



}

    

            
        

        
    

