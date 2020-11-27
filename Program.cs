using System;

namespace Ex_sexta
{
    class Program
    {
        static void Main(string[] args)
        {
    // Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

    // Os produtos terão os seguintes atributos:

    // - string Nome
    // - float Preco
    // - bool Promocao (se está em promoção ou não)
            
            //Declaração de variaveis
            string[] nomes = new string [10];
            bool[] promocao = new bool [10];
            float[] preco = new float [10];
            int escolha;
            int contador = 0;
            string resposta;
            string[] resposta2 = new string [3];
            
            
            Console.Clear();
            Console.WriteLine("----- Produtos ------");

            do
            {
                Console.WriteLine("O que deseja?");
                Console.WriteLine("[1] - Verificar um produto");
                Console.WriteLine("[2] - Listar produto");
                Console.WriteLine("[0] - sair");

                escolha = int.Parse(Console.ReadLine());
                
                switch (escolha)
                {
                    case 1:
                    Console.WriteLine("Ok! Verificar um produto.");
                    do
                    {
                        if(contador <= 10){
                            Console.WriteLine($"Digite o nome do {contador+1}° produto que deseja verificar: ");
                            nomes[contador] = Console.ReadLine();
                            Console.WriteLine("Digite o preço desse produto: ");
                            preco[contador] = float.Parse(Console.ReadLine());
                            Console.WriteLine("Produto está em promoção?");
                            resposta2[contador] = Console.ReadLine();
                            
                            contador++; 
                        }else if (resposta2[contador].ToLower() == "sim"){
                            promocao[contador] = true;
                        }else if (resposta2[contador].ToLower() == "não"){
                             promocao[contador] = false;
                        }else{

                            Console.WriteLine("Limite de verificação de apenas 10 produtos.");
                            break;
                        }
                        
                        Console.WriteLine("Deseja verificar outro produto? [Sim] [Não]");
                        resposta = Console.ReadLine();
                    } while (resposta.ToLower() == "Sim");
                    Console.Clear();
                        break;                       
                    
                    //Listar produto
                    case 2:
                    Console.WriteLine("Listar produtos");
                    for (var i = 0; i < contador; i++)
                    {
                        Console.WriteLine($"Produto {i+1}: {nomes[i]}, Preço: {preco[i]} R$, Promoção: {resposta2[i]}");
                    }
                    break;
                    
                    case 0: 
                    //sair
                    Console.WriteLine("Obrigado por usar nosso serviço!");
                    break;
                    
                    default:
                    Console.WriteLine("Digite um número válido.");
                    break;
                }
                
            } while (escolha != 0);

        }
    }
}
