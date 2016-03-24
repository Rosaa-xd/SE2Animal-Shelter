namespace AnimalShelter
{
    partial class WebShopForm
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
            this.gb_animals = new System.Windows.Forms.GroupBox();
            this.btn_ReturnToAdminForm = new System.Windows.Forms.Button();
            this.btn_ReserveAnimal = new System.Windows.Forms.Button();
            this.btn_BuyAnimal = new System.Windows.Forms.Button();
            this.lbl_ShowAnimalPrice = new System.Windows.Forms.Label();
            this.lbl_AnimalPrice = new System.Windows.Forms.Label();
            this.cb_AnimalBuyers = new System.Windows.Forms.ComboBox();
            this.tb_ReservorName = new System.Windows.Forms.TextBox();
            this.lbl_ReservorName = new System.Windows.Forms.Label();
            this.lb_Animals = new System.Windows.Forms.ListBox();
            this.gb_Products = new System.Windows.Forms.GroupBox();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_BuyProduct = new System.Windows.Forms.Button();
            this.lbl_ShowProductPrice = new System.Windows.Forms.Label();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.cb_ProductBuyers = new System.Windows.Forms.ComboBox();
            this.tb_BuyerName = new System.Windows.Forms.TextBox();
            this.lbl_BuyerName = new System.Windows.Forms.Label();
            this.lb_Products = new System.Windows.Forms.ListBox();
            this.gb_animals.SuspendLayout();
            this.gb_Products.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_animals
            // 
            this.gb_animals.Controls.Add(this.btn_ReturnToAdminForm);
            this.gb_animals.Controls.Add(this.btn_ReserveAnimal);
            this.gb_animals.Controls.Add(this.btn_BuyAnimal);
            this.gb_animals.Controls.Add(this.lbl_ShowAnimalPrice);
            this.gb_animals.Controls.Add(this.lbl_AnimalPrice);
            this.gb_animals.Controls.Add(this.cb_AnimalBuyers);
            this.gb_animals.Controls.Add(this.tb_ReservorName);
            this.gb_animals.Controls.Add(this.lbl_ReservorName);
            this.gb_animals.Controls.Add(this.lb_Animals);
            this.gb_animals.Location = new System.Drawing.Point(13, 13);
            this.gb_animals.Name = "gb_animals";
            this.gb_animals.Size = new System.Drawing.Size(308, 244);
            this.gb_animals.TabIndex = 0;
            this.gb_animals.TabStop = false;
            this.gb_animals.Text = "Animals";
            // 
            // btn_ReturnToAdminForm
            // 
            this.btn_ReturnToAdminForm.Location = new System.Drawing.Point(10, 196);
            this.btn_ReturnToAdminForm.Name = "btn_ReturnToAdminForm";
            this.btn_ReturnToAdminForm.Size = new System.Drawing.Size(67, 39);
            this.btn_ReturnToAdminForm.TabIndex = 8;
            this.btn_ReturnToAdminForm.Text = "Return";
            this.btn_ReturnToAdminForm.UseVisualStyleBackColor = true;
            this.btn_ReturnToAdminForm.Click += new System.EventHandler(this.btn_ReturnToAdminForm_Click);
            // 
            // btn_ReserveAnimal
            // 
            this.btn_ReserveAnimal.Location = new System.Drawing.Point(86, 151);
            this.btn_ReserveAnimal.Name = "btn_ReserveAnimal";
            this.btn_ReserveAnimal.Size = new System.Drawing.Size(67, 39);
            this.btn_ReserveAnimal.TabIndex = 7;
            this.btn_ReserveAnimal.Text = "Reserve";
            this.btn_ReserveAnimal.UseVisualStyleBackColor = true;
            this.btn_ReserveAnimal.Click += new System.EventHandler(this.btn_ReserveAnimal_Click);
            // 
            // btn_BuyAnimal
            // 
            this.btn_BuyAnimal.Location = new System.Drawing.Point(86, 196);
            this.btn_BuyAnimal.Name = "btn_BuyAnimal";
            this.btn_BuyAnimal.Size = new System.Drawing.Size(67, 39);
            this.btn_BuyAnimal.TabIndex = 6;
            this.btn_BuyAnimal.Text = "Buy";
            this.btn_BuyAnimal.UseVisualStyleBackColor = true;
            this.btn_BuyAnimal.Click += new System.EventHandler(this.btn_BuyAnimal_Click);
            // 
            // lbl_ShowAnimalPrice
            // 
            this.lbl_ShowAnimalPrice.AutoSize = true;
            this.lbl_ShowAnimalPrice.Location = new System.Drawing.Point(47, 90);
            this.lbl_ShowAnimalPrice.Name = "lbl_ShowAnimalPrice";
            this.lbl_ShowAnimalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ShowAnimalPrice.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowAnimalPrice.TabIndex = 5;
            this.lbl_ShowAnimalPrice.Text = "x";
            // 
            // lbl_AnimalPrice
            // 
            this.lbl_AnimalPrice.AutoSize = true;
            this.lbl_AnimalPrice.Location = new System.Drawing.Point(7, 90);
            this.lbl_AnimalPrice.Name = "lbl_AnimalPrice";
            this.lbl_AnimalPrice.Size = new System.Drawing.Size(34, 13);
            this.lbl_AnimalPrice.TabIndex = 4;
            this.lbl_AnimalPrice.Text = "Price:";
            // 
            // cb_AnimalBuyers
            // 
            this.cb_AnimalBuyers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AnimalBuyers.FormattingEnabled = true;
            this.cb_AnimalBuyers.Location = new System.Drawing.Point(10, 63);
            this.cb_AnimalBuyers.Name = "cb_AnimalBuyers";
            this.cb_AnimalBuyers.Size = new System.Drawing.Size(143, 21);
            this.cb_AnimalBuyers.TabIndex = 3;
            // 
            // tb_ReservorName
            // 
            this.tb_ReservorName.Location = new System.Drawing.Point(10, 36);
            this.tb_ReservorName.Name = "tb_ReservorName";
            this.tb_ReservorName.Size = new System.Drawing.Size(143, 20);
            this.tb_ReservorName.TabIndex = 2;
            // 
            // lbl_ReservorName
            // 
            this.lbl_ReservorName.AutoSize = true;
            this.lbl_ReservorName.Location = new System.Drawing.Point(7, 19);
            this.lbl_ReservorName.Name = "lbl_ReservorName";
            this.lbl_ReservorName.Size = new System.Drawing.Size(35, 13);
            this.lbl_ReservorName.TabIndex = 1;
            this.lbl_ReservorName.Text = "Name";
            // 
            // lb_Animals
            // 
            this.lb_Animals.FormattingEnabled = true;
            this.lb_Animals.Location = new System.Drawing.Point(159, 19);
            this.lb_Animals.Name = "lb_Animals";
            this.lb_Animals.Size = new System.Drawing.Size(143, 212);
            this.lb_Animals.TabIndex = 0;
            this.lb_Animals.SelectedIndexChanged += new System.EventHandler(this.lb_Animals_SelectedIndexChanged);
            // 
            // gb_Products
            // 
            this.gb_Products.Controls.Add(this.btn_AddProduct);
            this.gb_Products.Controls.Add(this.btn_BuyProduct);
            this.gb_Products.Controls.Add(this.lbl_ShowProductPrice);
            this.gb_Products.Controls.Add(this.lbl_ProductPrice);
            this.gb_Products.Controls.Add(this.cb_ProductBuyers);
            this.gb_Products.Controls.Add(this.tb_BuyerName);
            this.gb_Products.Controls.Add(this.lbl_BuyerName);
            this.gb_Products.Controls.Add(this.lb_Products);
            this.gb_Products.Location = new System.Drawing.Point(330, 12);
            this.gb_Products.Name = "gb_Products";
            this.gb_Products.Size = new System.Drawing.Size(308, 245);
            this.gb_Products.TabIndex = 1;
            this.gb_Products.TabStop = false;
            this.gb_Products.Text = "Products";
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(10, 197);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(67, 39);
            this.btn_AddProduct.TabIndex = 8;
            this.btn_AddProduct.Text = "Add";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_BuyProduct
            // 
            this.btn_BuyProduct.Location = new System.Drawing.Point(86, 197);
            this.btn_BuyProduct.Name = "btn_BuyProduct";
            this.btn_BuyProduct.Size = new System.Drawing.Size(67, 39);
            this.btn_BuyProduct.TabIndex = 7;
            this.btn_BuyProduct.Text = "Buy";
            this.btn_BuyProduct.UseVisualStyleBackColor = true;
            this.btn_BuyProduct.Click += new System.EventHandler(this.btn_BuyProduct_Click);
            // 
            // lbl_ShowProductPrice
            // 
            this.lbl_ShowProductPrice.AutoSize = true;
            this.lbl_ShowProductPrice.Location = new System.Drawing.Point(47, 92);
            this.lbl_ShowProductPrice.Name = "lbl_ShowProductPrice";
            this.lbl_ShowProductPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ShowProductPrice.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowProductPrice.TabIndex = 5;
            this.lbl_ShowProductPrice.Text = "x";
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Location = new System.Drawing.Point(7, 91);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(34, 13);
            this.lbl_ProductPrice.TabIndex = 4;
            this.lbl_ProductPrice.Text = "Price:";
            // 
            // cb_ProductBuyers
            // 
            this.cb_ProductBuyers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ProductBuyers.FormattingEnabled = true;
            this.cb_ProductBuyers.Location = new System.Drawing.Point(10, 63);
            this.cb_ProductBuyers.Name = "cb_ProductBuyers";
            this.cb_ProductBuyers.Size = new System.Drawing.Size(143, 21);
            this.cb_ProductBuyers.TabIndex = 3;
            // 
            // tb_BuyerName
            // 
            this.tb_BuyerName.Location = new System.Drawing.Point(10, 36);
            this.tb_BuyerName.Name = "tb_BuyerName";
            this.tb_BuyerName.Size = new System.Drawing.Size(143, 20);
            this.tb_BuyerName.TabIndex = 2;
            // 
            // lbl_BuyerName
            // 
            this.lbl_BuyerName.AutoSize = true;
            this.lbl_BuyerName.Location = new System.Drawing.Point(7, 18);
            this.lbl_BuyerName.Name = "lbl_BuyerName";
            this.lbl_BuyerName.Size = new System.Drawing.Size(35, 13);
            this.lbl_BuyerName.TabIndex = 1;
            this.lbl_BuyerName.Text = "Name";
            // 
            // lb_Products
            // 
            this.lb_Products.FormattingEnabled = true;
            this.lb_Products.Location = new System.Drawing.Point(158, 18);
            this.lb_Products.Name = "lb_Products";
            this.lb_Products.Size = new System.Drawing.Size(143, 212);
            this.lb_Products.TabIndex = 0;
            this.lb_Products.SelectedIndexChanged += new System.EventHandler(this.lb_Products_SelectedIndexChanged);
            // 
            // WebShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 261);
            this.Controls.Add(this.gb_Products);
            this.Controls.Add(this.gb_animals);
            this.Name = "WebShopForm";
            this.Text = "The Doozies Buy Time";
            this.gb_animals.ResumeLayout(false);
            this.gb_animals.PerformLayout();
            this.gb_Products.ResumeLayout(false);
            this.gb_Products.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_animals;
        private System.Windows.Forms.Label lbl_ReservorName;
        private System.Windows.Forms.ListBox lb_Animals;
        private System.Windows.Forms.Button btn_BuyAnimal;
        private System.Windows.Forms.Label lbl_ShowAnimalPrice;
        private System.Windows.Forms.Label lbl_AnimalPrice;
        private System.Windows.Forms.ComboBox cb_AnimalBuyers;
        private System.Windows.Forms.TextBox tb_ReservorName;
        private System.Windows.Forms.GroupBox gb_Products;
        private System.Windows.Forms.Label lbl_ShowProductPrice;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.ComboBox cb_ProductBuyers;
        private System.Windows.Forms.TextBox tb_BuyerName;
        private System.Windows.Forms.Label lbl_BuyerName;
        private System.Windows.Forms.ListBox lb_Products;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_BuyProduct;
        private System.Windows.Forms.Button btn_ReserveAnimal;
        private System.Windows.Forms.Button btn_ReturnToAdminForm;

    }
}