using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibliotecaValidacoes
{
    public class Validacoes
    {
        public bool ValidarCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            // Remove caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // CPF precisa ter 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Elimina CPFs inválidos conhecidos (ex: 11111111111)
            if (cpf.Distinct().Count() == 1)
                return false;

            // Validação do primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * (10 - i);

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            if (cpf[9] - '0' != digito1)
                return false;

            // Validação do segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * (11 - i);

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            return cpf[10] - '0' == digito2;
        }

        public bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Regex simples e eficiente para email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        public bool ValidacaoSenhas(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
                return false;

            // Regras:
            // - Mínimo 8 caracteres
            // - Pelo menos 1 letra maiúscula
            // - Pelo menos 1 letra minúscula
            // - Pelo menos 1 número
            // - Pelo menos 1 caractere especial

            if (senha.Length < 8)
                return false;

            bool temMaiuscula = senha.Any(char.IsUpper);
            bool temMinuscula = senha.Any(char.IsLower);
            bool temNumero = senha.Any(char.IsDigit);
            bool temEspecial = senha.Any(ch => !char.IsLetterOrDigit(ch));

            return temMaiuscula && temMinuscula && temNumero && temEspecial;
        }
    }
}
