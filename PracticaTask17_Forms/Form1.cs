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
                    String[] sringsInFile = File.ReadAllLines(openFileDialog1.FileName);
                    
                }
            }
            catch { 
            
            }
            
        }

    }
}
