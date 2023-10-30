using Fundamentos.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};

        foreach(var list in array)
        {
            Console.WriteLine(list);
        }

        Console.WriteLine("******************\n");

        List<int> lista = new List<int>();
        lista.Add(1);
        lista.Add(2);
        lista.Remove(1);

        foreach (var listab in lista) 
        {
            Console.WriteLine(listab);
        }
        
        Console.WriteLine("****************\n");
        List<cerbeza> cerbezas = new List<cerbeza>() { new cerbeza(10,"cerbeza premium")};
        cerbezas.Add(new cerbeza(200));
        cerbeza xx = new cerbeza(500, "cereza ambar");
        cerbezas.Add(xx);

        foreach (var beb in cerbezas)
        {
            Console.WriteLine("cerbezas nombre ---->" + cerbezas.Nombre);
        }





    }
}                              