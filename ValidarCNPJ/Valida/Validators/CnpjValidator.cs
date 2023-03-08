using System.Text.RegularExpressions;

namespace ValidarCNPJ.Valida.Validators;

public class CnpjValidator
{
    private static readonly int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
    private static readonly int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

    public static bool IsValid(string cnpj)
    {
        // Remove caracteres não numéricos usando expressão regular
        cnpj = Regex.Replace(cnpj, @"[^0-9]", "");

        // Verifica se possui 14 dígitos
        if (cnpj.Length != 14)
            return false;

        // Verifica se todos os dígitos são iguais
        if (new string(cnpj[0], cnpj.Length) == cnpj)
            return false;

        // Calcula os dígitos verificadores
        int primeiroDigito = CalcularDigitoVerificador(cnpj, peso1);
        int segundoDigito = CalcularDigitoVerificador(cnpj, peso2);

        // Verifica se os dígitos verificadores estão corretos
        return cnpj.EndsWith(primeiroDigito.ToString() + segundoDigito.ToString());
    }

    private static int CalcularDigitoVerificador(string cnpj, int[] peso)
    {
        int soma = 0;

        for (int i = 0; i < peso.Length; i++)
        {
            int digito = int.Parse(cnpj[i].ToString());
            soma += digito * peso[i];
        }

        int resto = soma % 11;
        return resto < 2 ? 0 : 11 - resto;
    }
}
