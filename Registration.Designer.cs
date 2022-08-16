
namespace Park_Easy
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.regName = new System.Windows.Forms.TextBox();
            this.regID = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regCategory = new System.Windows.Forms.ComboBox();
            this.regLabel1 = new System.Windows.Forms.Label();
            this.regClear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backToLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // regName
            // 
            this.regName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regName.Location = new System.Drawing.Point(280, 226);
            this.regName.Multiline = true;
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(286, 34);
            this.regName.TabIndex = 6;
            this.regName.TextChanged += new System.EventHandler(this.regName_TextChanged);
            // 
            // regID
            // 
            this.regID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regID.Location = new System.Drawing.Point(280, 352);
            this.regID.Multiline = true;
            this.regID.Name = "regID";
            this.regID.Size = new System.Drawing.Size(286, 34);
            this.regID.TabIndex = 7;
            // 
            // regPassword
            // 
            this.regPassword.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword.Location = new System.Drawing.Point(280, 420);
            this.regPassword.Multiline = true;
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(286, 34);
            this.regPassword.TabIndex = 8;
            // 
            // regCategory
            // 
            this.regCategory.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regCategory.FormattingEnabled = true;
            this.regCategory.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "Officials"});
            this.regCategory.Location = new System.Drawing.Point(280, 298);
            this.regCategory.Name = "regCategory";
            this.regCategory.Size = new System.Drawing.Size(286, 32);
            this.regCategory.TabIndex = 9;
            // 
            // regLabel1
            // 
            this.regLabel1.AutoSize = true;
            this.regLabel1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.regLabel1.Location = new System.Drawing.Point(456, 543);
            this.regLabel1.Name = "regLabel1";
            this.regLabel1.Size = new System.Drawing.Size(98, 31);
            this.regLabel1.TabIndex = 10;
            this.regLabel1.Text = "Register";
            this.regLabel1.Click += new System.EventHandler(this.regLabel1_Click);
            // 
            // regClear
            // 
            this.regClear.AutoSize = true;
            this.regClear.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.regClear.Location = new System.Drawing.Point(260, 543);
            this.regClear.Name = "regClear";
            this.regClear.Size = new System.Drawing.Size(70, 31);
            this.regClear.TabIndex = 11;
            this.regClear.Text = "Clear";
            this.regClear.Click += new System.EventHandler(this.regClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 816);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backToLogin
            // 
            this.backToLogin.AutoSize = true;
            this.backToLogin.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.backToLogin.Location = new System.Drawing.Point(330, 655);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(155, 31);
            this.backToLogin.TabIndex = 12;
            this.backToLogin.Text = "Back To Login";
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 811);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.regClear);
            this.Controls.Add(this.regLabel1);
            this.Controls.Add(this.regCategory);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.regID);
            this.Controls.Add(this.regName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox regName;
        private System.Windows.Forms.TextBox regID;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.ComboBox regCategory;
        private System.Windows.Forms.Label regLabel1;
        private System.Windows.Forms.Label regClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label backToLogin;
    }
}