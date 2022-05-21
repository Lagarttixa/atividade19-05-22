using System;
namespace List_DS
{
    public class Pessoa
    {
        public string PrimeiroNome { get; set;}
        public string Cpf { get; set;}
        public string Rg { get; set;}

        public Pessoa()
        {
            this.PrimeiroNome = string.Empty;
            this.Cpf = string.Empty;
            this.Rg = string.Empty;
        }
        public Pessoa(string primeiroNome, string cpf, string rg)
        {
            this.PrimeiroNome = primeiroNome;
            this.Cpf = cpf;
            this.Rg = rg;
        }
  
    }
}