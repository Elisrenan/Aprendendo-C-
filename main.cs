using System;

class Program
{
    public static void Main(string[] args)
    {

        int somar(int numero1, int numero2) { return numero1 + numero2; }
        int subtrair(int numero1, int numero2) { return numero1 - numero2; }
        int multiplicar(int numero1, int numero2){return numero1 * numero2;}
        Double dividir(int numero1, int numero2) {return numero1 / numero2;}
        Console.WriteLine("Digite 1 para somar\n 2 para subtrair\n 3 para multiplicar\n 4 para dividir");
        int opcao = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o número que você deseje realizar a tabuada solicitada");
        int numero = Convert.ToInt32(Console.ReadLine());
        //somar
        if (opcao == 1)
        {
            for (int i = 1; i <= 10; i += 1)
            {
              int resultado = somar(numero, i);
              Console.WriteLine(numero + " + "+ i +" = " + resultado);
            }
        }
      //subtrair
        if (opcao == 2)
        {
            for (int i = 1; i <= 10; i += 1)
            {
              int resultado = subtrair(numero, i);
              Console.WriteLine(numero + " + "+ i +" = " + resultado);
            }
        }

      //multiplicar
        if (opcao == 3)
        {
            for (int i = 1; i <= 10; i += 1)
            {
              int resultado = multiplicar(numero, i);
              Console.WriteLine(numero + " + "+ i +" = " + resultado);
            }
        }

      //dividir
        if (opcao == 4)
        {
            for (int i = 1; i <= 10; i += 1)
            {
              Double resultado = dividir(numero, i);
              Console.WriteLine(numero + " + "+ i +" = " + resultado);
            }
        }
    }
}