using System;

class Loja{
    static void Main(){

        double produto, valorPago, valorParcelas, resto;
        int plano;
        string [] item = new string [50];
        
        Console.WriteLine("Promoção imperdível Loja Brasileira!!!!!");
        Console.WriteLine("Qual item você adquiriu em nossa loja?");
        item[0] = Console.ReadLine();
        Console.WriteLine("Qual o valor do produto comprado?");
        produto=Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Escolha o plano de pagamento.");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Opção 1: Á vista no dinheiro 25% de desconto.");
        Console.WriteLine("Opção 2: Á vista no crédito 15% de desconto.");
        Console.WriteLine("Opção 3: Pagamento em 2x no crédito 10% de desconto.");
        Console.WriteLine("Opção 4: Pagamento em 3x no crédito 5% de desconto.");
        Console.WriteLine("Opção 5: Pagamento em 10x no crédito sem desconto.");

        plano=Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch(plano){
            case 1:
                valorPago = Math.Round(produto * 0.25,2);
                resto = produto - valorPago;
                Console.WriteLine("Pagamento á vista em dinheiro: R$ {0} - item: {1}\n", resto, item[0]);
            break;
            case 2:
                valorPago = Math.Round(produto * 0.15,2);
                resto = produto - valorPago;
                Console.WriteLine("Pagamento á vista no crédito: R$ {0} - item: {1}\n", resto, item[0]);
            break;
            case 3:
                valorPago = Math.Round(produto * 0.10,2);
                resto = produto - valorPago;
                valorParcelas = Math.Round(resto / 2,2);
                Console.WriteLine("Valor final do produto é: R$ {0} em 2x de R$ {1} - item: {2}\n",resto,valorParcelas,item[0]);
            break; 
            case 4:
                valorPago = Math.Round(produto * 0.05,2);
                resto = produto - valorPago;
                valorParcelas = Math.Round(resto / 3,2);
                Console.WriteLine("Valor final do produto é: R$ {0} em 3x de R$ {1} - item: {2}\n",resto,valorParcelas,item[0]);
            break;
            case 5:
                valorPago = Math.Round(produto,2);
                valorParcelas = Math.Round(valorPago / 10,2);
                Console.WriteLine("Valor final do produto é: R$ {0} em 10x de R$ {1} - item: {2}\n",valorPago, valorParcelas, item[50]);
            break;
            default:
                Console.WriteLine("Opção inválida.\n");
            break;  
        }
    }
}
