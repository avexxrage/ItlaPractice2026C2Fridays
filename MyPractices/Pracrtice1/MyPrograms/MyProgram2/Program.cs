decimal numberInput;
decimal total = 0;
int operationInput;
int quantityNumbers;

Console.WriteLine("Welcome to my calculator Program!");

Console.WriteLine("How many numbers do you want to use?");
//var quantityNumbers = int.Parse(Console.ReadLine());
int.TryParse(Console.ReadLine(), out quantityNumbers);

Console.WriteLine("Please enter the operation you want to perform:");
Console.WriteLine("1. Add, 2. Substract, 3. Multiplication, 4. Division 5. Exit");

//var operationInput = Console.ReadLine();
int.TryParse(Console.ReadLine(), out operationInput);

//decimal total = firstNumberInput + secondNumberInput;

//logic operators
// == equal to, != not equal to, > greater than, < less than, >= greater than or equal to, <= less than or equal to

if (operationInput == 1)
{
    total = 0;

    for (int i = 1; i <= quantityNumbers; i++)
    {
        Console.WriteLine($"Enter number {i}:");
        decimal.TryParse(Console.ReadLine(), out numberInput);

        total += numberInput;
    }
}

if (operationInput == 2)
{
    Console.WriteLine("Enter number 1:");
    decimal.TryParse(Console.ReadLine(), out total);

    for (int i = 2; i <= quantityNumbers; i++)
    {
        Console.WriteLine($"Enter number {i}:");
        decimal.TryParse(Console.ReadLine(), out numberInput);

        total -= numberInput;
    }
}

if (operationInput == 3)
{
    total = 1;

    for (int i = 1; i <= quantityNumbers; i++)
    {
        Console.WriteLine($"Enter number {i}:");
        decimal.TryParse(Console.ReadLine(), out numberInput);

        total *= numberInput;
    }
}

if (operationInput == 4)
{
    Console.WriteLine("Enter number 1:");
    decimal.TryParse(Console.ReadLine(), out total);

    for (int i = 2; i <= quantityNumbers; i++)
    {
        Console.WriteLine($"Enter number {i}:");
        decimal.TryParse(Console.ReadLine(), out numberInput);

        if (numberInput == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }

        total /= numberInput;
    }
}

if (operationInput == 5)
{
    Console.WriteLine("Exiting calculator...");
    return;
}

Console.WriteLine($"The result of the operation is: {total}");

Console.ReadKey();