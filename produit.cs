class Produit
{
    private string codeArticle;
    private string designation;
    private double prix;

    public Produit(string code, string nom, double px)
    {
        this.codeArticle = code;
        this.designation = nom;
        this.prix = px;
    }

    public string GetCodeArticle()
    {
        return codeArticle;
    }

    // Exercice 1
    public override string ToString()
    {
        return $"Code Article: {codeArticle}, Designation: {designation}, Prix: {prix}";
    }

    // Exercice 2
    public override bool Equals(object obj)
    {
        if (obj is Produit autre)
        {
            return codeArticle == autre.codeArticle;
        }
        return false;
    }

    // Exercice 3 
    public override int GetHashCode()
    {
        return codeArticle.GetHashCode();
    }
}