using System;
using System.Collections.Generic;
using System.Text;

namespace List_DS
{
    class Program
    {
    static void Main(string[] args)
    {   
        List<Pessoa> pessoas = new List<Pessoa>();

        pessoas.Add(new Pessoa("jhow", "528.332.115-52", "45.423.356-8"));
        pessoas.Add(new Pessoa("samara", "333.444.555-66", "22.333.444-9"));
        pessoas.Add(new Pessoa("Doctor Strange", "424.552.224-72", "33.411.325-3"));
        pessoas.Add(new Pessoa("Neymar", "534.355.235-64", "25.553.256-5"));
        pessoas.Add(new Pessoa("Hiago", "332.424.521-32", "25.326.224-2"));
        pessoas.Add(new Pessoa("AVATAR", "324.452.524-42", "43.611.625-6"));

        Pessoa outraPessoa = new Pessoa();
        outraPessoa.PrimeiroNome = "Jhowzinho";
        outraPessoa.Cpf = "Alfredo";

        pessoas.Add(outraPessoa);

        outraPessoa = new Pessoa();
        outraPessoa.PrimeiroNome = "Jhow";
        outraPessoa.Cpf = "Carvalho";

        pessoas.Add(outraPessoa);

        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"Nome Completo: {pessoa.PrimeiroNome} CPF: {pessoa.Cpf} RG: {pessoa.Rg}");
        }
        }
    }
}