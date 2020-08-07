using System;

namespace primeira_lista
{
    class Program
    {
        static void Exercise1a()
        {
            Console.WriteLine("Crescente");
            for (int counter = 1; counter < 11; counter++)
            {
                Console.WriteLine(counter);
            }
        }
            
        static void Exercise1b()
        {
            Console.WriteLine("decrescente");
            for (int counter = 10; counter > 0; counter--)
            {
                Console.WriteLine(counter);
            }
        }     

        static void Exercise1c()
        {

             for (int counter = 2; counter < 11; counter += 2)
             {
             Console.WriteLine(counter);
             }
        }
        
        static void Exercise02()
        {

            ////Método while
            // var counter = 1;
            // var sum = 0;
            // while (counter <101)
            // {
            // sum += counter;
            // counter++;
            // Console.WriteLine("a soma dos números inteiros entre 1 e 100 é: ");
            // Console.WriteLine(sum);
            // }
            
            // //Método int for 1
            //  int inicio = 1, final = 100, soma = 0;
            //  for (int total=inicio; total<=final; total++)
            //  {
            //  soma = soma + total;
            //  }
            //  //Console.WriteLine(String.Format("A soma dos números inteiros entre 1 e 100 é: {0}", soma));
            //  Console.WriteLine("A soma dos números inteiros entre 1 e 100 é: "+soma);
             
            //  //Método int for 2 (imprimindo com índice)
            //  int inicio = 1, final = 100, soma = 0;
            //  for (int total=inicio; total<=final; total++)
            //  {
            //  soma = soma + total;
            //  }
            //  Console.WriteLine(String.Format("A soma dos números inteiros entre 1 e 100 é: {0}", soma));

             //Método var for
            var sum = 0;
            for (int counter = 1; counter < 101; counter++)
            {
				sum += counter;
            }
			Console.WriteLine("A soma dos números inteiros entre 1 e 100 é: "+ sum);
             
        }

        static void Exercise03()
        {

            ////Método while
            // var counter=1;
            // while (counter < 200)
            // {
            //     if (counter % 2 == 1)
            //     {
            //         Console.WriteLine(counter);
            //     }
            //     counter =+2;
            // }
            
            ////Método for
            for (int Counter = 1; Counter < 200; Counter = Counter+=2)
            {
            Console.WriteLine(Counter);
            }
        }

        static void Exercise04()
        {
            var sum = 0.0;
            for (int counter = 0; true; counter++)
            {
                Console.WriteLine("Digite uma idade: ");
                var result = Console.ReadLine();
                if (result == "0")
                {
                    var average = (sum/counter).ToString("0.00");
                    Console.WriteLine($"A média da turma é: {average}");
                    break;
                }
                sum += Int32.Parse(result);
            }
        }   

        static void Exercise05()
        //Criar um algoritmo que peça o nome e a idade de 5 mulheres. Após informar estes dados,
        //o programa deve mostrar apenas porcentagem de mulheres que estão com idade entre 18 e 35.
        {
            int counter=0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("informe seu nome: ");
                Console.ReadLine();
                Console.WriteLine("informe sua idade: ");
                int age=int.Parse (Console.ReadLine());
                if (age>=18 && age<=35 )
                {
                counter++;
                }
                
            }
                Console.WriteLine ("A porcentagem de mulheres que têm entre 18 e 35 anos é de: ");
                double porcentagem = (counter*100/5);
                Console.WriteLine (porcentagem+"%");
    
        }
            
        static void Exercise06()
        {
        
            const string registerMode = "1";
			const string votesMode = "2";
			const string resultMode = "3";

			var candidates = new (string name, int votes)[2];
			
			while (true)
			{
				System.Console.WriteLine("Selecione um dos modos a baixo:");
				System.Console.WriteLine($"{registerMode}) Cadastro de candidatos");
				System.Console.WriteLine($"{votesMode}) Votar");
				System.Console.WriteLine($"{resultMode}) Apuração dos votos");
				var mode = Console.ReadLine();

				if (mode == resultMode)
				{
					break;
				}

				if (mode == registerMode)
				{
					var password = "";
					while (password != "Pa$$w0rd")
					{
						System.Console.WriteLine("Digite a senha");
						password = Console.ReadLine();
					}

                    for (int i = 0; i < candidates.Length; i++)
                    {                   
                        System.Console.WriteLine($"Digite o nome do candidato nº{i + 1}");
                        candidates[i].name = Console.ReadLine();
                    }
				}

				if (mode == votesMode)
				{
					System.Console.WriteLine($"Vote 1 para o candidato: {candidates[0].name} ou 2 para o candidato: {candidates[1].name}");
					
					var vote = Int32.Parse(Console.ReadLine());
					candidates[vote - 1].votes++;
				}
			}

			if (candidates[0].votes == candidates[1].votes)
			{
				System.Console.WriteLine("Segundo turno!");
			}
			else
			{
				var winner = candidates[0];
                for (int i = 1; i < candidates.Length; i++)
                {
                    var currentCandidate = candidates[i];
                    if (currentCandidate.votes > winner.votes)
                    {
                        winner = currentCandidate;
                    }
                }

				System.Console.WriteLine($"O vencedor é: {winner.name}");
				System.Console.WriteLine($"Com o total de: {winner.votes} votos!");
			}
        }            
        static void Exercise07()
        {
            //Anos que fuma (years)
            //Quantos fuma por dia (amount)
            //preço de um maço (7 reais)
            //um maço têm 20 cigarros

            int years, amount, days;
            double unitprice, packprice, totalcost;
            Console.WriteLine ("A quantos anos você fuma? ");
            years = Int32.Parse (Console.ReadLine());
            Console.WriteLine ("Quantos cigarros você fuma por dia? ");
            amount = Int32.Parse (Console.ReadLine());
            Console.WriteLine ("Quantos reais você paga por uma carteira de cigarros? ");
            unitprice = Double.Parse (Console.ReadLine());
            days = years*365;
            packprice = 20/unitprice;                    
            totalcost = (days*amount)*packprice;                
            Console.WriteLine ("Você já gastou em cigarros o valor de: \n" + totalcost.ToString("0.00"));
            // o valor {0,15:c} faz com que a variável seja impressa no formato monetário
        }        

