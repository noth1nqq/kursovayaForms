using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayaForms
{
    public partial class Form2Game : Form
    {
        string checkNum = "";
        int cows = 0; // Подсчет коров
        int bulls = 0; // Подсчет быков
        int input = 0; // Переменная
        int[] masGuy = new int[4]; // Массив чисел игрока
        int[] masAI = new int[4]; // Массив загаданного числа компьютером
        int attempts = 0; // Количество попыток
        int prompt = 0; //подсказка
        Random rnd = new Random();
        int tick = 0;
        public Form2Game(string nick, string level)
        {
            InitializeComponent();

            // Установка количества попыток в зависимости от выбранного уровня
            label20.Text = level;
            label21.Text = nick;

            switch (level)
            {
                case "Легкий": attempts = 15; break;
                case "Средний": attempts = 10; break;
                case "Сложный": attempts = 5; break;
            }

            // Генерация уникальных случайных чисел для masAI
            for (int j = 0; j < 4; j++)
            {
                bool check;
                do
                {
                    input = rnd.Next(1, 9);
                    check = masAI.Contains(input) == false;
                } while (!check);
                masAI[j] = input;
            }

            for (int j = 0; j < 4; j++)
            {
                checkNum += masAI[j];
            }
            label23.Text = checkNum;
            //вывод для себя
            label24.Text = $"Осталось: {attempts}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string countMas = "";
            //число пользователя
            int variable = 0;
            

            if (Int32.TryParse(Convert.ToString(comboBox1.SelectedItem), out masGuy[0]) && Int32.TryParse(Convert.ToString(comboBox2.SelectedItem), out masGuy[1]) && Int32.TryParse(Convert.ToString(comboBox3.SelectedItem), out masGuy[2]) && Int32.TryParse(Convert.ToString(comboBox4.SelectedItem), out masGuy[3]))
            {



                bool trueOrFalse = true;
                label5.Text = "";

                for (int j = 0; j < 4; j++)
                {
                    countMas += masGuy[j];
                }
                input = Convert.ToInt32(countMas);
                if (attempts != 0)
                {
                    //записываем введенные пользователем числа в переменную

                    for (int cws = 0; cws < 4; cws++)
                        masGuy[cws] = 0;
                    //обнуляем чтобы проверить на схожие числа

                    for (int j = 0; j < 4; j++)
                    {
                        variable = input % 10;
                        input = input / 10;

                        // Проверка, существует ли число в masGuy
                        for (int cws = 0; cws < 4; cws++)
                        {
                            if (trueOrFalse == false)
                                break;
                            //если нашло однажды false, то больше не проходит проверка
                            if (masGuy[cws] == variable)
                            {
                                trueOrFalse = false;
                                break;
                                //если находит одинаковое число, то сброс цикла
                            }
                        }

                        // Если trueOrFalse все еще true, записываем число в masGuy
                        if (trueOrFalse == true)
                        {
                            masGuy[3 - j] = variable;
                        }
                    }
                    if (trueOrFalse == false)
                    {
                        label22.Text = "Числа повторяются, попробуйте еще раз!";
                        ++attempts;
                        //если false, то пользватель снова вводит число, и шаг сбрасывается
                    }
                    else
                    {
                        bulls = 0; cows = 0;
                        for (int cc = 0; cc < 4; cc++)
                        {
                            if (masAI[cc] == masGuy[cc]) bulls++; // Совпадение по индексу

                            for (int cws = 0; cws < 4; cws++)
                            {
                                if (masGuy[cc] == masAI[cws] && masAI[cc] != masGuy[cc])
                                    cows++;
                                //если число массива пользоваля совпадает с числом компьютера и в это же время разные индексы
                                //то коровы прибавляются
                            }
                        }
                        if (bulls == 4)
                        {
                            string path = @"C:\учеба\С#\курсовая\top.txt";
                            string path2 = @"C:\учеба\С#\курсовая\nicks.txt";

                            string text2 = File.ReadAllText(path2);
                            string text = File.ReadAllText(path);

                            text = $"{label20.Text}\t\t{attempts}\t\t Победа\t\t {tick}\n" + text;
                            text2 = $"{label21.Text}\n" + text2;
                            File.WriteAllText(path, text);
                            File.WriteAllText(path2, text2);
                            //запись в файл
                            Form4 frm4 = new Form4(countMas);//Form4 - четвертая форма
                            frm4.Show();
                            this.Hide();
                            //отгадал всех быков
                        }
                        else
                        {
                            // Вывод результатов

                            number1.Text += $"{countMas}\n";
                            bull1.Text += $"{bulls}\n";
                            cow1.Text += $"{cows}\n";
                            //
                        }
                    }

                    //вывод оставшехся попыток
                }
                else
                {
                    string path = @"C:\учеба\С#\курсовая\top.txt";
                    string path2 = @"C:\учеба\С#\курсовая\nicks.txt";

                    string text2 = File.ReadAllText(path2);
                    string text = File.ReadAllText(path);

                    text = $"{label20.Text}\t\t{attempts}\t\t Поражение\t {tick}\n" + text;
                    text2 = $"{label21.Text}\n" + text2;
                    File.WriteAllText(path, text);
                    File.WriteAllText(path2, text2);

                    //записываем в txt файл
                    Form5 frm5 = new Form5(checkNum);
                    frm5.Show();
                    this.Hide();
                    //если не смог отгадать число
                }


                label24.Text = $"Попыток: {--attempts}";



            }
            else
            {
                label22.Text = $"Выберите числа из выпадающего списка!";
                return;
            }



            /*masGuy[0] = Convert.ToInt32(comboBox1.SelectedItem);
			masGuy[1] = Convert.ToInt32(comboBox2.SelectedItem);
			masGuy[2] = Convert.ToInt32(comboBox3.SelectedItem);
			masGuy[3] = Convert.ToInt32(comboBox4.SelectedItem);*/
            //присваивание массиву игрока значений

            // Подсчет быков и коров


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (prompt == 1)
            {
                label5.Text = "Доступна только 1 подсказка на игру!";
            }
            else
            {
                prompt = rnd.Next(0, 3); //подсказка
                label5.Text = $"Присутвует число: {masAI[prompt]}";
                prompt = 1;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1Autoriz frm1 = new Form1Autoriz();//Form3 -- вторая форма
            frm1.Show();
            this.Hide();
        }

        private void number3_Click(object sender, EventArgs e)
        {

        }

        private void cow1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label6.Text = $"Прошло времени: { tick++} сек";
        }
    }
}
