using System;
using System.Collections.Generic;

namespace Dio.avaCloud.Entidades
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }

        public Int64 Document { get; set; }

        public List<Address> Address { get; set; }

        public DateTime BirthDate { get; set; }

        public string FullName 
        { 
            get
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    fullName += $" {LastName}";
                }
                return fullName;
            }
        }

        public override string ToString() => $"Nome completo: {FullName} E-mail: {Email} Data de Nascimento: {BirthDate}";
     

    }
}
