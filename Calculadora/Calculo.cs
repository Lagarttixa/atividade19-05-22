using System;

namespace Calculo
{
    public class Calculo
    {
        public Calculo()
        {
        }

        public int soma(int primeiroValor, int segundoValor)
        {
            return primeiroValor + segundoValor;
        }

        public int subtrai(int primeiroValor, int segundoValor)
        {
            return primeiroValor - segundoValor;
        }
        public int multiplica(int primeiroValor, int segundoValor)
        {
            return primeiroValor * segundoValor;
        }

        public int dividi(int primeiroValor, int segundoValor)
        {
            return primeiroValor / segundoValor;
        }
    }
}