using _240401_01.Models;

Customer c1 = new Customer();
c1.Name = "Jaguara";
c1.EmailAddress = "jaguara@pixote.net";

// Construtor por Instanciação
Customer c2 = new Customer(2);
c1.Name = "Boca-Mole";
c1.EmailAddress = "bocamole@pixote.net";

// Construtor por Atribuição 
Customer c3 = new Customer{
    CustomerId = 3,
    Name = "Nerso",
    EmailAddress = "nerso@pixote.net"
};