using System.Net.Http.Headers;

namespace jogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\r Bem vindo ao jogo de adivinhação");
            Console.ResetColor();
            Console.WriteLine("**********************************");
            Console.WriteLine("Escolha o nivel de dificuldade ");
            Console.WriteLine("(1) Facil - (2) Medio - (3) Dificil");
            Console.Write("Escolha: ");
            int escolha = int.Parse(Console.ReadLine());

            Console.WriteLine("***********************************");

            int grau = 0, aleatorio = 0, pontuacao = 1000;
            Random rand = new Random();
            String nome;
            int randomNumero = rand.Next(1, 20);
            Console.WriteLine($"Teste Random número: {randomNumero}");

            if (escolha == 1)
            {
                grau = 15;
                Console.WriteLine($"O grau de dificuldade escolhido é Facil ");
                Console.WriteLine($"Você possui {grau} chances");

            }
            if (escolha == 2)
            {
                grau = 10;
                Console.WriteLine($"O grau de dificuldade escolhido é Médio ");
                Console.WriteLine($"Você possui {grau} chances");

            }
            if (escolha == 3)
            {
                grau = 5;
                Console.WriteLine($"O grau de dificuldade escolhido é Dificil ");
                Console.WriteLine($"Você possui {grau} chances");
            }

            for (int i = 0; i < grau; i++)
                {
                    Console.WriteLine("_________________________");
                    Console.WriteLine($" Tentativa {i + 1} de {grau} ");
                    Console.WriteLine("Seu palpite deve estar entre 1 e 20: ");
                    aleatorio = int.Parse(Console.ReadLine());

                if (aleatorio <= 20) {

                    if (aleatorio < randomNumero)
                    {
                        Console.WriteLine(" O numero do sistema é maior");
                    }
                    else if (aleatorio > randomNumero)
                    {
                        Console.WriteLine(" O numero do sistema é menor");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" Parabéns você acertou na {i + 1} tentativa ");
                        Console.ResetColor();
                        break;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Os numeros devem ser menores ou igual a 20");
                    Console.ResetColor();
                }


            }
           
                pontuacao = (Math.Abs(aleatorio - randomNumero) / 2);
                Console.WriteLine($"A pontuação é {pontuacao}");
        }
    }  
}