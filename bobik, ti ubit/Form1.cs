using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bobik__ti_ubit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
        }
        string[] names = {""}; //массив имён игроков

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for(int i = names.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                string temp = names[j];
                names[j] = names[i];
                names[i] = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cur = comboBox1.Text;
            for(int i = 0; i < names.Length; i++)
            {
                if (names[i] == cur && i!=names.Length-1)
                {
                    textBox1.Text = names[i + 1];
                    break;
                }
                else
                {
                    textBox1.Text = names[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
    }
}
