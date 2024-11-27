namespace kursovayaForms
{
    partial class Form1Autoriz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Autoriz));
            button1 = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(35, 330);
            button1.Name = "button1";
            button1.Size = new Size(185, 68);
            button1.TabIndex = 0;
            button1.Text = "Правила";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumAquamarine;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.White;
            button2.Location = new Point(255, 330);
            button2.Name = "button2";
            button2.Size = new Size(249, 68);
            button2.TabIndex = 1;
            button2.Text = "Начать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Легкий", "Средний", "Сложный" });
            comboBox2.Location = new Point(370, 220);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 36);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Легкий";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, 220);
            label1.Name = "label1";
            label1.Size = new Size(226, 31);
            label1.TabIndex = 4;
            label1.Text = "Уровень сложности:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(229, 53);
            label2.Name = "label2";
            label2.Size = new Size(292, 50);
            label2.TabIndex = 5;
            label2.Text = "Быки и Коровы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(94, 168);
            label3.Name = "label3";
            label3.Size = new Size(105, 31);
            label3.TabIndex = 6;
            label3.Text = "Ваш ник:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(370, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 31);
            textBox1.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(539, 330);
            button3.Name = "button3";
            button3.Size = new Size(185, 68);
            button3.TabIndex = 8;
            button3.Text = "Последние игры";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1Autoriz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(751, 450);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1Autoriz";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button3;
    }
}