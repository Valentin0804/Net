internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un año");
        String a = Console.ReadLine();
        int año = Convert.ToInt32(a);

        if (año % 4 == 0)
        {
            if (año % 100 == 0)
            {
                if (año % 400 == 0)
                {
                    Console.WriteLine("El año es bisiesto");
                }else { Console.WriteLine("El año NO es bisiesto"); }
            }else { Console.WriteLine("El año es bisiesto"); }
        }else { Console.WriteLine("El año NO es bisisesto"); }
    }
}