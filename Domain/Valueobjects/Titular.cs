﻿using Exercicio.Shared.ValueObjects;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Domain.Valueobjects
{
   
    public class Titular : ValueObject
    {
        public Titular(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
               .Requires()
               .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
               .HasMinLen(LastName, 3, "Name.(LastName", "Nome deve conter pelo menos 3 caracteres")
               .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
               .HasMaxLen(LastName, 40, "Name.LastName", "Nome deve conter até 40 caracteres")

               );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{ FirstName } {LastName}";
        }
    }
}
