using System;

namespace primeira_lista
{
    class Program
    {
        static void Main(string[] args)
        {
        //      EXERCÍCIO 1) A) imprimir os num de 1 a 10 em forma crescente
        //      int contador = 1;
        //      while (contador <=10)
        //{
        //      Console.WriteLine(contador);
        //     // A linha abaixo significa que será acrescido +1 ao valor do contador
        //      contador++;
        
        //      EXERCÍCIO 1) B) imprimir os num de 1 a 10 de forma decrescente
        //      int contador = 10;
        //      while (contador >=1)
        //{
        //      Console.WriteLine(contador);
        //     // A linha abaixo significa que será subtraido -1 ao valor do contador
        //      contador--;

        //      EXERCÍCIO 1) C) imprimir os num de 1 a 10 de forma crescente mas apenas os pares
        //      for (int contador = 2; contador <= 10; contador = contador+2)        
        //{
        //      Console.WriteLine(contador);

        // //   EXERCÍCIO 2) imprimir a soma dos num inteiros de 1 a 100
        //      int inicio = 1, final = 100, soma = 0;

        //     //Percorrer todos os valores entre 1 e 100 e somar estes valores
        //      for (int total=inicio; total<=final; total++)
        //     {
        //     //Vai somando todos os valores
        //     soma = soma + total;
        //     }
        //     //Apresenta o resultado na tela
        //     Console.WriteLine(String.Format("O resultado da soma é: {0}", soma));

        //     //Aguarda até que uma tecla seja pressionada
        //     Console.ReadKey();

        //      EXERCÍCIO 3) imprimir todos os num impares menores que 200
             for (int contador = 1; contador <= 200; contador = contador+2)        
        {
             Console.WriteLine(contador); 
        }

        }
    }
}
