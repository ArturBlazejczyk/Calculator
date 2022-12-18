using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Witaj w aplikacji kalkulator!");
        while (true)
        {
            try
            {
                Console.WriteLine("Podaj pierwszą liczbę");
                var firstNumber = GetInput();

                Console.WriteLine("Podaj działanie, które chcesz wykonać: (+,-,*,=)");
                var typeOfCalculation = Console.ReadLine();

                Console.WriteLine("Podaj drugą liczbę");
                var secondNumber = GetInput();

                var result = Calculation(firstNumber, secondNumber, typeOfCalculation);

                Console.WriteLine($"Wynik to {Math.Round(result, 2)}.");

            }
            catch (Exception ex)
            {
                //logowanie do pliku
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("");
        }
    }

    private static double GetInput()
    {
        if (!double.TryParse(Console.ReadLine(), out double input))
            throw new Exception("Podana wartość nie jest liczbą.");

        return input;
    }

    private static double Calculation(double firstNumber, double secondNumber, string typeOfCalculation)
    {
        switch (typeOfCalculation)
        {
            case "+":
                return firstNumber + secondNumber;
            case "-":
                return firstNumber - secondNumber;
            case "*":
                return firstNumber * secondNumber;
            case "/":
                return firstNumber / secondNumber;
            default:
                throw new Exception("Wybrałeś nieprawidłowy operator");
        }
    }
 }