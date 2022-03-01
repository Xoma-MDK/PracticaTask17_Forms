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

namespace PracticaTask17_Forms
{
    public partial class Form1 : Form
    {

        public static String fileBase = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog1.FileName;
                    fileBase = openFileDialog1.FileName;
                    //richTextBox1.Text = File.ReadAllText(fileBase);
                    label3.Text = "Открыт: ";
                    label3.Text += openFileDialog1.FileName.Split('\\').Last().Split('.')[0];
                    label3.BackColor = Color.Green;


                }
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = textBox1.Text;
            //richTextBox1.Text = fileBase;
            if (fileBase != "")
            {
                String[] linesOfFile = File.ReadAllLines(fileBase);
                String request = "";
                if (nameOfCompany.Text == "")
                {
                    MessageBox.Show(
                        "Наименование организации не указано!",
                        "Ошибка",
                        MessageBoxButtons.OK
                        );
                }
                else if (postOfJob.Text == "")
                {
                    MessageBox.Show(
                        "Должность не указана!",
                        "Ошибка",
                        MessageBoxButtons.OK
                        );
                }
                else if (levelOfEducation.Text == "")
                {
                    MessageBox.Show(
                        "Уровень образования не указан!",
                        "Ошибка",
                        MessageBoxButtons.OK
                        );
                }
                else if (experienceOfJob.Text == "")
                {
                    MessageBox.Show(
                        "Стаж работы не указан!",
                        "Ошибка",
                        MessageBoxButtons.OK
                        );
                }
                else if (wageOfJob.Text == "")
                {
                    MessageBox.Show(
                        "Заработная плата не указана!",
                        "Ошибка",
                        MessageBoxButtons.OK
                        );
                }
                else if (insuranceList.Text == "")
                {
                    MessageBox.Show(
                        "Наличие соц. пакета не указано!",
                        "Ошибка",
                        MessageBoxButtons.OK
                        );
                }
                else if (vacationOfJob.Text == "")
                {
                    MessageBox.Show(
                        "Продолжительность отпуска не указана!",
                        "Ошибка",
                        MessageBoxButtons.OK
                        );
                }
                else
                {
                    request += nameOfCompany.Text;
                    request += ',';
                    request += postOfJob.Text;
                    request += ',';
                    request += levelOfEducation.Text;
                    request += ',';
                    request += experienceOfJob.Text;
                    request += ',';
                    request += wageOfJob.Text;
                    request += ',';
                    request += insuranceList.Text;
                    request += ',';
                    request += vacationOfJob.Text;
                    if (linesOfFile.Contains(request))
                    {
                        MessageBox.Show(
                            "Вакансия уже есть в базе!",
                            "Ошибка",
                            MessageBoxButtons.OK
                            );
                    }
                    else
                    {
                        request += '\n';
                        File.AppendAllText(fileBase, request);
                        MessageBox.Show(
                            "Вакансия добавлена!",
                            "Успех",
                            MessageBoxButtons.OK
                            );
                    }
                }
            }
            else
            {
                MessageBox.Show(
                        "База данных не открыта!",
                        "Ошибка",
                        MessageBoxButtons.OK
                        );
            }
        }

        private void experienceOfJob_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void wageOfJob_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void vacationOfJob_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fileBase != "")
            {
                String[] linesOfFile = File.ReadAllLines(fileBase);
                if (postOfJob.Text == "" && levelOfEducation.Text == "" && insuranceList.Text == "")
                {
                    MessageBox.Show(
                        "Критерии поиска не заданы!",
                        "Ошибка",
                        MessageBoxButtons.OK
                        );
                }
                else
                {
                    richTextBox1.Clear();
                    foreach (string line in linesOfFile)
                    {
                        if (line.Split(',')[1].Contains(postOfJob.Text) && line.Split(',')[2].Contains(levelOfEducation.Text) && line.Split(',')[5].Contains(insuranceList.Text)){
                            String answer = "Наименование организации: ";
                            answer += line.Split(',')[0];
                            answer += " Должность: ";
                            answer += line.Split(',')[1];
                            answer += " Уровень образования: ";
                            answer += line.Split(',')[2];
                            answer += " Стаж работы: ";
                            answer += line.Split(',')[3];
                            answer += " Зарплата: ";
                            answer += line.Split(',')[4];
                            answer += " руб. Наличие соц. пакета: ";
                            answer += line.Split(',')[5];
                            answer += " Продолжительность отпуска: ";
                            answer += line.Split(',')[6];
                            answer += " дней.";
                            richTextBox1.Text += answer;
                            richTextBox1.Text += '\n';
                        }
                    }
                    if (richTextBox1.Text == "")
                    {
                       MessageBox.Show(
                       "Вакансии не найдены!",
                       "Ошибка",
                       MessageBoxButtons.OK
                       );
                    }
                }
            }
            else
            {
                MessageBox.Show(
                        "База данных не открыта!",
                        "Ошибка",
                        MessageBoxButtons.OK
                        );
            }
        }
    }
}
