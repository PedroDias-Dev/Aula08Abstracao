using System;

namespace Aula8Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 3000f;
            Console.WriteLine("Quanto deseja acrescentar no limite?");
            float acres = float.Parse(Console.ReadLine());

            visa.AumentarLimite(acres);
            Console.WriteLine("Novo limite: R$" +visa.limite);

            System.Console.WriteLine("Digite a data de pagamento:");
            visa.data = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Data: " +visa.data);

            //

            CartaoCredito elo = new CartaoCredito();
            elo.limite = 1500f;
            Console.WriteLine("Quanto deseja acrescentar no limite?");
            float acres1 = float.Parse(Console.ReadLine());

            elo.AumentarLimite(acres1);
            Console.WriteLine("Novo limite: R$" +elo.limite);

            System.Console.WriteLine("Digite a data de pagamento:");
            visa.data = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Data: " +visa.data);
        }
    }
}
