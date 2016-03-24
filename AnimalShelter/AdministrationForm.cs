using System;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        public AdministrationForm()
        {
            InitializeComponent();

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
    }
}