        static void Exercise08()
        {

            int x, y;
            Console.WriteLine ("Informe o valor de x: ");
            x = Int32.Parse (Console.ReadLine());
            Console.WriteLine ("Informe o valor de y: ");
            y = Int32.Parse (Console.ReadLine());
            if (x % y == 0)
            {
                Console.WriteLine("X é múltiplo de Y");
            }
            else
            {
                Console.WriteLine("X não é múltiplo de Y");
                Console.ReadKey();
            }
        }

        static void Exercise09()
        {

            double n1, n2, n3;
            Console.WriteLine("Informe o valor de n1: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de n2: ");
            n2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de n3: ");
            n3 = Double.Parse(Console.ReadLine());
            if (n1>(n2+n3))
            {
                Console.WriteLine("N1 é maior que a soma de N2 e N3");
            }
            else
            {
                Console.WriteLine("N1 não é maior que a soma de N2 e N3");
            }
        }

        static void Exercise10()
        {

            double A, B;
            Console.WriteLine("Informe o valor de A: ");
            A = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            B = Double.Parse(Console.ReadLine());
            if (A>B)
            {
                Console.WriteLine("A é maior que B");
            }
            else if (A<B)
            {
                Console.WriteLine("B é maior que A");
            }
            else 
            {
                Console.WriteLine("A é igual a B");
            }
        }
                    
        static void Exercise11()
        {

            int x, y, divisão;
            Console.WriteLine("Digite um valor para A");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B");
            y = int.Parse(Console.ReadLine());

            if (y != 0)
            {
                divisão = x / y;
                Console.WriteLine("O resultado da divisão de A por B é: "+ divisão);
            }
            else
            {
                Console.WriteLine("Não há divisão por zero.");
            }
                Console.ReadKey();
        }

        static void Exercise12()
        {

            int a = 0, x = 0, soma = 0;

            for (x = 0; x < 4; x++)
            {
                Console.WriteLine("Digite um número: ");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    soma = soma + a;
                }
            }
                    Console.WriteLine();           
                    Console.WriteLine("A soma dos números pares é = "+ soma);
                    Console.ReadKey();
        }

        static void Exercise13()
        {

           var biggestNumber = 0;

            for (int counter = 0; counter < 10; counter++)
            {
                System.Console.WriteLine("Forneça um número");
                var input = Int32.Parse(Console.ReadLine());

                if (input > biggestNumber)
                {
                    biggestNumber = input;
                }
            }

            System.Console.WriteLine("O maior número é:");
            System.Console.WriteLine(biggestNumber);
        }    

        static void Exercise14()
        {

            int a, b, c;

            Console.WriteLine("Digite o primeiro número.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número.");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número.");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c && b < c)
            {
                Console.WriteLine(a +", "+ b +", "+ c);
            }
            
            if (a < b && a < c && c < b)
            {
                Console.WriteLine(a +", "+ c +", "+ b);
            }
            
            if (b < a && b < c && a < c)
            {
                Console.WriteLine(b +", "+ a +", "+ c);
            }
                    
            if (b < a && b < c && c < a)
            {
                Console.WriteLine(b +", "+ c +", "+ a);
            }
            
            if (c < a && c < b && a < b)
            {
                Console.WriteLine(c +", "+ a +", "+ b);
            }
            
            if (c < a && c < b && b < a)
            {
                Console.WriteLine(c +", "+ b +", " +a);
            }
                    Console.ReadKey();
        }    

        static void Exercise17()
        {
              while (true)
            {
                Console.WriteLine("Forneça um número");
                var input = Int32.Parse(Console.ReadLine());

                if (input == -1)
                {
                    break;
                }

                Console.WriteLine("Tabuada:");
                for (var i = 1; i < 11; i++)
                {
                    Console.WriteLine(input * i);
                }
            }
        }
        static void Main (String[] args)
        {
            Exercise07();
        }



      
    }        
}