using System;
namespace Calculadora
{   
    public class Calcular
    {   

        private int operacoesDigitada;
        private int resultadoCalculo;
        private int primeiroValor;
        public int segundoValor;

        public Calcular()
        {      
            this.primeiroValor = 0;
            this.segundoValor = 0;
        }

        public void executar()
        {
            this.menu();
        }

        private string somar()
        {
            this.resultadoCalculo = this.primeiroValor + this.segundoValor;
            return this.resultado();
        }
            private string subtrair()
        {
            this.resultadoCalculo = this.primeiroValor - this.segundoValor;
            return this.resultado();
        }
            private string multiplicar()
        {
            this.resultadoCalculo = this.primeiroValor * this.segundoValor;
            return this.resultado();
        }
        private string dividir()
        {
            this.resultadoCalculo = this.primeiroValor / this.segundoValor;
            return this.resultado();
        }
        private string resultado(){
            return$"Resultado: {this.resultadoCalculo}";
        }

            private void continuar()
            {
                Console.WriteLine("Digite qualquer tecla para continuar");
                Console.ReadKey();
            }
        private void alerta()
        {
            Console.Clear();
            Console.WriteLine("Escolha errada das opções");
            this.continuar();
        }
        private void menu()
        {
             int opcao = 10;
            while (opcao != 0)
        {   
            Console.Clear();
            Console.WriteLine("Escolha a opção");
            Console.WriteLine("1 - SOMAR");
            Console.WriteLine("2 - SUBTRAIR");
            Console.WriteLine("3 - MULTIPLICAR");
            Console.WriteLine("4  - DIVIDIR");
            Console.WriteLine("0 -  SAIR");
            
            Console.WriteLine("===============");
            Console.WriteLine("Digite a opção: ");
            try
            {    
            opcao = Convert.ToInt16(Console.ReadLine());
            
            if(opcao > 0 && opcao < 5)
            {
                this.operacoesDigitada = opcao;
                this.primeiro();
                this.segundo();
                this.operacoes();
            }
            else if (opcao < 0 || opcao > 4)
            this.alerta();
        
        } catch(Exception)
        {
            this.alerta();
        }

    }   
        Console.Clear();
        Console.WriteLine("=== Fim da Calculadora ===");
}

private void primeiro()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    try{
        this.primeiroValor = Convert.ToInt16(Console.ReadLine());
    }
    catch (Exception)
    {
        this.primeiroValor = 0;
    }
}
    private void segundo()
    {
        Console.Clear();
        Console.WriteLine("Digite o segundo valor: ");
        try
        {
            this.segundoValor =  Convert.ToInt16(Console.ReadLine());
        }
        catch (Exception)
        {
            this.segundoValor = 0;
        }
    }
private void operacoes()
{
    switch (this.operacoesDigitada)
    {   
        case 1: 
        Console.Clear();
        Console.WriteLine("## Soma ##");
        Console.WriteLine($"Calculo: { this.primeiroValor} + {this.segundoValor}");
        Console.WriteLine(somar());
       break;
        case 2: 
        Console.Clear();
        Console.WriteLine("## Subtrair ##");
        Console.WriteLine($"Calculo: { this.primeiroValor} - {this.segundoValor}");
        Console.WriteLine(subtrair());
       break;   
        case 3: 
        Console.Clear();
        Console.WriteLine("## Multiplicar ##");
        Console.WriteLine($"Calculo: { this.primeiroValor} * {this.segundoValor}");
        Console.WriteLine(multiplicar());
       break;
        case 4: 
        Console.Clear();
        Console.WriteLine("## Dividir ##");
        Console.WriteLine($"Calculo: { this.primeiroValor} / {this.segundoValor}");
        Console.WriteLine(dividir());
       break;

            }
            this.continuar();
        }
    }
}

        // public string tittle;
        // public double valor1 = 0;
        // public double valor2 =0;
        // public double resultado;
        // public double numero;
        // public string operador;
        // public string valorDigitado;
        // bool isNumeroInteiro;

        // public int i = 0;
        

        // public void tela(){
        
    //     do{
    //        i++;
     



    //         Console.WriteLine("============== CALCULADORA =============");
            
    //         Console.WriteLine(" 1 - SOMA ");
    //         Console.WriteLine(" 2 - SUBTRAIR ");
    //         Console.WriteLine(" 3 - MULTIPLICAR ");
    //         Console.WriteLine(" 4 - DIVIDIR ");
    //         Console.WriteLine(" 0 -  SAIR");

    //         operador = Console.ReadLine();
            
    //         Console.WriteLine("Digite o primeiro valor: ");
    //         valorDigitado = Console.ReadLine();

    //         isNumeroInteiro = double.TryParse(valorDigitado, out numero);

    //           if (isNumeroInteiro)
    //         {
    //             valor1 = Math.Round(double.Parse(valorDigitado), 4);
    //         }
    //         else
    //         {
    //             Console.WriteLine("Digite um número válido");
    //         }

    //         Console.WriteLine("Digite o 2 valor: ");
    //         valorDigitado = Console.ReadLine();

    //         isNumeroInteiro = double.TryParse(valorDigitado, out numero);
    //         if (isNumeroInteiro)
    //         {
    //             valor2 = Math.Round(double.Parse(valorDigitado), 4);
    //         }
    //         else
    //         {
    //             Console.WriteLine("Digite um número válido");
    //         }



    //         switch (operador)
    //         {
    //             case "1":
    //                 resultado = Math.Round(valor1 + valor2, 4);
    //                 Console.WriteLine($"{ valor1 } {'+'} { valor2 } = {resultado}");
    //                 break;
    //             case "2":
    //                 resultado = Math.Round(valor1 - valor2, 4);
    //                 Console.WriteLine($"{ valor1 } {'-'} { valor2 } = {resultado}");
    //                 break;
    //             case "3":
    //                 resultado = Math.Round(valor1 * valor2, 4);
    //                 Console.WriteLine($"{ valor1 } {'*'} { valor2 } = {resultado}");
    //                 break;
    //             case "4":
    //                 resultado = Math.Round(valor1 / valor2, 4);
    //                 Console.WriteLine($"{ valor1 } {'/'} { valor2 } = {resultado}");
    //                 Console.WriteLine("Digite qualquer tecla para continuar");
    //                 break;
    //             default :
    //                 Console.WriteLine("Digite uma operação válida");
    //                 break;
                                        
    //         }

    //         Console.ReadKey();
 
    //                }while(numero != 0);   
                    
        
    //     }
    // }   
//  }
    