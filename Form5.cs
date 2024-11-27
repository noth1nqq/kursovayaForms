using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayaForms
{
    public partial class Form5 : Form
    {
        public Form5(string countMas)
        {
            InitializeComponent();
            label2.Text = $"У вас закончились попытки!\nЗагаданное число: {countMas}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1Autoriz frm1 = new Form1Autoriz();//Form1
            frm1.Show();
            this.Hide();
        }
    }
}
