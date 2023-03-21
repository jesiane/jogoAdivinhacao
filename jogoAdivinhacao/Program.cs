using System.Net.Http.Headers;

namespace jogoAdivinhacao
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("\r Bem vindo ao jogo de adivinhação");
                Console.WriteLine("**********************************");
                Console.WriteLine("Escolha o nivel de dificuldade ");
                Console.WriteLine("(1) - Facil (2) - Medio (3) - Dificil");
                Console.WriteLine("Escolha: ");
                int escolha = int.Parse(Console.ReadLine());

                Console.WriteLine("***********************************");

                int numero=0;
                Random rand = new Random();
                int randomNumero = rand.Next(1, 20);
                Console.WriteLine($"Teste Random número: {randomNumero}");

                /*  Dificuldade
                 *  (1) Fácil = 15 chances
                 *  (2) Médio = 10 chances
                 *  (3) Difícil = 5 chances
                */

                /*
                 * pontuação: (numero chutado – numero aleatório) / 2
                 */
                int pontuacao = 1000;

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("\r ** Facil ** ");
                        Console.WriteLine(" Possui 15 chances de acertar o numero ");

                        for (int i = 0; i < 15; i++)
                        {
                            Console.WriteLine("_________________________");
                            Console.WriteLine($" Tentativa {i + 1} de 15 ");
                            Console.WriteLine("Seu palpite: ");
                            numero = int.Parse(Console.ReadLine());

                            if (numero < randomNumero)
                            {
                                Console.WriteLine(" O numero aleatorio é maior");

                            }
                            else if (numero > randomNumero)
                            {
                                Console.WriteLine(" O numero aleatorio é menor");
                            }
                            else
                            {
                                Console.WriteLine($" Parabéns você acertou na {i + 1} tentativa ");

                                break;
                            }

                            pontuacao -= (Math.Abs(numero - randomNumero)) / 2;
                            //pontos = 1000 - pontuacao ;

                            Console.WriteLine($" Pontuação {pontuacao}");


                        }

                        break;

                    case 2:
                        Console.WriteLine("\r ** Medio **");
                        Console.WriteLine("Possui 10 chances de acertas o numero ");


                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("_________________________");
                            Console.WriteLine($" Tentativa {i + 1} de 10 ");
                            Console.WriteLine("Seu palpite: ");
                            numero = int.Parse(Console.ReadLine());

                            if (numero < randomNumero)
                            {
                                Console.WriteLine("O numero aleatorio é maior");
                            }
                            else if (numero > randomNumero)
                            {
                                Console.WriteLine("O numero é menor");
                            }
                            else
                            {
                                Console.WriteLine($" Parabéns você acertou na {i + 1} tentativa ");
                            }
                        break;
                        }

                        break;
                    case 3:
                        Console.WriteLine("\r ** Dificil **");
                        Console.WriteLine("Possui 5 chances de acertas o numero ");

                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("_________________________");
                            Console.WriteLine($" Tentativa {i + 1} de 5 ");
                            Console.WriteLine("Seu palpite: ");
                            numero = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Tentativa numero {i}");
                            Console.WriteLine("_________________________");

                            if (numero < randomNumero)
                            {
                                Console.WriteLine("O numero aleatorio é maior");
                            }
                            else if (numero > randomNumero)
                            {
                                Console.WriteLine("O numero é menor");
                            }
                            else
                            {
                                Console.WriteLine($" Parabéns você acertou na {i + 1} tentativa ");
                            }
                        }
                        break;
                }

              pontuacao = (Math.Abs(numero - randomNumero)/2);
              Console.WriteLine($" A pontuação é {pontuacao}");

        }
    }
    }
