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

        // --- EXERCICE 3 ---
        Produit p4 = new Produit("A01", "Livre", 10.0);
        Produit p5 = new Produit("A01", "Livre", 10.0);
        HashSet<Produit> panier = new HashSet<Produit>();
        panier.Add(p4);
        panier.Add(p5);
        Console.WriteLine($"Taille du panier : {panier.Count}");

        // --- EXERCICE 4 ---
        Produit article = new ProduitPerissable("B05", "Lait", 15.0, 5);
        Console.WriteLine($"Type : {article.GetType()}");

        // --- EXERCICE 5 ---
        List<object> inventaire = new List<object>();
        inventaire.Add(10);
        inventaire.Add("Dépôt Central");
        inventaire.Add(p1);

        foreach (object item in inventaire)
        {
            Console.WriteLine($"Type : {item.GetType()} | Description : {item.ToString()}");
            if (item is Produit p)
            {
                // Note : Assurez-vous d'avoir un getter pour codeArticle
                Console.WriteLine($"Code article détecté : {p.GetCodeArticle()}");
            }
        }
    }
}
