namespace QLBanDoAnNhanh
{
    partial class frmItemDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemDetail));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.picItem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnSoldOut = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2TileButton();
            this.lbDecript = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(416, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // picItem
            // 
            this.picItem.Image = ((System.Drawing.Image)(resources.GetObject("picItem.Image")));
            this.picItem.ImageRotate = 0F;
            this.picItem.Location = new System.Drawing.Point(99, 12);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(260, 203);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 1;
            this.picItem.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(7, 227);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(443, 32);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Buger";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.lbPrice.Location = new System.Drawing.Point(6, 273);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(50, 25);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "9.0$";
            // 
            // btnSoldOut
            // 
            this.btnSoldOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSoldOut.BorderRadius = 4;
            this.btnSoldOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoldOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSoldOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSoldOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSoldOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSoldOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSoldOut.ForeColor = System.Drawing.Color.White;
            this.btnSoldOut.Location = new System.Drawing.Point(21, 458);
            this.btnSoldOut.Name = "btnSoldOut";
            this.btnSoldOut.Size = new System.Drawing.Size(108, 54);
            this.btnSoldOut.TabIndex = 5;
            this.btnSoldOut.Text = "Sold out";
            this.btnSoldOut.Click += new System.EventHandler(this.btnSoldOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(329, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 54);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbDecript
            // 
            this.lbDecript.BackColor = System.Drawing.Color.Transparent;
            this.lbDecript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDecript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDecript.Location = new System.Drawing.Point(12, 315);
            this.lbDecript.Name = "lbDecript";
            this.lbDecript.Size = new System.Drawing.Size(439, 126);
            this.lbDecript.TabIndex = 7;
            this.lbDecript.Text = "abc";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 4;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Green;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(172, 458);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 54);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(463, 524);
            this.guna2Panel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(14, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 1);
            this.panel1.TabIndex = 0;
            // 
            // frmItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 524);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbDecript);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSoldOut);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail Item";
            this.Load += new System.EventHandler(this.frmItemDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox picItem;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private Guna.UI2.WinForms.Guna2TileButton btnSoldOut;
        private Guna.UI2.WinForms.Guna2TileButton btnDelete;
        private System.Windows.Forms.Label lbDecript;
        private Guna.UI2.WinForms.Guna2TileButton btnEdit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
    }
}