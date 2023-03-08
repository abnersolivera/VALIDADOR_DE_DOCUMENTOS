# Validador de Documentos (CPF/CNPJ)

Este é um programa em C# que permite a validação de CPFs e CNPJs informados pelo usuário.

O programa utiliza uma classe DocumentoValidator, que contém dois métodos estáticos: ValidaDocumento, que recebe como parâmetro o documento a ser validado e a função de validação correspondente (CpfValidator.IsValid ou CnpjValidator.IsValid), e retorna uma mensagem indicando se o documento é válido ou inválido; e ValidaDigitos, que recebe como parâmetro o número do documento e a quantidade de dígitos a serem validados, e retorna o dígito verificador correspondente.

As validações de CPF e CNPJ são realizadas pelas classes CpfValidator e CnpjValidator, respectivamente, que implementam as regras de validação de cada tipo de documento.

O programa permite ao usuário informar o tipo de documento a ser validado (CPF ou CNPJ) e o número do documento. O programa então utiliza a classe DocumentoValidator para realizar a validação e exibe uma mensagem indicando se o documento é válido ou inválido.

O programa é executado em um loop, permitindo ao usuário realizar várias validações consecutivas. O programa pode ser encerrado a qualquer momento, digitando-se "sair" como entrada.

Esse programa é útil para quem precisa validar documentos de pessoas físicas e jurídicas em aplicações em C#.
