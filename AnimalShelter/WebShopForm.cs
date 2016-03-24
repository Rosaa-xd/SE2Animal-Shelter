using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class WebShopForm : Form
    {
        public WebShopForm()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            lb_Products.DataSource = Webshop.products;
            lb_Animals.DataSource = Webshop.animals;
            cb_AnimalBuyers.DataSource = Webshop.buyers;
            cb_ProductBuyers.DataSource = Webshop.buyers;
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void btn_BuyProduct_Click(object sender, EventArgs e)
        {
            Buyer buyer;
            if (cb_ProductBuyers.SelectedItem != null)
            {
                buyer = (Buyer) cb_ProductBuyers.SelectedItem;
            }
            else
            {
                buyer = new Buyer(tb_BuyerName.Text);
                Webshop.buyers.Add(buyer);
            }
            Product product = (Product)lb_Products.SelectedItem;

            MessageBox.Show(buyer.Name + ", you have bought a " + product.Name +
                            "! We hope you enjoy your purchase.");
            cb_ProductBuyers.SelectedIndex = -1;
        }

        private void lb_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = (Product) lb_Products.SelectedItem;
            lbl_ShowProductPrice.Text = product.Price.ToString();
        }

        private void btn_ReserveAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal) lb_Animals.SelectedItem;

            //Making sure animal isn't already reserved
            if (animal.IsReserved != null)
            {
                MessageBox.Show("Whoops! We're sorry to tell you, but " + animal.Name +
                                " has already been taken by " + animal.IsReserved);
            }

            else
            {
                Reservor reservor;
                if (cb_AnimalBuyers.SelectedItem != null)
                {
                    reservor = new Reservor(cb_AnimalBuyers.SelectedItem.ToString(), DateTime.Now);
                }
                else
                {
                    reservor = new Reservor(tb_ReservorName.Text, DateTime.Now);
                    Webshop.buyers.Add(reservor);
                }
                
                animal.IsReserved = reservor.Name;
                MessageBox.Show("Congratulations " + reservor.Name + "! You have reserved " + animal.Name + "!");
            }
            cb_AnimalBuyers.SelectedIndex = -1;
            cb_ProductBuyers.SelectedIndex = -1;
        }

        private void btn_BuyAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal) lb_Animals.SelectedItem;

            //Making sure animal isn't already reserved
            if (animal.IsReserved != null)
            {
                MessageBox.Show("Whoops! We're sorry to tell you, but " + animal.Name +
                                " has already been taken by " + animal.IsReserved);
            }
            else
            {
                Buyer buyer;
                if (cb_AnimalBuyers.SelectedItem != null)
                {
                    buyer = (Buyer) cb_AnimalBuyers.SelectedItem;
                }
                else
                {
                    buyer = new Buyer(tb_ReservorName.Text);
                }

                Webshop.animals.Remove(animal);
                MessageBox.Show("Congratulations " + buyer.Name + "! You have bought " + animal.Name +
                                "! We hope you will have much joy with your new little buddy!");
            }
            cb_AnimalBuyers.SelectedIndex = -1;
            cb_ProductBuyers.SelectedIndex = -1;
        }

        private void btn_ReturnToAdminForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lb_Animals_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal animalPrice;
            if (lb_Animals.SelectedItem is Cat)
            {
                Cat cat = lb_Animals.SelectedItem as Cat;
                animalPrice = 350 - (cat.BadHabit.Length*20);
                cat.Price = animalPrice;
            }
            if (lb_Animals.SelectedItem is Dog)
            {
                Dog dog = lb_Animals.SelectedItem as Dog;
                animalPrice = 500 - ((Webshop.dogs.Count - Webshop.dogs.IndexOf(dog) - 1) *50);
                dog.Price = animalPrice;
            }
            Animal animal = (Animal)lb_Animals.SelectedItem;
            lbl_ShowAnimalPrice.Text = animal.Price.ToString();
        }
    }
}
