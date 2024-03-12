Console.WriteLine("Qual operador você deseja para criar a tabuada? Digite: +, -, * ou /");
string operador = Console.ReadLine();

switch (operador)
{
    case "+":
        for (int i = 1; i<= 9; i++)
        {
            Console.WriteLine($"------------");
            for (int j = 1; j<= 9; j++)
            {
                Console.WriteLine($"{i} + {j} = {i+j}");
            }
        }
        break;

    case "-":
        for (int i = 1; i<= 9; i++)
        {
            Console.WriteLine($"------------");
            for (int j = 1; j<= 9; j++)
            {
                Console.WriteLine($"{i} - {j} = {i-j}");
            }
        }
        break;

    case "*":
        for (int i = 1; i<= 9; i++)
        {
            Console.WriteLine($"------------");
            for (int j = 1; j<= 9; j++)
            {
                Console.WriteLine($"{i} x {j} = {i*j}");
            }
        }
        break;
    
    case "/":
        for (float i = 1; i<= 9; i++)
        {
            Console.WriteLine($"-----------");
            for (float j = 1; j<= 9; j++)
            {
                Console.WriteLine($"{i} : {j} = {(i/j):F2}");
            }
        }
        break;

    default:
        Console.WriteLine("Operação inválida");
        break;
}