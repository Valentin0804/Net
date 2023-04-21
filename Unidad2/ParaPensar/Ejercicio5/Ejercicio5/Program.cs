internal class Program
{
    private static void Main(string[] args)
    {
        String[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

        Console.WriteLine("ingrese un mes de año: ");
        String mes = Console.ReadLine();

        int i = 1;
        foreach (String s in meses)
        {
            if (mes == s)
            {
                Console.WriteLine("Nombre del mes " + mes + " numero del mes: " +  i);
            }else { i++; }
        }
    }
}
