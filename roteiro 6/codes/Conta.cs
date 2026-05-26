using BancoExceptions.Exceptions;

namespace BancoExceptions;

public class Conta
{
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    private decimal _saqueDiarioAcumulado;

    private const decimal LIMITE_SAQUE_DIARIO = 1000;

    public Conta(string titular, decimal saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("O valor do depósito deve ser positivo.");

        if (valor > 10000)
            throw new ArgumentException(
                "Não é permitido depositar valores maiores que 10.000.");

        Saldo += valor;

        Console.WriteLine($"Depósito realizado: {valor}");
    }

    public void Sacar(decimal valor)
    {
        try
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser positivo.");

            if (valor > 500)
                throw new LimiteDiarioException(
                    "O saque máximo por operação é de 500.");

            if (_saqueDiarioAcumulado + valor > LIMITE_SAQUE_DIARIO)
                throw new LimiteSaqueDiarioException(
                    "Limite diário de saque excedido.");

            if (valor > Saldo)
                throw new SaldoInsuficienteException(
                    "Saldo insuficiente para realizar o saque.");

            Saldo -= valor;
            _saqueDiarioAcumulado += valor;

            Console.WriteLine($"Saque realizado: {valor}");
        }
        catch (Exception ex)
        {
            throw new Exception(
                "Erro ao processar saque.", ex);
        }
    }

    public void Transferir(Conta destino, decimal valor)
    {
        if (destino == null)
            throw new ArgumentNullException(nameof(destino));

        if (valor <= 0)
            throw new ArgumentException(
                "O valor da transferência deve ser positivo.");

        try
        {
            Sacar(valor);
            destino.Depositar(valor);

            Console.WriteLine(
                $"Transferência de {valor} realizada para {destino.Titular}");
        }
        catch
        {
            throw;
        }
    }
}