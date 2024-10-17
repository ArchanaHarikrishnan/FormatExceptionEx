namespace FormatExceptionEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string Name = Console.ReadLine();

            try
            {
                int number = int.Parse(Name);
                Console.WriteLine("You entered the number: " + number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}