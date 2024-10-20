namespace QLBanDoAnNhanh
{
    partial class frmChangePass
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
            this.tbNewpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbOldpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnConfr = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNewpass
            // 
            this.tbNewpass.BackColor = System.Drawing.Color.Transparent;
            this.tbNewpass.BorderRadius = 5;
            this.tbNewpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewpass.DefaultText = "";
            this.tbNewpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNewpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNewpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNewpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNewpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNewpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNewpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNewpass.Location = new System.Drawing.Point(41, 27);
            this.tbNewpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNewpass.Name = "tbNewpass";
            this.tbNewpass.PasswordChar = '*';
            this.tbNewpass.PlaceholderText = "New password";
            this.tbNewpass.SelectedText = "";
            this.tbNewpass.Size = new System.Drawing.Size(343, 31);
            this.tbNewpass.TabIndex = 0;
            // 
            // tbOldpass
            // 
            this.tbOldpass.BackColor = System.Drawing.Color.Transparent;
            this.tbOldpass.BorderRadius = 5;
            this.tbOldpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOldpass.DefaultText = "";
            this.tbOldpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOldpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOldpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOldpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOldpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOldpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbOldpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOldpass.Location = new System.Drawing.Point(41, 81);
            this.tbOldpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOldpass.Name = "tbOldpass";
            this.tbOldpass.PasswordChar = '*';
            this.tbOldpass.PlaceholderText = "Old password";
            this.tbOldpass.SelectedText = "";
            this.tbOldpass.Size = new System.Drawing.Size(343, 34);
            this.tbOldpass.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.cbShow);
            this.guna2Panel1.Controls.Add(this.btnConfr);
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.tbOldpass);
            this.guna2Panel1.Controls.Add(this.tbNewpass);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(430, 231);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnConfr
            // 
            this.btnConfr.BorderRadius = 5;
            this.btnConfr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfr.FillColor = System.Drawing.Color.Red;
            this.btnConfr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfr.ForeColor = System.Drawing.Color.White;
            this.btnConfr.Location = new System.Drawing.Point(264, 171);
            this.btnConfr.Name = "btnConfr";
            this.btnConfr.Size = new System.Drawing.Size(120, 34);
            this.btnConfr.TabIndex = 3;
            this.btnConfr.Text = "Confrim";
            this.btnConfr.Click += new System.EventHandler(this.btnConfr_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 5;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(41, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.BackColor = System.Drawing.Color.Transparent;
            this.cbShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShow.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShow.Location = new System.Drawing.Point(41, 133);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(61, 21);
            this.cbShow.TabIndex = 14;
            this.cbShow.Text = "Show";
            this.cbShow.UseVisualStyleBackColor = false;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 231);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChangePass";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbNewpass;
        private Guna.UI2.WinForms.Guna2TextBox tbOldpass;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnConfr;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox cbShow;
    }
}