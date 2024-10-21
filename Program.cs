public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        CheckForPositiveNegativeZero(0); 
        FindMinimum(3, 2, 1);
        FindMaximum(3, 2, 1);
        IsDivisibleBy5(6);
        CheckEvenOrOdd(3);
        CheckVowelOrConsonant('S');
        DisplayDayOfWeek(6); 
    }
    public static void CheckForPositiveNegativeZero(int num)
    {
        if (num < 0) {Console.WriteLine("Your number is negative");}

        else if (num > 0) {Console.WriteLine("Your number is positive");}

        else {Console.WriteLine("Your number is zero");}
    }
    public static void FindMinimum(int num1, int num2, int num3)
    {
        if (num1 < num2 && num1 < num3) {Console.WriteLine($"The minimum value is {num1}.");}
        else if (num2 < num1 && num2 < num3) {Console.WriteLine($"The minimum value is {num2}.");}
        else if (num3 < num1 && num3 < num2) {Console.WriteLine($"The minimum value is {num3}.");}
        else if (num1 == num2 || num1 == num3 || num2 == num3) {Console.WriteLine("The minimum number was repeated!");}
        else Console.WriteLine("There was a error");
    }
    public static void FindMaximum(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3) {Console.WriteLine($"The maximum value is {num1}.");}
        else if (num2 > num1 && num2 > num3) {Console.WriteLine($"The maximum value is {num2}.");}
        else if (num3 > num1 && num3 > num2) {Console.WriteLine($"The maximum value is {num3}.");}
        else if (num1 == num2 || num1 == num3 || num2 == num3) {Console.WriteLine("The maximum number was repeated!");}
        else Console.WriteLine("There was a error");
    }
    public static void IsDivisibleBy5(int number)
    {
        if ((number % 5) == 0) {Console.WriteLine($"{number} is divisible by 5.");}
        else {Console.WriteLine($"{number} is not divisible by 5.");}
    }
    public static void CheckEvenOrOdd(int number)
    {
        if ((number % 2) == 0) {Console.WriteLine($"{number} is even.");}
        else {Console.WriteLine($"{number} is odd.");}
    }
    public static void CheckVowelOrConsonant(char letter)
    {
        if (letter == 'a' || letter == 'A' || letter == 'e' || letter == 'E' || letter == 'i' || letter == 'I' || letter == 'o' || letter == 'O' || letter == 'u' || letter == 'U')
            {Console.WriteLine($"{letter} is a Vowel.");}
        else if (letter == 'y' || letter == 'Y') {Console.WriteLine($"Some people consider {letter} to be a Vowel while others think {letter} is a consonant");}
        else {Console.WriteLine($"{letter} is a consonant.");}
    }
    public static void DisplayDayOfWeek(int dayCode)
    {
        if (dayCode == 0) {Console.WriteLine("Sunday");}
        else if (dayCode == 1) {Console.WriteLine("Monday");}
        else if (dayCode == 2) {Console.WriteLine("Tuesday");}
        else if (dayCode == 3) {Console.WriteLine("Wednesday");}
        else if (dayCode == 4) {Console.WriteLine("Thursday");}
        else if (dayCode == 5) {Console.WriteLine("Friday");}
        else if (dayCode == 6) {Console.WriteLine("Saterday");}
    }
}