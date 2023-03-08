using System.Text.RegularExpressions;

namespace ValidarCNPJ.Valida.Validators;


public class CpfValidator
{
    private static readonly int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
    private static readonly int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

    public static bool IsValid(string cpf)
    {
        // Remove caracteres não numéricos usando expressão regular
        cpf = Regex.Replace(cpf, @"[^\d]", "");

        // Verifica se possui 11 dígitos
        if (cpf.Length != 11)
        {
            return false;
        }

        // Verifica se todos os dígitos são iguais
        if (new string(cpf[0], cpf.Length) == cpf)
        {
            return false;
        }

        // Calcula os dígitos verificadores
        int primeiroDigito = CalcularDigitoVerificador(cpf, peso1);
        int segundoDigito = CalcularDigitoVerificador(cpf, peso2);

        // Verifica se os dígitos verificadores estão corretos
        return cpf.EndsWith(primeiroDigito.ToString() + segundoDigito.ToString());
    }

    private static int CalcularDigitoVerificador(string cpf, int[] peso)
    {
        int soma = 0;

        for (int i = 0; i < peso.Length; i++)
        {
            soma += (cpf[i] - '0') * peso[i];
        }

        int resto = soma % 11;
        int digito = resto < 2 ? 0 : 11 - resto;

        return digito;
    }
}

