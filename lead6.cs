using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kursovayaForms
{
    public partial class lead6 : Form
    {
        public lead6()
        {
            InitializeComponent();

            string path = @"C:\учеба\С#\курсовая\top.txt";
            string path2 = @"C:\учеба\С#\курсовая\nicks.txt";
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                string text2 = File.ReadAllText(path2);
                // Делайте что-то с текстом
                richTextBox1.Text = text;
                richTextBox2.Text = text2;
                /*text = $"5252";
                File.WriteAllText(path, text);*/
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1Autoriz frm1 = new Form1Autoriz();//Form1
            frm1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
