namespace WindowsFormsApp2
{
    partial class CandidateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logoutBtn = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.seeInstructorBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.changeInfoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoutBtn.Location = new System.Drawing.Point(473, 431);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(139, 40);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(45, 361);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(103, 29);
            this.uploadButton.TabIndex = 2;
            this.uploadButton.Text = " Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 14;
            // 
            // seeInstructorBtn
            // 
            this.seeInstructorBtn.Location = new System.Drawing.Point(473, 142);
            this.seeInstructorBtn.Name = "seeInstructorBtn";
            this.seeInstructorBtn.Size = new System.Drawing.Size(139, 41);
            this.seeInstructorBtn.TabIndex = 15;
            this.seeInstructorBtn.Text = "See instructors";
            this.seeInstructorBtn.UseVisualStyleBackColor = true;
            this.seeInstructorBtn.Click += new System.EventHandler(this.seeInstructorBtn_Click);
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.Location = new System.Drawing.Point(473, 189);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(139, 37);
            this.scheduleBtn.TabIndex = 16;
            this.scheduleBtn.Text = "Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(639, 119);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // changeInfoLabel
            // 
            this.changeInfoLabel.AutoSize = true;
            this.changeInfoLabel.BackColor = System.Drawing.Color.White;
            this.changeInfoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.changeInfoLabel.Location = new System.Drawing.Point(532, 90);
            this.changeInfoLabel.Name = "changeInfoLabel";
            this.changeInfoLabel.Size = new System.Drawing.Size(95, 20);
            this.changeInfoLabel.TabIndex = 20;
            this.changeInfoLabel.Text = "Change info";
            this.changeInfoLabel.Click += new System.EventHandler(this.changeInfoLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 492);
            this.Controls.Add(this.changeInfoLabel);
            this.Controls.Add(this.scheduleBtn);
            this.Controls.Add(this.seeInstructorBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.splitter1);
            this.Name = "CandidateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidatePage";
            this.Load += new System.EventHandler(this.CandidatePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button seeInstructorBtn;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label changeInfoLabel;
    }
}