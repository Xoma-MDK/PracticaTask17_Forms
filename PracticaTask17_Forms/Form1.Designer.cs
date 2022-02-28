namespace PracticaTask17_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.levelOfEducation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.postOfJob = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameOfCompany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.experienceOfJob = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wageOfJob = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.insuranceList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.vacationOfJob = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(766, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Обзор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(335, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к файлу базы вакансий:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(688, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Статус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(766, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Error";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Записать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // levelOfEducation
            // 
            this.levelOfEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelOfEducation.FormattingEnabled = true;
            this.levelOfEducation.Items.AddRange(new object[] {
            "Среднее общее",
            "Среднее профессиональное",
            "Высшее",
            "1 разряд",
            "2 разряд",
            "3 разряд",
            "4 разряд",
            "5 разряд"});
            this.levelOfEducation.Location = new System.Drawing.Point(367, 133);
            this.levelOfEducation.Name = "levelOfEducation";
            this.levelOfEducation.Size = new System.Drawing.Size(170, 28);
            this.levelOfEducation.SelectedIndex = 0;
            this.levelOfEducation.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Уровень образования \r\n(разряд)*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postOfJob
            // 
            this.postOfJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postOfJob.FormattingEnabled = true;
            this.postOfJob.Items.AddRange(new object[] {
            "Сварщик",
            "Программист",
            "Уборщик",
            "Художник",
            "Дизайнер"});
            this.postOfJob.Location = new System.Drawing.Point(210, 133);
            this.postOfJob.Name = "postOfJob";
            this.postOfJob.Size = new System.Drawing.Size(151, 28);
            this.postOfJob.SelectedIndex = 0;
            this.postOfJob.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Должность*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameOfCompany
            // 
            this.nameOfCompany.Location = new System.Drawing.Point(23, 133);
            this.nameOfCompany.Name = "nameOfCompany";
            this.nameOfCompany.Size = new System.Drawing.Size(181, 27);
            this.nameOfCompany.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "Наименование\r\nорганизации*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // experienceOfJob
            // 
            this.experienceOfJob.Location = new System.Drawing.Point(543, 133);
            this.experienceOfJob.Name = "experienceOfJob";
            this.experienceOfJob.Size = new System.Drawing.Size(143, 27);
            this.experienceOfJob.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 40);
            this.label7.TabIndex = 13;
            this.label7.Text = "Стаж работы\r\nпо специальности*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wageOfJob
            // 
            this.wageOfJob.Location = new System.Drawing.Point(692, 134);
            this.wageOfJob.Name = "wageOfJob";
            this.wageOfJob.Size = new System.Drawing.Size(125, 27);
            this.wageOfJob.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(707, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 40);
            this.label8.TabIndex = 15;
            this.label8.Text = "Заработная\r\nплата*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insuranceList
            // 
            this.insuranceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insuranceList.FormattingEnabled = true;
            this.insuranceList.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.insuranceList.Location = new System.Drawing.Point(23, 194);
            this.insuranceList.Name = "insuranceList";
            this.insuranceList.Size = new System.Drawing.Size(181, 28);
            this.insuranceList.SelectedIndex = 0;
            this.insuranceList.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Наличие соц. пакета*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Продолжительность отпуска*";
            // 
            // vacationOfJob
            // 
            this.vacationOfJob.Location = new System.Drawing.Point(210, 195);
            this.vacationOfJob.Name = "vacationOfJob";
            this.vacationOfJob.Size = new System.Drawing.Size(215, 27);
            this.vacationOfJob.TabIndex = 19;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 249);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(836, 76);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 337);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.vacationOfJob);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.insuranceList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wageOfJob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.experienceOfJob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameOfCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.postOfJob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.levelOfEducation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Вакансии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox levelOfEducation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox postOfJob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameOfCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox experienceOfJob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wageOfJob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox insuranceList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vacationOfJob;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
