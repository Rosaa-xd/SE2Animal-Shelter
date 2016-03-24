namespace AnimalShelter
{
    partial class ProductForm
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
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.tb_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tb_ProductPrice = new System.Windows.Forms.TextBox();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(64, 15);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(38, 13);
            this.lbl_ProductName.TabIndex = 0;
            this.lbl_ProductName.Text = "Name:";
            // 
            // tb_ProductName
            // 
            this.tb_ProductName.Location = new System.Drawing.Point(107, 12);
            this.tb_ProductName.Name = "tb_ProductName";
            this.tb_ProductName.Size = new System.Drawing.Size(100, 20);
            this.tb_ProductName.TabIndex = 1;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(64, 42);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(34, 13);
            this.lbl_Price.TabIndex = 2;
            this.lbl_Price.Text = "Price:";
            // 
            // tb_ProductPrice
            // 
            this.tb_ProductPrice.Location = new System.Drawing.Point(107, 39);
            this.tb_ProductPrice.Name = "tb_ProductPrice";
            this.tb_ProductPrice.Size = new System.Drawing.Size(100, 20);
            this.tb_ProductPrice.TabIndex = 3;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(107, 65);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(67, 39);
            this.btn_AddProduct.TabIndex = 4;
            this.btn_AddProduct.Text = "Add";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.tb_ProductPrice);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.tb_ProductName);
            this.Controls.Add(this.lbl_ProductName);
            this.Name = "ProductForm";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox tb_ProductName;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tb_ProductPrice;
        private System.Windows.Forms.Button btn_AddProduct;
    }
}