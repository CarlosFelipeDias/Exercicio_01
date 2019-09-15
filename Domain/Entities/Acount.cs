using Exercicio.Domain.Enums;
using Exercicio.Domain.Valueobjects;
using Exercicio.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Domain.Entities 
{
    public class Acount : Entity
    {
        public Acount(string numero, TipoConta tipoConta, Titular titular, double balance)
        {
            Numero = numero;
            TipoConta = tipoConta;
            this.titular = titular;
            Balance = balance;
            Limite = 200;
        }

        public Acount(string numero, TipoConta tipoConta, Titular titular)
        {
            Numero = numero;
            TipoConta = tipoConta;
            this.titular = titular;
            Balance = 0;
            Limite = 200;
        }

        public string Numero { get; private set; }
        public TipoConta TipoConta { get; private set; }
        public Titular titular { get; private set; }
        public double Balance { get; private set; }
        public double Limite { get; private set; }
        public double depositar(double valor)
        {
            Balance = Balance + valor;
            return Balance;
        }

        public Boolean sacar(double valor)
        {
            var teste = Math.Abs(10);
            if (valor > Balance && (Math.Abs(Balance - valor) > Limite))
            {
                AddNotification("Balance", "Esse saque excedeo limite :(");
                return false;
            }
            Balance = Balance - valor;
            return true;
        }
    }
}
