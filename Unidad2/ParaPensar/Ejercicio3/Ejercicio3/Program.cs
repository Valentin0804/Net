internal class Program
{
    private static void Main(string[] args)
    {

        int[] numeros = new int[25];
        numeros[0] = 1;
        numeros[1] = 1;

        for (int i = 2; i < 25; i++)
        {
            numeros[i] = (numeros[i - 1] + numeros[i - 2]);
        }
        foreach (int i in numeros)
        {
            Console.WriteLine(i);
        }
    }
}