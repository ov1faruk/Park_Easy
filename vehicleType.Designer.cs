
namespace Park_Easy
{
    partial class vehicleType
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
            this.textvtype = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.txtSearchVehicke = new System.Windows.Forms.TextBox();
            this.dgvVehicleType = new System.Windows.Forms.DataGridView();
            this.goback = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textvtype
            // 
            this.textvtype.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textvtype.Location = new System.Drawing.Point(578, 231);
            this.textvtype.Name = "textvtype";
            this.textvtype.Size = new System.Drawing.Size(501, 39);
            this.textvtype.TabIndex = 4;
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(578, 352);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(501, 197);
            this.textDescription.TabIndex = 5;
            // 
            // txtSearchVehicke
            // 
            this.txtSearchVehicke.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVehicke.Location = new System.Drawing.Point(578, 605);
            this.txtSearchVehicke.Name = "txtSearchVehicke";
            this.txtSearchVehicke.Size = new System.Drawing.Size(501, 39);
            this.txtSearchVehicke.TabIndex = 6;
            // 
            // dgvVehicleType
            // 
            this.dgvVehicleType.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVehicleType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleType.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVehicleType.Location = new System.Drawing.Point(578, 722);
            this.dgvVehicleType.Name = "dgvVehicleType";
            this.dgvVehicleType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicleType.Size = new System.Drawing.Size(782, 289);
            this.dgvVehicleType.TabIndex = 7;
            // 
            // goback
            // 
            this.goback.AutoSize = true;
            this.goback.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback.ForeColor = System.Drawing.Color.Azure;
            this.goback.Location = new System.Drawing.Point(1751, 53);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(105, 24);
            this.goback.TabIndex = 10;
            this.goback.Text = "<< Go BACK";
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Park_Easy.Properties.Resources.vehdet;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1904, 1048);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DimGray;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Location = new System.Drawing.Point(1479, 533);
            this.delete.Margin = new System.Windows.Forms.Padding(0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(292, 118);
            this.delete.TabIndex = 14;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DimGray;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(1479, 352);
            this.update.Margin = new System.Windows.Forms.Padding(0);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(292, 118);
            this.update.TabIndex = 13;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DimGray;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.Location = new System.Drawing.Point(1140, 533);
            this.clear.Margin = new System.Windows.Forms.Padding(0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(292, 118);
            this.clear.TabIndex = 12;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DimGray;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(1140, 352);
            this.save.Margin = new System.Windows.Forms.Padding(0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(292, 118);
            this.save.TabIndex = 11;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            // 
            // vehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.dgvVehicleType);
            this.Controls.Add(this.txtSearchVehicke);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textvtype);
            this.Controls.Add(this.pictureBox1);
            this.Name = "vehicleType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vehicleType";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textvtype;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox txtSearchVehicke;
        private System.Windows.Forms.DataGridView dgvVehicleType;
        private System.Windows.Forms.Label goback;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
    }
}