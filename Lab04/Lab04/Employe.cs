// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


public class Employe
{
    public Employe()
    {
        this._nom = "";
        this._prenom = "";
        this._salaire = 0;
        this._anneeEmbauche = 0;
        this._adresse = "";
    }

    public Employe(string nom, string prenom, int salaire, int anneeEmbauche)
    {
        // les variables constante pour employer
        const int ANNEE_EMBAUCHE_PAR_DEFAULT = 1995;
        const int SALAIRE_PAR_DEFAULT = 2000;

        // mettre le nom en majuscule
        this._nom = nom.ToUpper();

        // mettre le nom en minuscule
        this._prenom = prenom.ToLower();

        // annee embauche soit comprise entre 1995 et 2001. Sinon on lui donne l annee 1995 par default
        if (anneeEmbauche < 1995 || anneeEmbauche > 2021)
        {
            this._anneeEmbauche = ANNEE_EMBAUCHE_PAR_DEFAULT;
        }
        else
        {
            this._anneeEmbauche = anneeEmbauche;
        }

        // le salaire doit etre superieur a 2000$CAD. Sinon on affecte a la valeur 2000$CAD par default
        if (salaire > 2000)
        {
            this._salaire = salaire;
        }
        else
        {
            this._salaire -= SALAIRE_PAR_DEFAULT;
        }

        this._adresse = "";
    }

    public Employe(string nom, string prenom, int salaire, int anneeEmbauche, string adresse)
    {
     // les variables constante pour employer
        const int ANNEE_EMBAUCHE_PAR_DEFAULT = 1995;
        const int SALAIRE_PAR_DEFAULT = 2000;

    // mettre le nom en majuscule
        this._nom = nom.ToUpper();

    // mettre le nom en minuscule
        this._prenom = prenom.ToLower();

    // annee embauche soit comprise entre 1995 et 2001. Sinon on lui donne l annee 1995 par default
        if (anneeEmbauche < 1995 || anneeEmbauche > 2021)
        {
            this._anneeEmbauche = ANNEE_EMBAUCHE_PAR_DEFAULT;
        }
        else
        {
            this._anneeEmbauche = anneeEmbauche;
        }

        // le salaire doit etre superieur a 2000$CAD. Sinon on affecte a la valeur 2000$CAD par default
        if (salaire > 2000)
        {
            this._salaire = salaire;
        }
        else
        {
            this._salaire -= SALAIRE_PAR_DEFAULT;
        }

        this._adresse = adresse;

    }

    public int SalaireAnnuel()
    {
        const int DOUZE_MOIS_ANNUEL = 12;
        return this._salaire * DOUZE_MOIS_ANNUEL; 
    }

    public int Anciennete()
    {
        const int ANNEE_COURANTE = 2021;
        return (ANNEE_COURANTE - this._anneeEmbauche);  
    }

    public double Prime()
    {
        // variable constante annee anciennete
        const int ANNEE_ANCIENNETE_5ANS = 5;
        const int ANNEE_ANCIENNETE_10ANS = 10;
        const int ANNEE_ANCIENNETE_15ANS = 15;

        // variable constante niveau de prime
        const int PRIME_10POURCENT = 10;
        const int PRIME_15POURCENT = 15;
        const int PRIME_20POURCENT = 20;
        const int PRIME_25POURCENT = 25;
        const int PRIME_100POURCENT = 100;

        if ( this.Anciennete() < ANNEE_ANCIENNETE_5ANS)
        {
            return (this.SalaireAnnuel() * PRIME_10POURCENT) / PRIME_100POURCENT; 
        }
        else if (!(this.Anciennete() < ANNEE_ANCIENNETE_5ANS) && !(this.Anciennete() > ANNEE_ANCIENNETE_10ANS))
        {
            return (this.SalaireAnnuel() * PRIME_15POURCENT) / PRIME_100POURCENT;
        }
        else if (!(this.Anciennete() < ANNEE_ANCIENNETE_10ANS) && !(this.Anciennete() > ANNEE_ANCIENNETE_15ANS))
        {
            return (this.SalaireAnnuel() * PRIME_20POURCENT) / PRIME_100POURCENT;
        }
        else if (this.Anciennete() >= ANNEE_ANCIENNETE_15ANS)
        {
            return (this.SalaireAnnuel() * PRIME_25POURCENT) / PRIME_100POURCENT;
        }
        return 0;
    }

    public void Equals(Employe employe)
    {
        if (this._nom == employe._nom && this._prenom == employe._prenom && this._adresse == employe._adresse && this._anneeEmbauche == employe._anneeEmbauche && this._salaire == employe._salaire)
        {
            Console.WriteLine($"Les deux employes sont eguaux");
        }
        else
        {
            Console.WriteLine($"Les deux employes ne sont pas eguaux");
        }
    }

    public void Afficher()
    {
        Console.WriteLine($"Nom : {this._nom}");
        Console.WriteLine($"Prenom : {this._prenom}");
        Console.WriteLine($"Salaire : {this._salaire}$CAD");
        Console.WriteLine($"Adresse : {this._adresse}.");
        Console.WriteLine($"Tu as {this.Anciennete()} annes d anciennete");
    }

    private string _nom;
    private string _prenom;
    private string _adresse;
    private int _anneeEmbauche;
    private int _salaire;
}








