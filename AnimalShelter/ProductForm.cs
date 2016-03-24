using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            decimal price;
            try
            {
                price = Convert.ToDecimal(tb_ProductPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers please");
                return;
                throw;
            }

            Product product = new Product(tb_ProductName.Text, price);
            Webshop.products.Add(product);
            Close();
        }
    }
}
