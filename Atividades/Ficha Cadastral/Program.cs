using System;

string nome = System.String.Empty;
string email = System.String.Empty;
string nasc = System.String.Empty;
string genero = System.String.Empty;
string cep = System.String.Empty;
string rua = System.String.Empty;
string numero = System.String.Empty;
string bairro = System.String.Empty;
string cidade = System.String.Empty;
string uf = System.String.Empty;
string paiis = System.String.Empty;

Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine("\nDigite seu E-mail:");
email = Console.ReadLine();

Console.WriteLine("\nDigite sua data de nascimento:");
nasc = Console.ReadLine();

Console.WriteLine("\nDigite seu sexo/gênero:");
genero = Console.ReadLine();

Console.WriteLine("\nAgora seu endereço. Digite seu CEP:");
cep = Console.ReadLine();

Console.WriteLine("\nDigite seu rua:");
rua = Console.ReadLine();

Console.WriteLine("\nDigite o numero:");
numero = Console.ReadLine();

Console.WriteLine("\nDigite seu bairro:");
bairro = Console.ReadLine();

Console.WriteLine("\nDigite seu cidade:");
cidade = Console.ReadLine();

Console.WriteLine("\nDigite seu UF:");
uf = Console.ReadLine();

Console.WriteLine("\nPara finalizar, digite seu país:");
paiis = Console.ReadLine();

Console.WriteLine(@$"
Suas informações:
Nome: {nome}
Data de Nascimento: {nasc}
Sexo/Gênero: {genero}
E-mail: {email}
Endereço: {rua}, N°{numero}, Bairro {bairro}, {cidade}-{uf}, {cep}, {paiis}.
");