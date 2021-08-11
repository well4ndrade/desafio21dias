using System;

namespace console_desafio21dias_api
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOOPS:

            //Daniel é um agricultor e precisa de um programa que ao digitar número inicial e final, 
            //o programa mostra repetidamente todos os números na tela.
            /*
            Console.WriteLine("Digite o número inicial:");
            var numeroInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número final:");
            int numeroFinal = Convert.ToInt32(Console.ReadLine());

            for(int i = numeroInicial; i <= numeroFinal; i++)
            {
                Console.WriteLine(i);
            }
            
            int[] itens = new int[]{1,2,3,4,5,6,7,8,9,10};
            foreach(int item in itens)
            {
                Console.WriteLine(item);
            }
            
            return;
            */

            while(true)
            {
                Console.WriteLine("Digite\n1 - para sair\n0 - para continuar");
                int sair = Convert.ToInt32(Console.ReadLine());
                if(sair == 1) break;
                else if(sair == 2) continue;

                Console.WriteLine("Opa passou por aqui!");
            }
                      
            // INTRODUÇÃO A VARIÁVEIS E DECISÕES:
            /**
            Console.WriteLine("Digite o primeiro número:");
            var numeroUm = 11;//Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numeroDois = 20;//Convert.ToInt32(Console.ReadLine());

            var soma = numeroUm * numeroDois;

            //Console.WriteLine($"Qual é o resultado da soma dos números {numeroUm} + {numeroDois} ?");
            Console.WriteLine("Digite o número premiado?");
            int resultado = 20;//Convert.ToInt32(Console.ReadLine());

            if(soma == resultado || resultado == 1 || resultado == 10 || (resultado >= 100 && resultado <= 200))
            {
                Console.WriteLine($"Parabéns você acertou o resultado: {soma}.");
            }
            else if (resultado == 20)
            {
                Console.WriteLine($"Você acertou a opção extraordinária, incrível!");
            }
            else
            {
                Console.WriteLine($"Você errou, o resultado certo é {soma}, tente novamente!");
            }
            */
        }
    }
}
