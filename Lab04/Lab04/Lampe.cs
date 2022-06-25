// See https://aka.ms/new-console-template for more information
public class Lampe
{
    // les methodes et les comportements de la classe Lampe 

    // premier constructeur par defaut
    public Lampe() 
    {
        this._etat = false;
        this._couleur = "jaune";
    }

    // deuxieme contructeur
    public Lampe(bool etat)
    {
       
        this._etat = etat;
        this._couleur = "jaune";
    }

    // troisieme constructeur
    public Lampe(bool etat, string couleur)
    {
        this._etat = etat;
        this._couleur = couleur;
    }

    public void Eteindre()
    {
        this._etat = false;
    }

    public void Allumer()
    {
        this._etat = true;
    }

    public bool Etat()
    {
        return this._etat;
    }

    public void Afficher()
    {
        Console.WriteLine($"Etat : {this.Etat()}");
        Console.WriteLine($"Couleur : {this._couleur}"); 
    }

    //  les attributs ou les proprietes de la classe lampe 
    private bool _etat;
    private string _couleur;

}










