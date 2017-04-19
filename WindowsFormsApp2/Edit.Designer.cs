namespace WindowsFormsApp2
{
    partial class Edit
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
            System.Windows.Forms.Button editPassBtn;
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPass2 = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.DeleteAccBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.changePhotoBtn = new System.Windows.Forms.Button();
            editPassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editPassBtn
            // 
            editPassBtn.Location = new System.Drawing.Point(184, 216);
            editPassBtn.Name = "editPassBtn";
            editPassBtn.Size = new System.Drawing.Size(151, 31);
            editPassBtn.TabIndex = 0;
            editPassBtn.Text = "Edit password";
            editPassBtn.UseVisualStyleBackColor = true;
            editPassBtn.Click += new System.EventHandler(this.editPassBtn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(182, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Change Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Again:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Password";
            // 
            // textPass2
            // 
            this.textPass2.Location = new System.Drawing.Point(184, 184);
            this.textPass2.Name = "textPass2";
            this.textPass2.PasswordChar = '*';
            this.textPass2.Size = new System.Drawing.Size(151, 26);
            this.textPass2.TabIndex = 21;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(184, 126);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(151, 26);
            this.textPass.TabIndex = 20;
            // 
            // DeleteAccBtn
            // 
            this.DeleteAccBtn.Location = new System.Drawing.Point(308, 406);
            this.DeleteAccBtn.Name = "DeleteAccBtn";
            this.DeleteAccBtn.Size = new System.Drawing.Size(193, 48);
            this.DeleteAccBtn.TabIndex = 25;
            this.DeleteAccBtn.Text = "Delete Account";
            this.DeleteAccBtn.UseVisualStyleBackColor = true;
            this.DeleteAccBtn.Click += new System.EventHandler(this.DeleteAccBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(13, 13);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(91, 36);
            this.backBtn.TabIndex = 26;
            this.backBtn.Text = "< Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // changePhotoBtn
            // 
            this.changePhotoBtn.Location = new System.Drawing.Point(13, 406);
            this.changePhotoBtn.Name = "changePhotoBtn";
            this.changePhotoBtn.Size = new System.Drawing.Size(189, 48);
            this.changePhotoBtn.TabIndex = 27;
            this.changePhotoBtn.Text = "Change/Update photo";
            this.changePhotoBtn.UseVisualStyleBackColor = true;
            this.changePhotoBtn.Click += new System.EventHandler(this.changePhotoBtn_Click_2);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 476);
            this.Controls.Add(this.changePhotoBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.DeleteAccBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPass2);
            this.Controls.Add(this.textPass);
            this.Controls.Add(editPassBtn);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPass2;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button DeleteAccBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button changePhotoBtn;
    }
}