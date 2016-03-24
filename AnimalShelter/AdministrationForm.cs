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
        }

        private void btn_AddAnimal_Click(object sender, EventArgs e)
        {
            if (cb_AnimalType.SelectedItem.Equals("Cat"))
            {
                Cat cat = new Cat(tb_AnimalName.Text,
                    tb_AnimalAge.Text,
                    (Gender) cb_AnimalGender.SelectedItem,
                    null,
                    tb_BadHabit.Text);
                lb_Animals.Items.Add(cat);
            }
            if (cb_AnimalType.SelectedItem.Equals("Dog"))
            {
                Dog dog = new Dog(tb_AnimalName.Text,
                    tb_AnimalAge.Text,
                    (Gender) cb_AnimalGender.SelectedItem,
                    null,
                    dtp_LastWalkDate.Value);
                lb_Animals.Items.Add(dog);
            }

            tb_AnimalName.Clear();
            tb_AnimalAge.Clear();
            tb_BadHabit.Clear();
        }


        /*
        private void btn_Shop_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal) lb_Animals.SelectedItem;
            if (animal.IsReserved != null)
            {
                MessageBox.Show("This one is already taken by " + animal.IsReserved);
            }
            else
            {
                WebShopForm reserveForm = new WebShopForm(animal);
                reserveForm.Show();
            }
        }*/

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
            if (cb_AnimalType.SelectedItem.Equals("Cat"))
            {
                dtp_LastWalkDate.Enabled = false;
            }
            if (cb_AnimalType.SelectedItem.Equals("Dog"))
            {
                tb_BadHabit.Enabled = false;
            }
        }
    }
}
