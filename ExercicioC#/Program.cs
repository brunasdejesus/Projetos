using System;

namespace Exercício___Calcular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos Calcular!");

            int NumeroDigitado1;
            int NUmeroDigitado2;
            int numero;

            int Resto;
            int Dividido;
            int Soma;
            int Subtração;
            int Multiplicação;

            Console.Write("Insira o primeiro número: ");

            NumeroDigitado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("insira o segundo número: ");

            NUmeroDigitado2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Escolha a operação matemática");

            Console.WriteLine("Soma = 1");
            Console.WriteLine("Subtração = 2");
            Console.WriteLine("Divisão = 3");
            Console.WriteLine("Multiplicação = 4");

            Console.WriteLine("insira o número: ");

            numero = Convert.ToInt32(Console.ReadLine());

            Resto = NumeroDigitado1 % NUmeroDigitado2;

            Dividido = NumeroDigitado1 / NUmeroDigitado2;

            Soma = NumeroDigitado1 + NUmeroDigitado2;

            Subtração = NumeroDigitado1 - NUmeroDigitado2;

            Multiplicação = NumeroDigitado1 * NUmeroDigitado2;


           if ( numero == 1)
            {
                Console.WriteLine("O Resultado é: " + Soma);
            }

           if(numero == 2)
            {
                Console.WriteLine("O Resultado é: " + Subtração);
            }

           if(numero == 3)
                if (Resto != 0)
                {
                Console.WriteLine("O Resultado é: " + Dividido);
                    Console.WriteLine("O Resultado é: " + Resto);
            }

           
           else
           
            {
                Console.WriteLine("O Resultado é: " + Dividido);

                
            }

           if(numero == 4)
            {
                Console.WriteLine("O Resultado é: " + Multiplicação);
            }
            
           if(numero > 4)
            {
                Console.WriteLine("A opção escolhida deve estar entre 1 e 4 da classe dos inteiros");
            }

            if (numero < 1)
            {
                Console.WriteLine("A opção escolhida deve estar entre 1 e 4 da classe dos inteiros");
            }

          
        }

    }
}
