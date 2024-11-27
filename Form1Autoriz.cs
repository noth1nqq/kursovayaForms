namespace kursovayaForms
{
    public partial class Form1Autoriz : Form
    {
        string level = "Легкий";
        static string nick = "";

        public Form1Autoriz()
        {
            InitializeComponent();
            /*textBox1.Text = UserData.nick;*/
            textBox1.Text = nick;
            /*this.BackColor = Color.LightBlue;*/


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*UserData.nick = textBox1.Text.ToString();*/
            nick = textBox1.Text.ToString();
            Form3 newfrm3 = new Form3();//Form3 
            newfrm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*UserData.nick = textBox1.Text.ToString();*/
            nick = textBox1.Text.ToString();
            level = comboBox2.SelectedItem.ToString();
            Form2Game newfrm = new Form2Game(nick, level);//Form2 
            newfrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lead6 frm6 = new lead6();
            frm6.Show();
            this.Hide();
        }
    }
}
