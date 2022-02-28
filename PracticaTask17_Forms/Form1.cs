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
                    label3.Text = "OK";
                    label3.BackColor = Color.Green;


                }
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = textBox1.Text;
            if (textBox1.Text != "")
            {
                String[] linesOfFile = File.ReadAllLines(openFileDialog1.FileName);
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
                        File.AppendAllText(openFileDialog1.FileName, request);
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
