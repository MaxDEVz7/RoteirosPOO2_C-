using BancoExceptions.Exceptions;
using static System.Net.Mime.MediaTypeNames;

namespace BancoExceptions;

class Program
{
    static void Main(string[] args)
    {
        Conta conta1 = new Conta("Max", 1000);
        Conta conta2 = new Conta("João", 500);

        try
        {
            Console.WriteLine("=== DEPÓSITO ===");
            conta1.Depositar(15000);
        }
        catch (Exception ex)
        {
            ExibirDetalhesErro(ex);
        }

        try
        {
            Console.WriteLine("\n=== SAQUE ===");
            conta1.Sacar(600);
        }
        catch (Exception ex)
        {
            ExibirDetalhesErro(ex);
        }

        try
        {
            Console.WriteLine("\n=== TRANSFERÊNCIA ===");
            conta1.Transferir(conta2, 300);

            Console.WriteLine($"Saldo Conta 1: {conta1.Saldo}");
            Console.WriteLine($"Saldo Conta 2: {conta2.Saldo}");
        }
        catch (Exception ex)
        {
            ExibirDetalhesErro(ex);
        }

        Console.WriteLine("\n=== ENTRADA DO USUÁRIO ===");

        try
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Número digitado: {numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Digite apenas números inteiros.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Número muito grande ou muito pequeno.");
        }
    }

    static void ExibirDetalhesErro(Exception ex)
    {
        Console.WriteLine("\n===== ERRO =====");

        Console.WriteLine($"Mensagem: {ex.Message}");

        Console.WriteLine("\n--- StackTrace ---");
        Console.WriteLine(ex.StackTrace);

        Console.WriteLine("\n--- InnerException ---");

        if (ex.InnerException != null)
            Console.WriteLine(ex.InnerException.Message);
        else
            Console.WriteLine("Nenhuma InnerException encontrada.");
    }
}