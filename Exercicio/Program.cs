using Exercicio.Domain.Entities;
using Exercicio.Domain.Enums;
using Exercicio.Domain.Valueobjects;
using Flunt.Notifications;
using System;
namespace Exercicio.Principal
{
    class Program :Notifiable
    {
        static void Main(string[] args)
        {

            var titular = new Titular("alex","Green");
            //Titular titular = new Titular("Alex", "Green");

            if (titular.Notifications.Count > 0)
            {
                foreach (Notification n in titular.Notifications)
                {
                    Console.WriteLine(n.Message);
                }
            }

            Console.WriteLine("Saldo inicial ?");
            //string saldoIni = Console.ReadLine();
            string saldoIni = "s";
            Acount acount;
            if (saldoIni.Substring(0, 1) == "s")
            {
                acount = new Acount("8532", TipoConta.Corrente, titular, 500.00);
            }
            else
            {
                acount = new Acount("8532", TipoConta.Corrente, titular);
            }

         
            Console.WriteLine($"Conta criada com saldo inicial = {acount.Balance}");

            acount.depositar(200);
            Console.WriteLine($"Saldo = {acount.Balance}");
            var sucesso = acount.sacar(300);

            if (sucesso == false)
            {

                var t = acount.Notifications.Count;
                foreach(Notification n in acount.Notifications)
                {
                    Console.WriteLine(n.Message);
                }

            }
            else
            {

                Console.WriteLine($"Saldo = {acount.Balance}");
                Console.WriteLine($"limite = {acount.Limite}");

            }
            Console.ReadKey();
        }
    }
}