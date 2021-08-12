using System;
using System.Collections.Generic;

namespace console_desafio21dias_api
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vinda, Valkiria!\n");
            var opcao = "s";
            var nome = "";
            var matricula = "";
            var resultado = "";
            
            List<dynamic> alunos = new List<dynamic>();
            while(opcao.ToLower() == "s")
            {
                Console.WriteLine("Digite o nome do aluno:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a matrícula do aluno:");
                matricula = Console.ReadLine();
                Console.WriteLine("Digite as notas do aluno:");
                double[] notas = new double[3];
                double soma = 0;
                double media = 0;
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{i + 1}ª nota:");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    soma += notas[i];
                }
                media = soma/notas.Length;
                if(media >= 7)
                {
                    resultado = "Aprovado";
                }
                else
                {
                    resultado = "Reprovado";
                }
                alunos.Add(new{
                    Nome = nome,
                    Matricula = matricula,
                    Notas = notas,
                    Media = media,
                    Situacao = resultado
                });
                
                Console.Clear();
                Console.WriteLine("Cadastrar outro aluno? s/n");
                opcao = Console.ReadLine();
            }
            Console.Clear();
            foreach(var aluno in alunos)
            {
                Console.WriteLine("────────────────────────────────");
                Console.WriteLine($"Nome: {aluno.Nome} - Matrícula: {aluno.Matricula}");
                Console.WriteLine("────────────────────────────────");
                Console.WriteLine($"Notas:");
                int n = 1;
                foreach(double nota in aluno.Notas)
                {
                    Console.WriteLine($"{n}ª nota: {nota}");
                    n += 1;
                }
                Console.WriteLine($"Média: {Math.Round(aluno.Media,1)} - Situação: {aluno.Situacao}");
            }
            Console.WriteLine("────────────────────────────────");
        }
    }
}
