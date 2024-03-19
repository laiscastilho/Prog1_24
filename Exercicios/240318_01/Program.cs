using _240318_01.Models;

//Intância de objeto do tipo Customer 

Customer c1 = new Customer();
// Atribuindo valores aos atributos do objeto c1
c1.CustomerId = 1;
c1.FirstName = "Layne";
c1.LastName = "Castilho";
c1.Birthdate = new DateTime();
c1.EmailAddress = "laynefirmino123@gmail.com";

// Instância de objeto do tipo Address
Address address1 = new Address();
// Atribuindo valor aos atributos de objeto address1
address1.AddressId = 1;
address1.Street = "Nome da Rua";
address1.District = "Distrito";
address1.City = "Cidade";
address1.Number = 123;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89500-300";
//AddressType é do tipo Enum - Portanto espera receber 
// Valor equivalente ao seu tipo
address1.AddressType = AddressType.Commercial;

// Guardando um endereço à lista de endereço do consumidor
c1.Addresses.Add(address1);

Console.WriteLine("ENDEREÇOS:");

foreach(var ad in c1.Addresses)
{
    Console.WriteLine("---------------------");
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Número: {ad.Number}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"País: {ad.Country}");
}

Console.WriteLine($"Nome: {c1.FirstName} {c1.LastName}");
Console.WriteLine($"Email: {c1.EmailAddress}");