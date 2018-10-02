using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string op;
            Calc calcula = new Calc();
            inputCalc recebeData = new inputCalc();
            viewCalc Tela = new viewCalc();
            Tela.exibir();

            op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Tela.informarVar();
                    a = recebeData.ler();
                    b = recebeData.ler();
                    calcula.Soma(a, b);
                    break;

                case "2":
                    Tela.informarVar();
                    a = recebeData.ler();
                    b = recebeData.ler();
                    calcula.Sub(a, b);
                    break;

                case "3":
                    Tela.informarVar();
                    a = recebeData.ler();
                    b = recebeData.ler();
                    calcula.Mult(a, b);
                    break;

                case "4":
                    Tela.informarVar();
                    a = recebeData.ler();
                    b = recebeData.ler();
                    calcula.Sub(a, b);
                    break;

                default: Console.WriteLine("opção inválida");
                    break;
            }
        }
    }

    class Calc
    {        
        public void Soma(int a, int b)
        {            
            Console.WriteLine("Resultado: "+ (a + b) + "\n");
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine("Resultado: " + (a - b) + "\n");
        }

        public void Mult(int a, int b)
        {
            Console.WriteLine("Resultado: " + (a * b) + "\n");
        }

        public void Div(int a, int b)
        {
            Console.WriteLine("Resultado: " + (a / b) + "\n");
        }


    }

    class inputCalc
    {
        public int ler()
        {
            int x;            
            x = int.Parse(Console.ReadLine());
            return x;
        }
    }

    class viewCalc
    {
        public void exibir()
        {
            Console.WriteLine("Digite");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Selecionar opção:");
        }
        public void informarVar()
        {
            Console.WriteLine("Digite A e B:");
        }
    }
}
