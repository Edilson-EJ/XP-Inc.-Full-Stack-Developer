using System;

public class Program
{


    public static void Main(string[] args)
    {
        // Solicita ao usuário para inserir os valores
        Console.WriteLine("Digite o valor principal (P):");
        double P = Convert.ToDouble(Console.ReadLine()); // Lê o valor principal P
        
        Console.WriteLine("Digite a taxa de juros (i) em porcentagem:");    
        double i = Convert.ToDouble(Console.ReadLine()); // Lê a taxa de juros i
        
        Console.WriteLine("Digite o número de períodos (n):");  
        int n = Convert.ToInt32(Console.ReadLine()); // Lê o número de períodos n

        // Calcula o montante final utilizando a função CalcularJurosSimples
        double montanteFinal = CalcularJurosSimples(P, i, n);

        // Exibe o resultado
        Console.WriteLine($"montante final com juros simples: {montanteFinal}"); // Mostra o montante final calculado
    }

    public static double CalcularJurosSimples(double P, double i, int n)
    {
        // TODO: Calcule e retorne o montante final com juros simples
        double montante = P + (P * i *n);
        return montante;
    }
}