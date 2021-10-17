using System;

namespace ConsoleAppMultifuncional
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double peso;
            double altura;
            double resultado;
            double salario;
            double salario_minimo;
            double Raio;
            double nota_1, nota_2, nota_3, nota_4;
            double media;
            bool validacao = true;

            Program program = new Program();

            Console.WriteLine("##### Seja muito bem vindo ao Console do Biel!! #####");

            do
            {

                Console.WriteLine("Quais das nossas funcionalidades você deseja utilizar?");
                Console.WriteLine("(1) 'Será que estou acima do peso?' Calcule o seu IMC agora mesmo!!");
                Console.WriteLine("(2) Confira quantos salários mínimos você recebe de forma simples e rápida!!");
                Console.WriteLine("(3) Quer saber o volume de uma esfera em um problema matemático? Vem comigo que eu te ajudo!!");
                Console.WriteLine("(4) Calcule sua média aritmética sem anúncios e sem enrolação!!");
                Console.WriteLine("(5) Grave as informações dos seus pets aqui!!");
                Console.WriteLine("(6) Sair");

                Console.WriteLine("Digite sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Digite seu peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite sua altura desta forma Ex-'1,65': ");
                        altura = Convert.ToDouble(Console.ReadLine());

                        resultado = program.IMC(peso, altura);
                        Console.WriteLine("*O resultado do seu IMC é {0}!*", Math.Round(resultado, 2));

                        if (resultado < 20)
                        {
                            Console.WriteLine("**Abaixo do peso Ideal**");

                        }
                        else if (resultado >= 25)
                        {
                            Console.WriteLine("**Acima do peso Ideal**");
                        }
                        else
                        {
                            Console.WriteLine("**Peso Ideal**");
                        }

                        break;

                    case 2:

                        Console.WriteLine("Digite seu salário: ");
                        salario = Convert.ToDouble(Console.ReadLine());

                        salario_minimo = 1100;
                        resultado = program.Salario(salario, salario_minimo);
                        Console.WriteLine("*O seu salário equilave a {0} salários mínimos!*", Math.Round(resultado, 2));

                        break;

                    case 3:

                        Console.WriteLine("Digite o Raio da esfera que te direi o Volume dela: ");
                        Raio = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Volume(Raio);
                        Console.WriteLine("*O volume da esfera é {0}*", resultado);

                        break;

                    case 4:

                        Console.WriteLine("Digite a sua primeira nota: ");
                        nota_1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a sua segunda nota: ");
                        nota_2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a sua terceira nota: ");
                        nota_3 = Convert.ToDouble(Console.ReadLine());

                        media = program.Media(nota_1, nota_2, nota_3);
                        Console.WriteLine("*Sua média é de {0}", Math.Round(media, 2));

                        if (media >= 7)
                        {
                            Console.WriteLine("**Parabéns! Você está Aprovado!**");

                        } if (media < 7)
                        {
                            Console.WriteLine("*Digite a nota do exame: ");
                            nota_4 = Convert.ToDouble(Console.ReadLine());

                            resultado = program.Media_Final(media, nota_4);
                            Console.WriteLine("*Sua média é de {0}", Math.Round(resultado, 2));
                            
                            if (resultado >= 5)
                            {
                                Console.WriteLine("*Aprovado em exame!*");
                            } else
                            {                             
                                Console.WriteLine("*Reprovado*");
                            }
                        
                        }

                        break;

                    case 5:


                        break;

                    case 6:

                        validacao = false;
                        Console.WriteLine("Aperte ENTER para sair");
                        break;
                }
                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();                

            } while (validacao);
                       
        }

        public double IMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public double Salario(double salario, double salario_minimo)
        {
            return salario / salario_minimo;
        }

        public double Volume(double Raio)
            /*Após usar essa lógica para a potência do raio, pesquisei e descobri o método 'Math.Pow' 
             * e o Thiago Santos mandou no Slack também, mas preferi deixar a linha de raciocínio original.
             */ 
        {
            return 3 * 3.14 * Raio * Raio * Raio / 4;
        }

        public double Media(double nota_1, double nota_2, double nota_3)
        {
            return (nota_1 + nota_2 + nota_3) / 3;
        }

        public double Media_Final(double media, double nota_4) 
        {
            return (media + nota_4) / 2;
        }
    }
}
