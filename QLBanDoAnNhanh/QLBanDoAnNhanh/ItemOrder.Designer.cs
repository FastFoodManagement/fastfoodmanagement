namespace QLBanDoAnNhanh
{
    partial class ItemOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemOrder));
            this.lbName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.picProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbRootPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(56, 7);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 18);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Buger";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Gray;
            this.lbDate.Location = new System.Drawing.Point(53, 42);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(71, 15);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "20-12-2002";
            // 
            // picProduct
            // 
            this.picProduct.BorderRadius = 4;
            this.picProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProduct.Image = ((System.Drawing.Image)(resources.GetObject("picProduct.Image")));
            this.picProduct.ImageRotate = 0F;
            this.picProduct.Location = new System.Drawing.Point(5, 7);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(45, 48);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 3;
            this.picProduct.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(376, 24);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(36, 18);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "9.0$";
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.Color.Tomato;
            this.numQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numQuantity.Location = new System.Drawing.Point(279, 22);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(60, 22);
            this.numQuantity.TabIndex = 5;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbRootPrice
            // 
            this.lbRootPrice.AutoSize = true;
            this.lbRootPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRootPrice.Location = new System.Drawing.Point(221, 23);
            this.lbRootPrice.Name = "lbRootPrice";
            this.lbRootPrice.Size = new System.Drawing.Size(52, 18);
            this.lbRootPrice.TabIndex = 6;
            this.lbRootPrice.Text = "150.0$";
            // 
            // ItemOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbRootPrice);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.Name = "ItemOrder";
            this.Size = new System.Drawing.Size(444, 67);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDate;
        private Guna.UI2.WinForms.Guna2PictureBox picProduct;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lbRootPrice;
    }
}
