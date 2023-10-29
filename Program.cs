using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string data = " ";
            char type = ' ';
            int time = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("#-----------------------------#");
                Console.WriteLine("#     Menu  Temporizador      #");
                Console.WriteLine("#-----------------------------#");
                Console.WriteLine("[S] = Segundo => 10s(Segundos)#");
                Console.WriteLine("[M] = Minuto  =>  1m(Minutos) #");
                Console.WriteLine("[0] = Sair    =>  00(Sair)    #");
                Console.WriteLine("#-----------------------------#");

                Console.WriteLine("Quanto tempo deseja contar?");

                data = Console.ReadLine().ToLower();

                if (data.Length != 0)
                {
                    type = char.Parse(data.Substring(data.Length - 1, 1));
                    time = int.Parse(data.Substring(0, data.Length - 1));
                }
                else
                {
                    type = char.Parse(data.Substring(data.Length, 1));
                    time = int.Parse(data.Substring(0, data.Length));
                }

                switch (type)
                {
                    case 's': TemporizadorEmSegundos(time); break;
                    case 'm': TemporizadorEmMinutos(time); break;
                    case '0': Sair(); break;
                    default: OpcaoInvalida(); break;
                }

            } while (data != "0");
        }

        static void TemporizadorEmSegundos(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch Finalizado!");
            Thread.Sleep(2500);
        }

        static void TemporizadorEmMinutos(int time)
        {
            int currentTime = 0;

            while (currentTime != time * 60)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch Finalizado!");
            Thread.Sleep(2500);
        }

        static void OpcaoInvalida()
        {
            Console.Clear();
            Console.WriteLine("Opção Inválida!");
            Console.WriteLine("Digite Novamente!");
            Console.ReadKey();
            Console.Clear();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Aplicação encerrada com sucesso!...");
            Thread.Sleep(1000);
            //Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Aplicação encerrada com sucesso!..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Aplicação encerrada com sucesso!.");
            Thread.Sleep(1000);
            Console.Clear();
            System.Environment.Exit(0);
        }
    }
}
