using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double gradePoint(double a)
        {
            double i;
            if (a >= 90 && a <= 100)
            {
                i = 4.0;
            }
            else if (a >= 85 && a <= 89)
            {
                i = 4.0;
            }
            else if (a >= 80 && a <= 84)
            {
                i = 3.8;
            }
            else if (a >= 75 && a <= 79)
            {
                i = 3.4;
            }
            else if (a >= 71 && a <= 74)
            {
                i = 3.2;
            }
            else if (a >= 68 && a <= 70)
            {
                i = 2.8;
            }
            else if (a >= 64 && a <= 67)
            {
                i = 2.4;
            }
            else if (a >= 61 && a <= 63)
            {
                i = 2.0;
            }
            else if (a >= 57 && a <= 60)
            {
                i = 1.8;
            }
            else if (a >= 53 && a <= 56)
            {
                i = 1.4;
            }
            else if (a >= 50 && a <= 52)
            {
                i = 1.0;
            }
            else
            {
                i = 0.0;
            }
            return i;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            label10.BackColor = lblFinalGpa.BackColor = Color.Ivory;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            lblFinalGpa.Text = "";
            lbl1Course.Visible = true;         // 4 textboxes
            textBox1.Visible = true;
            lbl2Course.Visible = true;
            textBox2.Visible = true;
            lbl3Course.Visible = true;
            textBox3.Visible = true;
            lbl4Course.Visible = true;
            textBox4.Visible = true;
            lbl5Course.Visible = false;
            textBox5.Visible = false;
            lbl6Course.Visible = false;
            textBox6.Visible = false;
            lbl7Course.Visible = false;
            textBox7.Visible = false;
            lbl8Course.Visible = false;
            textBox8.Visible = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            label10.BackColor = lblFinalGpa.BackColor = Color.Ivory;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            lblFinalGpa.Text = "";
            lbl5Course.Visible = true;              // 5 textboxes
            textBox5.Visible = true;
            lbl6Course.Visible = false;
            textBox6.Visible = false;
            lbl7Course.Visible = false;
            textBox7.Visible = false;
            lbl8Course.Visible = false;
            textBox8.Visible = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            label10.BackColor = lblFinalGpa.BackColor = Color.Ivory;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            lblFinalGpa.Text = "";
            lbl6Course.Visible = true;              // 6 textboxes
            textBox6.Visible = true;
            lbl5Course.Visible = true;
            textBox5.Visible = true;
            lbl7Course.Visible = false;
            textBox7.Visible = false;
            lbl8Course.Visible = false;
            textBox8.Visible = false;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            label10.BackColor = lblFinalGpa.BackColor = Color.Ivory;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            lblFinalGpa.Text = "";
            lbl7Course.Visible = true;              // 7 textboxes
            textBox7.Visible = true;
            lbl6Course.Visible = true;
            textBox6.Visible = true;
            lbl5Course.Visible = true;
            textBox5.Visible = true;
            lbl8Course.Visible = false;
            textBox8.Visible = false;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            label10.BackColor = lblFinalGpa.BackColor = Color.Ivory;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            lblFinalGpa.Text = "";
            lbl8Course.Visible = true;                // 8 textboxes
            textBox8.Visible = true;
            lbl5Course.Visible = true;
            textBox5.Visible = true;
            lbl6Course.Visible = true;
            textBox6.Visible = true;
            lbl7Course.Visible = true;
            textBox7.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (radioButton1.Checked == true)
                {
                    if (textBox1.Text == "")
                        errorProvider1.SetError(textBox1, "This field is mandatory!");
                    if (textBox2.Text == "")
                        errorProvider1.SetError(textBox2, "This field is mandatory!");
                    if (textBox3.Text == "")
                        errorProvider1.SetError(textBox3, "This field is mandatory!");
                    if (textBox4.Text == "")
                        errorProvider1.SetError(textBox4, "This field is mandatory!");

                    double[] gpa = new double[4];
                    double[] products = new double[4];
                    double in1, in2, in3, in4, sum, final;
                    sum = 0;
                    in1 = Convert.ToDouble(textBox1.Text);
                    gpa[0] = gradePoint(in1);

                    in2 = Convert.ToDouble(textBox2.Text);
                    gpa[1] = gradePoint(in2);

                    in3 = Convert.ToDouble(textBox3.Text);
                    gpa[2] = gradePoint(in3);

                    in4 = Convert.ToDouble(textBox4.Text);
                    gpa[3] = gradePoint(in4);

                    for (int i = 0; i < products.Length; i++)
                    {
                        products[i] = gpa[i] * 3;
                    }
                    for (int j = 0; j < products.Length; j++)
                    {
                        sum = sum + products[j];
                    }
                    final = sum / 12;
                    label10.BackColor = lblFinalGpa.BackColor = Color.Tan;
                    lblFinalGpa.Text = final.ToString();
                }

                if (radioButton2.Checked == true)
                {
                    if (textBox1.Text == "")
                        errorProvider1.SetError(textBox1, "This field is mandatory!");
                    if (textBox2.Text == "")
                        errorProvider1.SetError(textBox2, "This field is mandatory!");
                    if (textBox3.Text == "")
                        errorProvider1.SetError(textBox3, "This field is mandatory!");
                    if (textBox4.Text == "")
                        errorProvider1.SetError(textBox4, "This field is mandatory!");
                    if (textBox5.Text == "")
                        errorProvider1.SetError(textBox5, "This field is mandatory!");

                    double[] gpa = new double[5];
                    double[] products = new double[5];
                    double in1, in2, in3, in4, in5, sum, final;
                    sum = 0;
                    in1 = Convert.ToDouble(textBox1.Text);
                    gpa[0] = gradePoint(in1);

                    in2 = Convert.ToDouble(textBox2.Text);
                    gpa[1] = gradePoint(in2);

                    in3 = Convert.ToDouble(textBox3.Text);
                    gpa[2] = gradePoint(in3);

                    in4 = Convert.ToDouble(textBox4.Text);
                    gpa[3] = gradePoint(in4);

                    in5 = Convert.ToDouble(textBox5.Text);
                    gpa[4] = gradePoint(in5);

                    for (int i = 0; i < products.Length; i++)
                    {
                        products[i] = gpa[i] * 3;
                    }
                    for (int j = 0; j < products.Length; j++)
                    {
                        sum = sum + products[j];
                    }
                    final = sum / 15;
                    label10.BackColor = lblFinalGpa.BackColor = Color.Tan;
                    lblFinalGpa.Text = final.ToString();
                }

                if (radioButton3.Checked == true)
                {
                    if (textBox1.Text == "")
                        errorProvider1.SetError(textBox1, "This field is mandatory!");
                    if (textBox2.Text == "")
                        errorProvider1.SetError(textBox2, "This field is mandatory!");
                    if (textBox3.Text == "")
                        errorProvider1.SetError(textBox3, "This field is mandatory!");
                    if (textBox4.Text == "")
                        errorProvider1.SetError(textBox4, "This field is mandatory!");
                    if (textBox5.Text == "")
                        errorProvider1.SetError(textBox5, "This field is mandatory!");
                    if (textBox6.Text == "")
                        errorProvider1.SetError(textBox6, "This field is mandatory!");

                    double[] gpa = new double[6];
                    double[] products = new double[6];
                    double in1, in2, in3, in4, in5, in6, sum, final;
                    sum = 0;
                    in1 = Convert.ToDouble(textBox1.Text);
                    gpa[0] = gradePoint(in1);

                    in2 = Convert.ToDouble(textBox2.Text);
                    gpa[1] = gradePoint(in2);

                    in3 = Convert.ToDouble(textBox3.Text);
                    gpa[2] = gradePoint(in3);

                    in4 = Convert.ToDouble(textBox4.Text);
                    gpa[3] = gradePoint(in4);

                    in5 = Convert.ToDouble(textBox5.Text);
                    gpa[4] = gradePoint(in5);

                    in6 = Convert.ToDouble(textBox6.Text);
                    gpa[5] = gradePoint(in6);

                    for (int i = 0; i < products.Length; i++)
                    {
                        products[i] = gpa[i] * 3;
                    }
                    for (int j = 0; j < products.Length; j++)
                    {
                        sum = sum + products[j];
                    }
                    final = sum / 18;
                    label10.BackColor = lblFinalGpa.BackColor = Color.Tan;
                    lblFinalGpa.Text = final.ToString();
                }

                if (radioButton4.Checked == true)
                {
                    if (textBox1.Text == "")
                        errorProvider1.SetError(textBox1, "This field is mandatory!");
                    if (textBox2.Text == "")
                        errorProvider1.SetError(textBox2, "This field is mandatory!");
                    if (textBox3.Text == "")
                        errorProvider1.SetError(textBox3, "This field is mandatory!");
                    if (textBox4.Text == "")
                        errorProvider1.SetError(textBox4, "This field is mandatory!");
                    if (textBox5.Text == "")
                        errorProvider1.SetError(textBox5, "This field is mandatory!");
                    if (textBox6.Text == "")
                        errorProvider1.SetError(textBox6, "This field is mandatory!");
                    if (textBox7.Text == "")
                        errorProvider1.SetError(textBox7, "This field is mandatory!");

                    double[] gpa = new double[7];
                    double[] products = new double[7];
                    double in1, in2, in3, in4, in5, in6, in7, sum, final;
                    sum = 0;
                    in1 = Convert.ToDouble(textBox1.Text);
                    gpa[0] = gradePoint(in1);

                    in2 = Convert.ToDouble(textBox2.Text);
                    gpa[1] = gradePoint(in2);

                    in3 = Convert.ToDouble(textBox3.Text);
                    gpa[2] = gradePoint(in3);

                    in4 = Convert.ToDouble(textBox4.Text);
                    gpa[3] = gradePoint(in4);

                    in5 = Convert.ToDouble(textBox5.Text);
                    gpa[4] = gradePoint(in5);

                    in6 = Convert.ToDouble(textBox6.Text);
                    gpa[5] = gradePoint(in6);

                    in7 = Convert.ToDouble(textBox7.Text);
                    gpa[6] = gradePoint(in7);

                    for (int i = 0; i < products.Length; i++)
                    {
                        products[i] = gpa[i] * 3;
                    }
                    for (int j = 0; j < products.Length; j++)
                    {
                        sum = sum + products[j];
                    }
                    final = sum / 21;
                    label10.BackColor = lblFinalGpa.BackColor = Color.Tan;
                    lblFinalGpa.Text = final.ToString();
                }

                if (radioButton5.Checked == true)
                {
                    if (textBox1.Text == "")
                        errorProvider1.SetError(textBox1, "This field is mandatory!");
                    if (textBox2.Text == "")
                        errorProvider1.SetError(textBox2, "This field is mandatory!");
                    if (textBox3.Text == "")
                        errorProvider1.SetError(textBox3, "This field is mandatory!");
                    if (textBox4.Text == "")
                        errorProvider1.SetError(textBox4, "This field is mandatory!");
                    if (textBox5.Text == "")
                        errorProvider1.SetError(textBox5, "This field is mandatory!");
                    if (textBox6.Text == "")
                        errorProvider1.SetError(textBox6, "This field is mandatory!");
                    if (textBox7.Text == "")
                        errorProvider1.SetError(textBox7, "This field is mandatory!");
                    if (textBox8.Text == "")
                        errorProvider1.SetError(textBox8, "This field is mandatory!");

                    double[] gpa = new double[8];
                    double[] products = new double[8];
                    double in1, in2, in3, in4, in5, in6, in7, in8, sum, final;
                    sum = 0;
                    in1 = Convert.ToDouble(textBox1.Text);
                    gpa[0] = gradePoint(in1);

                    in2 = Convert.ToDouble(textBox2.Text);
                    gpa[1] = gradePoint(in2);

                    in3 = Convert.ToDouble(textBox3.Text);
                    gpa[2] = gradePoint(in3);

                    in4 = Convert.ToDouble(textBox4.Text);
                    gpa[3] = gradePoint(in4);

                    in5 = Convert.ToDouble(textBox5.Text);
                    gpa[4] = gradePoint(in5);

                    in6 = Convert.ToDouble(textBox6.Text);
                    gpa[5] = gradePoint(in6);

                    in7 = Convert.ToDouble(textBox7.Text);
                    gpa[6] = gradePoint(in7);

                    in8 = Convert.ToDouble(textBox8.Text);
                    gpa[7] = gradePoint(in8);

                    for (int i = 0; i < products.Length; i++)
                    {
                        products[i] = gpa[i] * 3;
                    }
                    for (int j = 0; j < products.Length; j++)
                    {
                        sum = sum + products[j];
                    }
                    final = sum / 24;
                    label10.BackColor = lblFinalGpa.BackColor = Color.Tan;
                    lblFinalGpa.Text = final.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            label10.BackColor = lblFinalGpa.BackColor = Color.Ivory;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            lblFinalGpa.Text = "";
        }
    }
}
