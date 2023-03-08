using ValidarCNPJ.Valida.Validators;

namespace ValidarCNPJ.Valida;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite 'CPF' ou 'CNPJ' para validar, ou 'sair' para encerrar:");
            string input = Console.ReadLine().ToUpper();

            if (input == "CPF")
            {
                Console.WriteLine("Digite o CPF a ser validado:");
                string cpf = Console.ReadLine();
                bool isValid = CpfValidator.IsValid(cpf);
                Console.WriteLine($"CPF {cpf} {(isValid ? "válido" : "inválido")}");
            }
            else if (input == "CNPJ")
            {
                Console.WriteLine("Digite o CNPJ a ser validado:");
                string cnpj = Console.ReadLine();
                bool isValid = CnpjValidator.IsValid(cnpj);
                Console.WriteLine($"CNPJ {cnpj} {(isValid ? "válido" : "inválido")}");
            }
            else if (input == "SAIR")
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite 'CPF' ou 'CNPJ', ou 'sair' para encerrar.");
            }
        }
    }
}