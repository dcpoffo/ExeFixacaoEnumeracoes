using System;

namespace ExeFixacao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string nome, string email, DateTime birthDate)
        {
            Name = nome;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return
                Name
                + " ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
