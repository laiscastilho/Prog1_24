﻿using System;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

//Trabalhando com variáveis C#endregion

//Strings 
//Declarando variável sem inicialização
string? message1 = null;

//Inicializar a variável com nulo
string? message2 = null;

//Inicializar a string vazia
string message3 = System.String.Empty; // "";

//Declarar uma string com valor implícito 
var message4 = "Uma mensagem";

Console.WriteLine(message4);

//Concatenando Strings
string concat = (message1 == null ? "" : message1) + " " + message2 + " " + message3 + " " + message4; //if ternário
Console.WriteLine("\n" + concat);

Console.WriteLine("A temperatura hoje {0:D} é {1} °C", DateTime.Now, 23);

string nome = string.Empty;
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de jaquarice!";
Console.WriteLine(resultado);

// Subtituindo conteúdo de strings
string nomeCompleto ="Layne Laís de Castilho Firmino";
nomeCompleto =
    nomeCompleto.Replace("Layne", "Laisa");
Console.WriteLine(nomeCompleto);

//Comparação de strings
bool isNomeEqual =
(nomeCompleto == "Layne Laís de Castilho Firmino");

bool isNomeEqual2 = 
    string.Equals(nomeCompleto, "Laisa Laís de Catilho Firmino");

Console.WriteLine($"Primeiro: {isNomeEqual}");
Console.WriteLine($"Segundo: {isNomeEqual2}");
