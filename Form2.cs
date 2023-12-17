using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA6_OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Shape s1;
        Shape s2;
        Form1 f;
        public Form2(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }
        public void setVisibleH1()
        {
            labelx4_1.Visible = true;
            labelx5_1.Visible = true;
            labelx6_1.Visible = true;
            labely4_1 .Visible = true;
            labely5_1.Visible = true;
            labely6_1.Visible = true;
            textBoxX4_1.Visible = true;
            textBoxX5_1.Visible = true; 
            textBoxX6_1.Visible = true;
            textBoxY4_1.Visible = true;
            textBoxY5_1.Visible = true;
            textBoxY6_1.Visible = true;
            
        }
        public void setVisibleH2()
        {
            labelx4_2.Visible = true;
            labelx5_2.Visible = true;
            labelx6_2.Visible = true;
            labely4_2.Visible = true;
            labely5_2.Visible = true;
            labely6_2.Visible = true;
            textBoxX4_2.Visible = true;
            textBoxX5_2.Visible = true;
            textBoxX6_2.Visible = true;
            textBoxY4_2.Visible = true;
            textBoxY5_2.Visible = true;
            textBoxY6_2.Visible = true;
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (f.getCheckBox(1) == true)
            {
                s1 = ShapeFactory.CreateShape('T');
            }
            else if (f.getCheckBox(2) == true)
            {
                s1 = ShapeFactory.CreateShape('H');
                setVisibleH1();
            }
            if (f.getCheckBox(3) == true)
            {
                s2 = ShapeFactory.CreateShape('T');
            }
            else if(f.getCheckBox(4) == true)
            {
                s2 = ShapeFactory.CreateShape('H');
                setVisibleH2();
            }
            
        }
        


        
        //ввод координат 
        private void textBoxX1_1FormTT_TextChanged(object sender, EventArgs e)
        {
            
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX1_1FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxX1_1FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x1");
                    textBoxX1_1FormTT.Clear();
                    return;
                }
                    

            }
            s1.initPointsByIndex('x',0,value);
        }

        private void textBoxX2_1FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX2_1FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxX2_1FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x1");
                    textBoxX2_1FormTT.Clear();
                    return;
                }


            }
            s1.initPointsByIndex('x', 1, value);
        }

        private void textBoxX3_1FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX3_1FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxX3_1FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x2");
                    textBoxX3_1FormTT.Clear();
                    return;
                }


            }
            s1.initPointsByIndex('x', 2, value);
        }

        private void textBoxY1_1FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY1_1FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxY1_1FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x2");
                    textBoxY1_1FormTT.Clear();
                    return;
                }


            }
            s1.initPointsByIndex('y', 0, value);
        }

        private void textBoxY2_1FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY2_1FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxY2_1FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x1");
                    textBoxY2_1FormTT.Clear();
                    return;
                }


            }
            s1.initPointsByIndex('y', 1 ,value);
        }

        private void textBoxY3_1FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY3_1FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxY3_1FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x1");
                    textBoxY3_1FormTT.Clear();
                    return;
                }


            }
            s1.initPointsByIndex('y', 2, value);
        }

        private void textBoxX1_2FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX1_2FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxX1_2FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x1");
                    textBoxX1_2FormTT.Clear();
                    return;
                }


            }
            s2.initPointsByIndex('x', 0, value);
        }

        private void textBoxX2_2FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX2_2FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxX2_2FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x1");
                    textBoxX2_2FormTT.Clear();
                    return;
                }


            }
            s2.initPointsByIndex('x', 1, value);
        }

        private void textBoxX3_2FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX3_2FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxX3_2FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x1");
                    textBoxX3_2FormTT.Clear();
                    return;
                }


            }
            s2.initPointsByIndex('x', 2, value);
        }

        private void textBoxY1_2FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY1_2FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxY1_2FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x1");
                    textBoxY1_2FormTT.Clear();
                    return;
                }


            }
            s2.initPointsByIndex('y', 0, value);
        }

        private void textBoxY2_2FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY2_2FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxY2_2FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x1");
                    textBoxY2_2FormTT.Clear();
                    return;
                }


            }
            s2.initPointsByIndex('y', 1, value);
        }

        private void textBoxY3_2FormTT_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY3_2FormTT.Text);
            }
            catch (Exception)
            {
                if (textBoxY3_2FormTT.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x1");
                    textBoxY3_2FormTT.Clear();
                    return;
                }


            }
            s2.initPointsByIndex('y', 2, value);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxSquare1.Text = Convert.ToString(s1.getSquare());
            textBoxSquare2.Text = Convert.ToString(s2.getSquare());

            int cx1 = s1.getCenter().x;
            int cy1 = s1.getCenter().y;
            int cx2 = s2.getCenter().x;
            int cy2 = s2.getCenter().y;

            textBoxCenter1.Text = $"({cx1},{cy1})";
            textBoxCenter2.Text = $"({cx2},{cy2})";

            if (Operation.isInclude(s1, s2))
            {
                textBoxInclude.Text = "Да";
            }
            else
            {
                textBoxInclude.Text = "Нет";
            }

            if (Operation.isIntersected(s1, s2))
            {
                textBoxIntersection.Text = "Да";
            }
            else
            {
                textBoxIntersection.Text = "Нет";
            }


        }

        private void buttonMov1_Click(object sender, EventArgs e)
        {
            int movx = Convert.ToInt32(textBoxMov1x.Text);
            int movy = Convert.ToInt32(textBoxMov1y.Text);
            s1.move(movx, movy);
            textBoxX1_1FormTT.Text = Convert.ToString(s1.Points[0].x);
            textBoxX2_1FormTT.Text = Convert.ToString(s1.Points[1].x);
            textBoxX3_1FormTT.Text = Convert.ToString(s1.Points[2].x);

            textBoxY1_1FormTT.Text = Convert.ToString(s1.Points[0].y);
            textBoxY2_1FormTT.Text = Convert.ToString(s1.Points[1].y);
            textBoxY3_1FormTT.Text = Convert.ToString(s1.Points[2].y);
            if (s1.getCountPoints() > 3)
            {
                textBoxX4_1.Text = Convert.ToString(s1.Points[3].x);
                textBoxX5_1.Text = Convert.ToString(s1.Points[4].x);
                textBoxX6_1.Text = Convert.ToString(s1.Points[5].x);

                textBoxY4_1.Text = Convert.ToString(s1.Points[3].y);
                textBoxY5_1.Text = Convert.ToString(s1.Points[4].y);
                textBoxY6_1.Text = Convert.ToString(s1.Points[4].y);
            }
        }

        private void buttonMov2_Click(object sender, EventArgs e)
        {
            int movx = Convert.ToInt32(textBoxMov2x.Text);
            int movy = Convert.ToInt32(textBoxMov2y.Text);
            s2.move(movx, movy);

            textBoxX1_2FormTT.Text = Convert.ToString(s2.Points[0].x);
            textBoxX2_2FormTT.Text = Convert.ToString(s2.Points[1].x);
            textBoxX3_2FormTT.Text = Convert.ToString(s2.Points[2].x);

            textBoxY1_2FormTT.Text = Convert.ToString(s2.Points[0].y);
            textBoxY2_2FormTT.Text = Convert.ToString(s2.Points[1].y);
            textBoxY3_2FormTT.Text = Convert.ToString(s2.Points[2].y);
            if (s2.getCountPoints() > 3)
            {
                textBoxX4_2.Text = Convert.ToString(s2.Points[3].x);
                textBoxX5_2.Text = Convert.ToString(s2.Points[4].x);
                textBoxX6_2.Text = Convert.ToString(s2.Points[5].x);
                textBoxY4_2.Text = Convert.ToString(s2.Points[3].y);
                textBoxY5_2.Text = Convert.ToString(s2.Points[4].y);
                textBoxY6_2.Text = Convert.ToString(s2.Points[5].y);
            }
            

        }

        private void textBoxX4_1_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX4_1.Text);
            }
            catch (Exception)
            {
                if (textBoxX4_1.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x4");
                    textBoxX4_1.Clear();
                    return;
                }
            }
            s1.initPointsByIndex('x', 3, value);

        }

        private void textBoxX5_1_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX5_1.Text);
            }
            catch (Exception)
            {
                if (textBoxX5_1.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x5");
                    textBoxX5_1.Clear();
                    return;
                }
            }
                s1.initPointsByIndex('x', 4, value);
        }

        private void textBoxX6_1_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX6_1.Text);
            }
            catch (Exception)
            {
                if (textBoxX6_1.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x6");
                    textBoxX6_1.Clear();
                    return;
                }
            }
                s1.initPointsByIndex('x', 5, value);
        }

        private void textBoxY4_1_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY4_1.Text);
            }
            catch (Exception)
            {
                if (textBoxY4_1.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты y4");
                    textBoxY4_1.Clear();
                    return;
                }
            }
                s1.initPointsByIndex('y', 3, value);
        }

        private void textBoxY5_1_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY5_1.Text);
            }
            catch (Exception)
            {
                if (textBoxY5_1.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты y5");
                    textBoxY5_1.Clear();
                    return;
                }
            }
                s1.initPointsByIndex('y', 4, value);
        }

        private void textBoxY6_1_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY6_1.Text);
            }
            catch (Exception)
            {
                if (textBoxY6_1.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты y6");
                    textBoxY6_1.Clear();
                    return;
                }
            }
                s1.initPointsByIndex('y', 5, value);
        }

        private void textBoxX4_2_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX4_2.Text);
            }
            catch (Exception)
            {
                if (textBoxX4_2.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x4");
                    textBoxX4_2.Clear();
                    return;
                }
            }
                s2.initPointsByIndex('x', 3, value);
        }

        private void textBoxX5_2_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX5_2.Text);
            }
            catch (Exception)
            {
                if (textBoxX5_2.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты x5");
                    textBoxX5_2.Clear();
                    return;
                }
            }
                s2.initPointsByIndex('x', 4, value);
        }

        private void textBoxX6_2_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxX6_2.Text);
            }
            catch (Exception)
            {
                if (textBoxX6_2.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты X6");
                    textBoxX6_2.Clear();
                    return;
                }
            }
                s2.initPointsByIndex('x', 5, value);
        }

        private void textBoxY4_2_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY4_2.Text);
            }
            catch (Exception)
            {
                if (textBoxY4_2.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты y4");
                    textBoxY4_2.Clear();
                    return;
                }
            }
                s2.initPointsByIndex('y', 3, value);
        }

        private void textBoxY5_2_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY5_2.Text);
            }
            catch (Exception)
            {
                if (textBoxY5_2.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты y5");
                    textBoxY5_2.Clear();
                    return;
                }
            }
                s2.initPointsByIndex('y', 4, value);
        }

        private void textBoxY6_2_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = Convert.ToInt32(textBoxY6_2.Text);
            }
            catch (Exception)
            {
                if (textBoxY6_2.Text != "")
                {
                    MessageBox.Show("Неправильное значение координаты y6");
                    textBoxY6_2.Clear();
                    return;
                }
            }
                s2.initPointsByIndex('y', 5, value);
        }
    }

}
