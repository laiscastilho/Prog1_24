Console.WriteLine("Digite o primeiro número:");
float.TryParse(Console.ReadLine(), out float primeiroNum);

Console.WriteLine("Digite o segundo número:");
float.TryParse(Console.ReadLine(), out float segundoNum);

Console.WriteLine("Digite a operação desejada: (*, /, -, +)");
string opDesejada = Console.ReadLine();

switch (opDesejada)
{
    case "+":
        Console.WriteLine($"A adição de {primeiroNum} com {segundoNum} é {primeiroNum + segundoNum}");
        break;
    case "-":
        Console.WriteLine($"A subtração de {primeiroNum} com {segundoNum} é {primeiroNum - segundoNum}");
        break;
    case "*":
        Console.WriteLine($"A multiplicação de {primeiroNum} com {segundoNum} é {primeiroNum * segundoNum}");
        break;
    case "/":
        Console.WriteLine($"A divisão de {primeiroNum} com {segundoNum} é {primeiroNum / segundoNum}");
        break;
    default:
        Console.WriteLine("Operação inválida");
        break;
}