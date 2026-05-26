using NLog;

namespace BancoNLog;

class Program
{
    private static readonly Logger logger =
        LogManager.GetCurrentClassLogger();

    static void Main(string[] args)
    {
        LogManager.LoadConfiguration("nlog.config");

        logger.Info("Programa iniciado.");

        Conta conta1 = new Conta(1000);
        Conta conta2 = new Conta(500);

        // EXERCÍCIO 3
        // Conversão de string para inteiro

        try
        {
            logger.Info("Tentando converter valor.");

            int numero = int.Parse("abc");
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Erro ao converter string para inteiro.");
        }

        // EXERCÍCIO 4 e 5
        // Saque com logs

        try
        {
            logger.Info("Iniciando saque.");

            decimal valorSaque = 1500;

            logger.Debug("Tentativa de saque no valor de {0}", valorSaque);

            if (valorSaque <= 0)
            {
                logger.Warn("Tentativa de saque inválida.");
            }

            conta1.Sacar(valorSaque);

            logger.Info("Saque realizado com sucesso.");
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Erro ao realizar saque.");
        }

        // EXERCÍCIO 6
        // Fluxo completo

        try
        {
            logger.Info("Iniciando depósito.");

            conta1.Depositar(200);

            logger.Info("Depósito realizado com sucesso.");

            logger.Info("Iniciando saque.");

            conta1.Sacar(100);

            logger.Info("Saque realizado com sucesso.");

            logger.Info("Iniciando transferência.");

            logger.Debug("Conta origem saldo: {0}", conta1.Saldo);
            logger.Debug("Conta destino saldo: {0}", conta2.Saldo);

            conta1.Transferir(conta2, 300);

            logger.Info("Transferência concluída com sucesso.");

            logger.Debug("Novo saldo conta origem: {0}", conta1.Saldo);
            logger.Debug("Novo saldo conta destino: {0}", conta2.Saldo);
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Erro durante operações bancárias.");
        }

        logger.Info("Programa finalizado.");

        LogManager.Shutdown();
    }
}