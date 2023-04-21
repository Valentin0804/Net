internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero ");
        String n = Console.ReadLine();
        int num1 = Convert.ToInt32(n);

        Console.WriteLine("Ingrese el primer numero ");
        String m = Console.ReadLine();
        int num2 = Convert.ToInt32(m);

        int suma = num1 + num2;
        Console.WriteLine("La sumatoria del numero " + num1 + " y el numero " + num2 + " es: " +  suma);

    }
}