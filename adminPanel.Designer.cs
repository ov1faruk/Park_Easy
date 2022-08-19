
namespace Park_Easy
{
    partial class adminPanel
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
            this.driverType = new System.Windows.Forms.Button();
            this.vehicleType = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.checkin = new System.Windows.Forms.Button();
            this.checkout = new System.Windows.Forms.Button();
            this.parkhistory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // driverType
            // 
            this.driverType.BackColor = System.Drawing.Color.DimGray;
            this.driverType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.driverType.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverType.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.driverType.Location = new System.Drawing.Point(342, 377);
            this.driverType.Margin = new System.Windows.Forms.Padding(0);
            this.driverType.Name = "driverType";
            this.driverType.Size = new System.Drawing.Size(173, 70);
            this.driverType.TabIndex = 2;
            this.driverType.Text = "Driver Type";
            this.driverType.UseVisualStyleBackColor = false;
            this.driverType.Click += new System.EventHandler(this.driverType_Click);
            this.driverType.MouseLeave += new System.EventHandler(this.driverType_MouseLeave);
            this.driverType.MouseHover += new System.EventHandler(this.driverType_MouseHover);
            // 
            // vehicleType
            // 
            this.vehicleType.BackColor = System.Drawing.Color.DimGray;
            this.vehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vehicleType.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleType.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.vehicleType.Location = new System.Drawing.Point(896, 377);
            this.vehicleType.Margin = new System.Windows.Forms.Padding(0);
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.Size = new System.Drawing.Size(167, 70);
            this.vehicleType.TabIndex = 3;
            this.vehicleType.Text = "Vehicle Type";
            this.vehicleType.UseVisualStyleBackColor = false;
            this.vehicleType.Click += new System.EventHandler(this.vehicleType_Click);
            this.vehicleType.MouseLeave += new System.EventHandler(this.vehicleType_MouseLeave);
            this.vehicleType.MouseHover += new System.EventHandler(this.vehicleType_MouseHover);
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.DimGray;
            this.registration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registration.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.registration.Location = new System.Drawing.Point(1454, 377);
            this.registration.Margin = new System.Windows.Forms.Padding(0);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(165, 70);
            this.registration.TabIndex = 4;
            this.registration.Text = "Registration";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            this.registration.MouseLeave += new System.EventHandler(this.registration_MouseLeave);
            this.registration.MouseHover += new System.EventHandler(this.registration_MouseHover);
            // 
            // checkin
            // 
            this.checkin.BackColor = System.Drawing.Color.DimGray;
            this.checkin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkin.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkin.Location = new System.Drawing.Point(404, 881);
            this.checkin.Margin = new System.Windows.Forms.Padding(0);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(160, 76);
            this.checkin.TabIndex = 6;
            this.checkin.Text = "Check-IN";
            this.checkin.UseVisualStyleBackColor = false;
            this.checkin.Click += new System.EventHandler(this.checkin_Click);
            this.checkin.MouseLeave += new System.EventHandler(this.checkin_MouseLeave);
            this.checkin.MouseHover += new System.EventHandler(this.checkin_MouseHover);
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.Color.DimGray;
            this.checkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkout.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkout.Location = new System.Drawing.Point(873, 881);
            this.checkout.Margin = new System.Windows.Forms.Padding(0);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(177, 76);
            this.checkout.TabIndex = 7;
            this.checkout.Text = "Check-OUT";
            this.checkout.UseVisualStyleBackColor = false;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            this.checkout.MouseLeave += new System.EventHandler(this.checkout_MouseLeave);
            this.checkout.MouseHover += new System.EventHandler(this.checkout_MouseHover);
            // 
            // parkhistory
            // 
            this.parkhistory.BackColor = System.Drawing.Color.DimGray;
            this.parkhistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkhistory.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkhistory.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.parkhistory.Location = new System.Drawing.Point(1342, 881);
            this.parkhistory.Margin = new System.Windows.Forms.Padding(0);
            this.parkhistory.Name = "parkhistory";
            this.parkhistory.Size = new System.Drawing.Size(162, 76);
            this.parkhistory.TabIndex = 8;
            this.parkhistory.Text = "Parking History";
            this.parkhistory.UseVisualStyleBackColor = false;
            this.parkhistory.Click += new System.EventHandler(this.parkhistory_Click);
            this.parkhistory.MouseLeave += new System.EventHandler(this.parkhistory_MouseLeave);
            this.parkhistory.MouseHover += new System.EventHandler(this.parkhistory_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Park_Easy.Properties.Resources.adminpanel;
            this.pictureBox1.Location = new System.Drawing.Point(-2991, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1547, 1043);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Park_Easy.Properties.Resources.adminpanel1;
            this.pictureBox2.Location = new System.Drawing.Point(1, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1904, 1050);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.logout.Location = new System.Drawing.Point(1774, 51);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(104, 41);
            this.logout.TabIndex = 9;
            this.logout.Text = "logout";
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.parkhistory);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.vehicleType);
            this.Controls.Add(this.driverType);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "adminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button driverType;
        private System.Windows.Forms.Button vehicleType;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Button checkin;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.Button parkhistory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label logout;
    }
}