namespace Tp_classe_object;

class Program
{
    static void Main(string[] args)
    {
        Produit p1 = new Produit("A001", "Produit 1", 10.5);
        // Exercice 1  
        Console.WriteLine(p1);

        // Exercice 2
        Produit p2 = new Produit("A002", "Souris", 15.0);
        Produit p3 = new Produit("A002", "Souris", 15.0);

        Console.WriteLine(p2 == p3); 

        

    }
}
