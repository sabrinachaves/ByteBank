using System;
using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas vindas ao seu banco, Byte Bank!\n");

Cliente sabrina = new Cliente("Sabrina Chaves", "12345678911", "Analista de Negócios");

ContaCorrente conta1 = new ContaCorrente(sabrina, "10123-X", 23, "Agência Central");

conta1.Saldo = 100;

Cliente luis = new Cliente("Luis Dias", "00123456789", "Analista de manutenção");

ContaCorrente conta2 = new ContaCorrente(luis, "10456-X", 45, "Agencia Central");

conta2.Saldo = 200;

//Comentar com crtl + k + c
//Descomentar com ctrl + k + u

//Se os valores de conta1 e conta2 fossem iguais, e fosse feito uma comparação conta1 == conta2, o resultado seria false, pois as contas possuem endereços de memórias diferentes
//Para que o valor seja true, é preciso fazer conta1 = conta2, assim elas apontariam para o mesmo endereço

conta1.StatusConta();

conta2.StatusConta();

Console.WriteLine($"\nTotal de contas criadas: {ContaCorrente.TotalDeContasCriadas}");

Console.WriteLine("\nTecle enter para sair...");
Console.ReadLine();
