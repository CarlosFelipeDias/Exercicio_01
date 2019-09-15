using Exercicio.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Domain.Valueobjects
{
    public class Acount
    {
        public Acount(string firstName, string lastName,  string numero, TipoConta tipoConta,double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Numero = numero;
            TipoConta = tipoConta;
            Balance = balance;
        }

        public Acount(string firstName, string lastName, string numero, TipoConta tipoConta)
        {
            FirstName = firstName;
            LastName = lastName;
            Numero = numero;
            TipoConta = tipoConta;
            Balance = 0;
        }

       
       
        
    }
}
