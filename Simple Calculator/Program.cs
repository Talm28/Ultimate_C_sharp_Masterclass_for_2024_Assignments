Console.WriteLine("Hello!");

// Read first number
Console.WriteLine("Input the first number:");
int number1 = int.Parse(Console.ReadLine());

// Read second number
Console.WriteLine("Input the second number:");
int number2 = int.Parse(Console.ReadLine());

// Read user operator
Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string userInput = Console.ReadLine();

// Print result
if(InputCheck(userInput, "A")){ // Addition
    PrintResults(number1, number2, (number1 + number2), "+");
}
else if(InputCheck(userInput, "S")){ // Subtraction
    PrintResults(number1, number2, (number1 - number2), "-");;
}
else if(InputCheck(userInput, "M")){ // Multiplication
    PrintResults(number1, number2, (number1 * number2), "*");
}
else{ // Invalid input
    Console.WriteLine("Invalid option");
}
Console.WriteLine("Press any key to close");
Console.ReadLine();

void PrintResults(int number1, int number2, int result, string @operator)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}

bool InputCheck(string input, string @operator)
{
    return input.ToUpper() == @operator.ToUpper();
}
