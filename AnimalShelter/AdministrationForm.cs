using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        //Defining file path
        private static string filePathAnimal =
            @"C:\Users\Marie-Rose\Dropbox\Fontys\Feb 2016 - Jul 2016\Semester 2\Software\Opdrachten\SE2Animal-Shelter\Data\Animal.json";
        private static string filePathProduct =
            @"C:\Users\Marie-Rose\Dropbox\Fontys\Feb 2016 - Jul 2016\Semester 2\Software\Opdrachten\SE2Animal-Shelter\Data\Product.json";
        private static string filePathBuyer =
            @"C:\Users\Marie-Rose\Dropbox\Fontys\Feb 2016 - Jul 2016\Semester 2\Software\Opdrachten\SE2Animal-Shelter\Data\Buyer.json";

        //private static string filePathAnimal = Properties.Resources.Animal;
        //private static string filePathProduct = Properties.Resources.Product;

        public AdministrationForm()
        {
            InitializeComponent();

            GetData(filePathAnimal);
            GetData(filePathProduct);
            GetData(filePathBuyer);

            cb_AnimalType.Items.Add("Cat");
            cb_AnimalType.Items.Add("Dog");
            cb_AnimalGender.Items.Add(Gender.Male);
            cb_AnimalGender.Items.Add(Gender.Female);
            ShowData();
        }

        private void ShowData()
        {
            lb_Animals.DataSource = Webshop.animals;
        }

        private void btn_AddAnimal_Click(object sender, EventArgs e)
        {
            if (cb_AnimalType.SelectedItem.Equals("Cat"))
            {
                Cat cat = new Cat(tb_AnimalName.Text,
                    tb_AnimalAge.Text,
                    (Gender) cb_AnimalGender.SelectedItem,
                    null,
                    0,
                    tb_BadHabit.Text);
                Webshop.animals.Add(cat);
            }
            if (cb_AnimalType.SelectedItem.Equals("Dog"))
            {
                Dog dog = new Dog(tb_AnimalName.Text,
                    tb_AnimalAge.Text,
                    (Gender) cb_AnimalGender.SelectedItem,
                    null,
                    0,
                    dtp_LastWalkDate.Value);
                Webshop.animals.Add(dog);
                Webshop.dogs.Add(dog);
            }

            //Clear all fields
            tb_AnimalName.Clear();
            tb_AnimalAge.Clear();
            tb_BadHabit.Clear();
            cb_AnimalGender.SelectedIndex = -1;
        }

        private void btn_ShowInfo_Click(object sender, EventArgs e)
        {
            if (lb_Animals.SelectedItem is Cat)
            {
                Cat cat = lb_Animals.SelectedItem as Cat;
                MessageBox.Show(cat.ToString());
            }
            if (lb_Animals.SelectedItem is Dog)
            {
                Dog dog = lb_Animals.SelectedItem as Dog;
                MessageBox.Show(dog.ToString());
            }
        }

        private void cb_AnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Disables form parts not used in selected Animal Type
            if (cb_AnimalType.SelectedItem.Equals("Cat"))
            {
                dtp_LastWalkDate.Enabled = false;
                tb_BadHabit.Enabled = true;
            }
            if (cb_AnimalType.SelectedItem.Equals("Dog"))
            {
                tb_BadHabit.Enabled = false;
                dtp_LastWalkDate.Enabled = true;
            }
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            WebShopForm webShopForm = new WebShopForm();
            webShopForm.Show();
        }

        private void AdministrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePathAnimal))
            {
                string json = JsonHelper.AnimalListToJson(Webshop.animals);
                writer.WriteLine(json);
                // Making sure it'll write to file
                writer.Flush();
            }
            using (StreamWriter writer = new StreamWriter(filePathProduct))
            {
                string json = JsonHelper.ProductListToJson(Webshop.products);
                writer.WriteLine(json);
                //Making sure it'll write to file
                writer.Flush();
            }
            using (StreamWriter writer = new StreamWriter(filePathBuyer))
            {
                string json = JsonHelper.BuyerListToJson(Webshop.buyers);
                writer.WriteLine(json);
                //Making sure it'll write to file
                writer.Flush();
            }
        }

        private void GetData(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                StringBuilder sb = new StringBuilder();
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    sb.Append(line);
                }

                if (filePath == filePathAnimal)
                {
                    // Making sure list is empty, so there will not be double objects
                    Webshop.animals.Clear();
                    foreach (Animal animal in JsonHelper.JsonToListAnimal(sb.ToString()))
                    {
                        Webshop.animals.Add(animal);
                    }
                }
                else if (filePath == filePathProduct)
                {
                    Webshop.products.Clear();
                    foreach (Product product in JsonHelper.JsonToListProduct(sb.ToString()))
                    {
                        Webshop.products.Add(product);
                    }
                }
                else if (filePath == filePathBuyer)
                {
                    Webshop.buyers.Clear();
                    foreach (Buyer buyer in JsonHelper.JsonToListBuyer(sb.ToString()))
                    {
                        Webshop.buyers.Add(buyer);
                    }
                }
            }
        }
    }
}
