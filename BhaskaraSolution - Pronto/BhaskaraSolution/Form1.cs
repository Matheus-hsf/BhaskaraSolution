using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Bhaskár : Form
    {
        public Bhaskár()
        {
            InitializeComponent();
        }
        double vlaorX1 = 0;
        double vlaorX2 = 0;
        double raiz1 = 0;
        double raiz2 = 0;
        double a = 0;
        double b = 0;
        double c = 0;
        double x1 = 0;
        double x2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tex1.Text);
            b = Convert.ToDouble(tex2.Text);
            c = Convert.ToDouble(tex3.Text);

            x1 =Math.Sqrt(b * b - (4 * a * c));
            raiz1 = Convert.ToDouble(x1);
            x1 = -1 * b + x1;
            vlaorX1 = Convert.ToDouble(x1);
            x1 = x1 / (2 * a);

            x2 = Math.Sqrt(b * b - (4 * a * c));
            raiz2 = Convert.ToDouble(x2);
            x2 = -1 * b - x2;
            vlaorX2 = Convert.ToDouble(x2);
            x2 = x2 / (2 * a);

            tex4.Text = Convert.ToString(x1);
            tex5.Text = Convert.ToString(x2);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe o (a), o (b) e o (c) da equação. Exemplo 3x² + 5x - 14; Neste exemplo o a = 3, o b = 5 e o c = -14.     Se uma das respostas estiver em forma de fração ele sera apresentada de forma decimal. Se a mensagem (NaN) provavelmente o número da raiz deu um valor negativo ou não exato.");
        }

        private void btnPassoApasso_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "-" + (tex2.Text) + "+-" + "Raiz de:" + "(" + tex2.Text + "*" + tex2.Text + "-" + "4" + "*" + tex1.Text + "*" + tex3.Text + ")" );
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(vlaorX1.ToString() + "/" + "2*" + tex1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-" + (tex2.Text) + "+" + raiz1.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(x1.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-" + (tex2.Text) + "-" + raiz2.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vlaorX2.ToString() + "/" + "2*" + tex1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(x2.ToString());
        }
       
    }
}
