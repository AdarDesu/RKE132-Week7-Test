// F to °C and the other way around
// User can choose which way to calculate
// Program asks for data, calculates and shows the result.

// Fahrenheit = (celsius * 9) / 5 + 32
// Celsius = (fahrenheit - 32) * 5/9

// Program must include: static void ConverToCelsius(argument){} && static void ConvertToFahrenheit(argument){}


//Asking user for their choice
Console.WriteLine("Which one do you want to find by calculation? Enter F for (°C to F) and C for (F to °C)");
char Choice = Char.Parse(Console.ReadLine());


// Cheking if the entered character is valid, if it is not valid, then the program will stop. 
switch (Choice)
{
    case 'F':
        break;
    case 'f':
        break;
    case 'C':
        break;
    case 'c':
        break;
    default:
        Console.WriteLine("You entered a wrong symbol.");
        return;
}


// Asking user to enter a number to be converted
Console.WriteLine("Enter a value:");
int Value = Int32.Parse(Console.ReadLine());


// Choosing the action
switch (Choice)
{
    case 'F':
        ConvertToFahrenheit(Value);
        break;
    case 'f':
        ConvertToFahrenheit(Value);
        break;
    case 'C':
        ConverToCelsius(Value);
        break;
    case 'c':
        ConverToCelsius(Value);
        break;
    default:
        Console.WriteLine("Something went wrong.");
        break;
}


// Functions
static void ConverToCelsius(int Fahrenheit)
{
    Console.WriteLine($"{Fahrenheit}F is {(Fahrenheit - 32) * 5 / 9}°C.");
}

static void ConvertToFahrenheit(int Celsius)
{
    Console.WriteLine($"{Celsius}°C is {(Celsius * 9) / 5 + 32}F.");
}