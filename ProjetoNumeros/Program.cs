using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoNumeros
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Impar();
            //Soma();
            //Dividir();
            //Quadrado();  
            //SomaPar();
        }

        public static void Impar()
        {
            int inicial, resultado;
            inicial = 2;

            while (inicial <= 40) //Enquanto a variavel inicial for menor ou igual a 40 a repetição continua
            {
                resultado = inicial % 2;


                if (resultado == 0)
                {
                    Console.WriteLine(inicial);
                    inicial = inicial + 1;

                }
                else
                {
                    inicial = inicial + 1;
                }
            }
        }

        public static void Soma()
        {
            int num1, resultado;
            num1 = 1;
            resultado = 0;

            while (num1 <=100)
            {
                
                resultado = resultado + num1;   // variavel "resultado" começa com valor 0 e vai sendo somado
                num1 ++;                        // com a variavem num1. A variavel num recebe um incremento
                                                // a cada laço.
            }
            Console.WriteLine(resultado);




        }

        public static void Dividir() 
        {
            int num1, resultado;
            num1 = 1;
            
            while (num1 <= 40)
            {
                resultado = num1 % 4;
                if (resultado == 0)
                {
                    Console.WriteLine(num1);
                    num1 = num1 + 1;
                }
                else
                {
                    num1 = num1 + 1;
                }
            }
        }

        public static void Quadrado() 
        {
            double num1,resultado;
            num1 = 15f;

             while (num1 >= 15 && num1 <= 200)
            {
                resultado = Math.Sqrt(num1); // método matemático que retorna a raiz de um número do tipo double
                Console.WriteLine("A raiz quadrada de " + num1 + " é: " + resultado);
                num1 = num1 + 1;
            }

        }

        public static void SomaPar() 
        {
            int num1,num2, resto;
            num1 = 1;
            num2 = 0;

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
            Console.WriteLine(num2);
        }
    }
}