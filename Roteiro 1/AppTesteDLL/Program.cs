using DLLdoBetinha;
using MinhaBiblioteca;
using BibliotecaFinanceira;
using BibliotecaValidacoes;

public class Program
{
    public static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();

        Console.WriteLine("Teste Conversão de Temperatura Celsius para Fahrenheit:");
        Console.WriteLine(calculadora.converterCelsiusParaFahrenheit(25));

        Console.WriteLine("Teste Conversão de Metros para KM:");
        Console.WriteLine(calculadora.converterMetrosParaKilometros(25));

        Console.WriteLine("Teste Conversão de Reias para Dolares:");
        Console.WriteLine(calculadora.converterReaisParaDolares(25, 5.5));

        Console.WriteLine("Teste DLL do betinha:");
        BetaCalculator betaCalculator = new BetaCalculator();
        betaCalculator.Beta(400);

        Console.WriteLine("Teste DLL biblioteca financeira:");
        CalculadoraJuros calculadoraJuros = new CalculadoraJuros();
        calculadoraJuros.CalcularJurosSimples(1000, 5, 2);
        // calculadoraJuros.CalculoInterna(1000, 5, 2); // Este método é interno e não pode ser acessado diretamente por estar em outra solução.
    
        Console.WriteLine("Teste DLL biblioteca de validações:");
        Validacoes validacoes = new Validacoes();

        Console.WriteLine("Teste Validação de Email:");
        Console.WriteLine(validacoes.ValidarEmail("teste@gmail.com"));
        Console.WriteLine("Teste Validação de CPF:");
        Console.WriteLine(validacoes.ValidarCPF("123.456.789-09")); 
        Console.WriteLine("Teste Validação de Senha:");
        Console.WriteLine(validacoes.ValidarSenha("Senha@123")); // Aqui acontece o breaking change, pois o método ValidarSenha foi modificado para ser ValidacaoSenha, e agora retorna um objeto do tipo ValidacaoResultado, que contém informações sobre a validade da senha e mensagens de erro detalhadas. Portanto, o código acima não compilará mais, pois o método ValidarSenha não existe mais com a mesma assinatura. Para corrigir isso, seria necessário atualizar o código para usar o novo método ValidacaoSenha e lidar com o objeto de resultado adequadamente.

        // Breaking change é qualquer alteração em um sistema, API ou código que quebra a compatibilidade com versões anteriores
    }
}