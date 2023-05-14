// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World!!!");
Console.WriteLine("Press Enter!!!");
Console.ReadLine();

Double num1 = 0;
Double num2 = 0;

Console.WriteLine("Please Enter Number_1 : ");
num1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please Enter Number_2 : ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\tAdd");
Console.WriteLine("\tSubtract");
Console.WriteLine("\tMultiply");
Console.WriteLine("\tDivide");
//Console.WriteLine("\tModule");

Console.Write("Your option? ");

switch (Console.ReadLine())
{
    case "Add":
        Console.WriteLine("Your Result " + num1 + " + " + num2 + " = " + (num1+num2)); break;
    case "Subtract":
        Console.WriteLine("Your Result " + num1 + " - " + num2 + " = " + (num1 - num2));break;
    case "Multiply":
        Console.WriteLine("Your Result " + num1 + " * " + num2 + " = " + (num1 * num2)); break;
    case "Divide":
        Console.WriteLine("Your Result " + num1 + " / " + num2 +" = " + (num1 / num2)); break;
    default: Console.WriteLine("Error!!!");break;
}