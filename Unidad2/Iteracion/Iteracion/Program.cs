class Program
    {
    static void Main(string[] args)
    {
        int i;
        int cantItnteracciones = 5;
        String[] arreglo = new String[cantItnteracciones];

        for (i = 0; i < cantItnteracciones; i++)
        {
            Console.WriteLine("ingrese un texto");
            arreglo[i] = Console.ReadLine();   
        }
        foreach (String item in arreglo)
        {
            Console.WriteLine(item);
        }
                   
    }
}