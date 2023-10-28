using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(radioCirc.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3); 
            areaCirc.Text = area1.ToString(); 
            VolumenCirc.Text = volumen1.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioCirc.Text = "";
            areaCirc.Text = "";
            VolumenCirc.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            double Base;   
            double altura, area;
            Base = double.Parse(textBox1.Text);
            altura = double.Parse(textBox2.Text) ;
            area = Base * altura/2 ;
            textBox3.Text = area.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a;
            double volumen, area;
            a = double.Parse(textBox4.Text);
            volumen = a * a * a ;
            area = 6*a*a;
            textBox5.Text = area.ToString();
            textBox6.Text = volumen.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double radio, altura;
            double pi = 3.1416;
            double volumen, area;
            radio = double.Parse(textBox7.Text);
            altura = double.Parse(textBox8.Text);
            volumen = pi * radio * radio * altura;
            area = (2* pi * altura * radio) + (pi+pi * radio * radio * altura);
            textBox9.Text = area.ToString();
            textBox10.Text = volumen.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            double D,d;
            double area;
            D = double.Parse(textBox11.Text);
            d = double.Parse(textBox12.Text);
            area = (D * d)/ 2;
            textBox13.Text = area.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";   

        }

        private void button13_Click(object sender, EventArgs e)
        {

            double a;
            double area, volumen;
            a = double.Parse(textBox14.Text);
            volumen = (1.41 / 3) * (a * a * a);
            area = (2/1.73)*(a*a);
            textBox15.Text = area.ToString();
            textBox16.Text = volumen.ToString();   
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "0";
            textBox15.Text = "0";       
            textBox16.Text = "0";       

        }
    }
}
