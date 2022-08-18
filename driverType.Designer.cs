
namespace Park_Easy
{
    partial class driverType
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drivertypedetails = new System.Windows.Forms.ComboBox();
            this.desciptionDriverdetails = new System.Windows.Forms.RichTextBox();
            this.searchdriverdetails = new System.Windows.Forms.TextBox();
            this.resultsdriverdetails = new System.Windows.Forms.DataGridView();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsdriverdetails)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Park_Easy.Properties.Resources.driverdetails;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1905, 1064);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // drivertypedetails
            // 
            this.drivertypedetails.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivertypedetails.FormattingEnabled = true;
            this.drivertypedetails.Items.AddRange(new object[] {
            "Faculty",
            "Student",
            "Officials"});
            this.drivertypedetails.Location = new System.Drawing.Point(543, 217);
            this.drivertypedetails.Name = "drivertypedetails";
            this.drivertypedetails.Size = new System.Drawing.Size(501, 39);
            this.drivertypedetails.TabIndex = 1;
            // 
            // desciptionDriverdetails
            // 
            this.desciptionDriverdetails.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desciptionDriverdetails.Location = new System.Drawing.Point(543, 327);
            this.desciptionDriverdetails.Name = "desciptionDriverdetails";
            this.desciptionDriverdetails.Size = new System.Drawing.Size(501, 199);
            this.desciptionDriverdetails.TabIndex = 2;
            this.desciptionDriverdetails.Text = "";
            // 
            // searchdriverdetails
            // 
            this.searchdriverdetails.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchdriverdetails.Location = new System.Drawing.Point(543, 587);
            this.searchdriverdetails.Name = "searchdriverdetails";
            this.searchdriverdetails.Size = new System.Drawing.Size(501, 39);
            this.searchdriverdetails.TabIndex = 3;
            this.searchdriverdetails.TextChanged += new System.EventHandler(this.searchdriverdetails_TextChanged);
            // 
            // resultsdriverdetails
            // 
            this.resultsdriverdetails.AllowUserToAddRows = false;
            this.resultsdriverdetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultsdriverdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsdriverdetails.ContextMenuStrip = this.contextMenuStrip1;
            this.resultsdriverdetails.Location = new System.Drawing.Point(543, 708);
            this.resultsdriverdetails.MultiSelect = false;
            this.resultsdriverdetails.Name = "resultsdriverdetails";
            this.resultsdriverdetails.ReadOnly = true;
            this.resultsdriverdetails.RowHeadersVisible = false;
            this.resultsdriverdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsdriverdetails.Size = new System.Drawing.Size(1317, 307);
            this.resultsdriverdetails.TabIndex = 4;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DimGray;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.Location = new System.Drawing.Point(1098, 508);
            this.clear.Margin = new System.Windows.Forms.Padding(0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(292, 118);
            this.clear.TabIndex = 6;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DimGray;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(1098, 327);
            this.save.Margin = new System.Windows.Forms.Padding(0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(292, 118);
            this.save.TabIndex = 5;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DimGray;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Location = new System.Drawing.Point(1437, 327);
            this.update.Margin = new System.Windows.Forms.Padding(0);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(292, 118);
            this.update.TabIndex = 7;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.DimGray;
            this.cancel.Enabled = false;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel.Location = new System.Drawing.Point(1437, 508);
            this.cancel.Margin = new System.Windows.Forms.Padding(0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(292, 118);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // driverType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.update);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.resultsdriverdetails);
            this.Controls.Add(this.searchdriverdetails);
            this.Controls.Add(this.desciptionDriverdetails);
            this.Controls.Add(this.drivertypedetails);
            this.Controls.Add(this.pictureBox1);
            this.Name = "driverType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "driverType";
            this.Load += new System.EventHandler(this.driverType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsdriverdetails)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox drivertypedetails;
        private System.Windows.Forms.RichTextBox desciptionDriverdetails;
        private System.Windows.Forms.TextBox searchdriverdetails;
        private System.Windows.Forms.DataGridView resultsdriverdetails;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider ep;
    }
}