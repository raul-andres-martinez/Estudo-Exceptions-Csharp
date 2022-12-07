using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Job { get; set; }

        public Customer(string name, string cpf, string job)
        {
            this.Name = name;
            this.Cpf = cpf;
            this.Job = job;
        }

        public override string ToString()
        {
            return $"Nome: {this.Name}" +
                   $"\nCPF: {this.Cpf}" +
                   $"\nProfissão: {this.Job}";
        }
    }
}
