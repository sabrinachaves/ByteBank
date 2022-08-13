using System;
using bytebank;


Console.WriteLine("Boas vindas ao seu banco, Byte Bank!\n");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Sabrina Chaves";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número da agência: " + conta1.numero_agencia);
Console.WriteLine("Nome da agência: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.WriteLine("\nTecle enter para sair...");
Console.ReadLine();
