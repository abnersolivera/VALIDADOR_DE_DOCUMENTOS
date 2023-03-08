namespace ValidarCNPJ.Valida.Validators;

public class DocumentoValidator
{
    public static string ValidaDocumento(string documento, Func<string, bool> validador)
    {
        if (validador(documento))
        {
            return $"{documento} é válido.";
        }
        else
        {
            return $"{documento} é inválido.";
        }
    }
}
