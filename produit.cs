class Produit { 
    private string codeArticle;  
    private string designation; 
    private double prix; 
 
    public Produit(string code, string nom, double px) { 
        this.codeArticle = code; 
        this.designation = nom; 
        this.prix = px; 
    } 
 
    public string GetCodeArticle() { 
        return codeArticle; 
    } 

    // Exercice 1
    public override string ToString() { 
        return $"Code Article: {codeArticle}, Designation: {designation}, Prix: {prix}"; 
    }
} 