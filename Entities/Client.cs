using System;
using System.Collections.Generic;
using System.Text;

namespace TreiningForCompositionAndEnums.Entities
{
    class Client
    {
        public string NameClient { get; set; }
        public string MailClient { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string nameClient, string mailClient, DateTime birthDate)
        {
            NameClient = nameClient;
            MailClient = mailClient;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return NameClient
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + MailClient;
        }
    }
}
