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
    public partial class Form4 : Form
    {
        public Form4(string countMas)
        {
            InitializeComponent();
            label2.Text = $"Вы отгадали всех 4-ех быков!\nЗагаданное число: {countMas}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1Autoriz frm1 = new Form1Autoriz();//Form1
            frm1.Show();
            this.Hide();
        }
    }
}
