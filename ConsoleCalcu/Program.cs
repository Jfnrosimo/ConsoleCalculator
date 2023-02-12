Console.WriteLine("Simple Calculator");
Console.WriteLine("Enter the first number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the first number:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What operation would you like to perform? (+, -, *, /):");
string operation = Console.ReadLine();

double result;

switch (operation)
{
    case "+":
        result = num1 + num2;
        Console.WriteLine("The result after addition is: " + result);
        break;

    case "-":
        result = num1 - num2;
        Console.WriteLine("The result after subtraction is: " + result);
        break;

    case "*":
        result = num1 * num2;
        Console.WriteLine("The result after multiplication is: " + result);
        break;

    case "/":
        result = num1 / num2;
        Console.WriteLine("The result after multiplication is: " + result);
        break;
}

