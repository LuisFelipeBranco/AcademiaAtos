﻿using System;
/*
10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor do saque: R$ ");
        int valor = int.Parse(Console.ReadLine());

        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
        int[] quantidadeNotas = new int[7];

        for (int i = 0; i < 7; i++)
        {
            if (valor >= notas[i])
            {
                quantidadeNotas[i] = valor / notas[i];
                valor = valor % notas[i];
            }
        }

        Console.WriteLine("Notas disponíveis:");
        for (int i = 0; i < 7; i++)
        {
            if (quantidadeNotas[i] > 0)
            {
                Console.WriteLine(quantidadeNotas[i] + " nota(s) de R$ " + notas[i]);
            }
        }

    }
}