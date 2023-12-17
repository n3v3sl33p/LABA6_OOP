using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA6_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool getCheckBox(int i)
        {
            switch (i)
            {
                case 1:
                    return checkBox1.Checked;
                case 2:
                    return checkBox2.Checked;
                case 3:
                    return checkBox3.Checked;
                case 4:
                    return checkBox4.Checked;
                default:
                    return false;
                    
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
