class ConsoleApp2
{
    public static void Main()
    {
        double first_height, sec_height;
        Console.WriteLine("Enter the two heights: ");
        first_height = double.Parse(Console.ReadLine());
        sec_height = double.Parse(Console.ReadLine());
        if (first_height < sec_height)
            Console.WriteLine("The ball is taking off!");
        else
            Console.WriteLine("The ball is retreating!");
    }
}