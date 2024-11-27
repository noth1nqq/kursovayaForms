namespace kursovayaForms
{
    partial class lead6
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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(217, 4);
            label1.Name = "label1";
            label1.Size = new Size(317, 50);
            label1.TabIndex = 0;
            label1.Text = "Последние игры";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.DarkSlateGray;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(186, 133);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(602, 318);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "123";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(142, 476);
            button1.Name = "button1";
            button1.Size = new Size(489, 72);
            button1.TabIndex = 2;
            button1.Text = "Вернуться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.DarkSlateGray;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox2.ForeColor = Color.White;
            richTextBox2.Location = new Point(12, 133);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(168, 318);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "123";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(68, 92);
            label2.Name = "label2";
            label2.Size = new Size(71, 38);
            label2.TabIndex = 4;
            label2.Text = "Ник";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(168, 92);
            label3.Name = "label3";
            label3.Size = new Size(107, 31);
            label3.TabIndex = 5;
            label3.Text = "Уровень";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(316, 68);
            label4.Name = "label4";
            label4.Size = new Size(130, 62);
            label4.TabIndex = 6;
            label4.Text = "Попыток \r\nосталось";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(474, 92);
            label5.Name = "label5";
            label5.Size = new Size(146, 31);
            label5.TabIndex = 7;
            label5.Text = "Результат";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(642, 92);
            label6.Name = "label6";
            label6.Size = new Size(140, 31);
            label6.TabIndex = 8;
            label6.Text = "Время(сек)";
            // 
            // lead6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 597);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "lead6";
            Text = "lead6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button button1;
        private RichTextBox richTextBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}