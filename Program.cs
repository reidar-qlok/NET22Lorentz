namespace NET22Lorentz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manuellt test");
            WeightCalculator calculator = new WeightCalculator
            {
                Height = 176,
                Gender='m'
            };
            double result = calculator.GetIdealBodyWeight();
            Console.WriteLine($"Kroppsvikten borde ligga på ca. {result}");

            if( result == 77 ) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Testet lyckades");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Testet misslyckades");
            }
            calculator.Gender = 'w';
            double result2 = calculator.GetIdealBodyWeight();
            if (result2 == 63)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Testet lyckades");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Testet misslyckades");
            }
        }
        
    }
}