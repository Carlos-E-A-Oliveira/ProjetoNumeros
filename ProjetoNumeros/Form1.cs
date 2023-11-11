using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int inicial, resultado;
            inicial = 2;
            richTextBox1.Clear();

            while (inicial <= 40) //Enquanto a variavel inicial for menor ou igual a 40 a repetição continua
            {
                 resultado = inicial % 2;


                if (resultado == 1)
                {
                    richTextBox1.AppendText(String.Format("{0}{1}", inicial, Environment.NewLine));
                    inicial = inicial + 1;

                }
                else
                {
                    inicial = inicial + 1;
                }

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, resultado;
            num1 = 1;
            resultado = 0;
            richTextBox1.Clear();

            while (num1 <= 100)
            {

                resultado = resultado + num1;   // variavel "resultado" começa com valor 0 e vai sendo somado
                num1++;                         // com a variavem num1. A variavel num recebe um incremento
                                                // a cada laço.
            }
            richTextBox1.AppendText(String.Format("{0}{1}", "A soma de 1 á 100 é: "+resultado, Environment.NewLine));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, resultado;
            num1 = 1;
            richTextBox1.Clear();

            while (num1 < 40)
            {
                resultado = num1 % 4;
                if (resultado == 0)
                {
                    richTextBox1.AppendText(String.Format("{0}{1}",num1, Environment.NewLine));
                    num1 = num1 + 1;
                }
                else
                {
                    num1 = num1 + 1;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, resultado;
            num1 = 15f;
            richTextBox1.Clear();

            while (num1 >= 15 && num1 <= 200)
            {
                resultado = Math.Sqrt(num1); // método matemático que retorna a raiz de um número do tipo double
                richTextBox1.AppendText(String.Format("{0}{1}", "A raiz quadrada de " + num1 + " é: " + resultado, Environment.NewLine));
                num1 = num1 + 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1, num2, resto;
            num1 = 1;
            num2 = 0;
            richTextBox1.Clear();

            while (num1 <= 50)
            {
                resto = num1 % 2;
                if (resto == 0)
                {
                    num2 = num2 + num1;
                    num1 = num1 + 1;
                }
                else
                {
                    num1 = num1 + 1;
                }
            }
            richTextBox1.AppendText(String.Format("{0}{1}","A soma de todos os pares entre 1 e 50 é: " + num2, Environment.NewLine));
            
        }
    }
}
