using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            bool sair = false;

            while (!sair)
            {

                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Soma;");
                Console.WriteLine("2 - Área do círculo;");
                Console.WriteLine("3 - Diferença de produtos;");
                Console.WriteLine("4 - Cálculo de salário;");
                Console.WriteLine("5 - Saldo de peças;");
                Console.WriteLine("6 - Contas de geometria;");
                Console.WriteLine("7 - Sair");

                int i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:

                        p.Soma();
                        break;

                    case 2:

                        p.AreaCirculo();
                        break;

                    case 3:

                        p.DiferencaProduto();
                        break;

                    case 4:

                        p.SalarioFuncionario();
                        break;

                    case 5:

                        p.SomaValorPeca();
                        break;

                    case 7:

                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida! Selecione um número válido.");
                        break;
                }

                Console.ReadKey();

            }


        }

        public int Soma()
        {
            int n1;
            int n2;
            int soma;
            Console.WriteLine("Insira o primeiro número:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor:");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma = n1 + n2;
            Console.WriteLine("SOMA = " + soma);
            Console.WriteLine("Insira qualquer valor para retornar;");

            return soma;
        }

        public double AreaCirculo()
        {
            double pi = 3.14159;
            double areaCirculo;

            Console.WriteLine("Insira o valor do raio:");
            double raio = Convert.ToDouble(Console.ReadLine());

            areaCirculo = Math.Pow(raio, 2) * pi;

            Console.WriteLine(areaCirculo.ToString("F4", CultureInfo.InvariantCulture));

            return areaCirculo;
        }

        public int DiferencaProduto()
        {
            Console.WriteLine("Insira o valor de A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor de B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor de C:");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor de D:");
            int D = Convert.ToInt32(Console.ReadLine());

            int diferenca = (A * B - C * D);

            Console.WriteLine("Diferença:" + diferenca.ToString());
            Console.WriteLine("Insira qualquer valor para retornar;");

            return diferenca;
        }

        public double SalarioFuncionario()
        {
            Funcionario func = new Funcionario();
            Console.WriteLine("Insira o código do funcionário:");
            func.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de horas trabalhadas:");
            func.QtdHoras = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor por hora:");
            func.ValorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Código do funcionário:" + func.Codigo.ToString());

            double salario = Convert.ToDouble(func.QtdHoras) * func.ValorHora;
            Console.WriteLine("Salário:" + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Insira qualquer valor para retornar;");
            return salario;
        }

        public double SomaValorPeca()
        {
            Peca peca1 = new Peca();
            Peca peca2 = new Peca();
           
            Console.WriteLine("Insira o número da primeira peça:");
            peca1.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de peças:");
            peca1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor unitário da peça:");
            peca1.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número da segunda peça:");
            peca2.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de peças:");
            peca2.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor unitário da segunda peça:");
            peca2.Preco = double.Parse(Console.ReadLine());

            double valorTotal = (Convert.ToDouble(peca1.Quantidade) * peca1.Preco) + (Convert.ToDouble(peca2.Quantidade) * peca2.Preco);

            Console.WriteLine("VALOR A PAGAR:" + valorTotal.ToString("2F", CultureInfo.InvariantCulture));
            Console.WriteLine("Insira qualquer valor para retornar;");

            return valorTotal;
        }

        public double ContasDeGeometria()
        {
            double pi = 3.14159;
            Console.WriteLine("Insira o valor de A:");
            double medidaA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor de B:");
            double medidaB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor de C:");
            double medidaC = Convert.ToDouble(Console.ReadLine());

            double areaTriangulo = (medidaA * medidaC) / 2;
            double areaCirculo = pi * Math.Pow(medidaC, 2);
            double areaTrapezio = (Math.Max(medidaA, medidaB) + Math.Min(medidaA, medidaB)) * medidaC / 2;
            double areaQuadrado = Math.Pow(medidaB, 2);
            double areaRetangulo = medidaB * medidaA;

            Console.WriteLine("Área do triângulo:" + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do círculo:" + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do trapézio:" + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do quadrado:" + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Retângulo:" + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("Insira qualquer valor para retornar;");
            return pi;
        }
    }
}
