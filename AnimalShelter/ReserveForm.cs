using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class ReserveForm : Form
    {
        private readonly Animal animal;

        public ReserveForm(Animal Animal)
        {
            animal = Animal;
            InitializeComponent();
        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            if (tb_ReservorName.Text == "" || tb_ReservorName == null)
            {
                MessageBox.Show("Insert name please");
            }
            Reservor reservor = new Reservor(tb_ReservorName.Text, DateTime.Now);
            animal.IsReserved = reservor.ToString();
            Close();
        }
    }
}
