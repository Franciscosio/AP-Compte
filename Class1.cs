using System;

public class Compte
{
	private int numero;
	private string nom;
	private int solde;
	private int decouvertAutorise;

	public Compte()
	{
		this.numero = 0
	    this.nom = "";
	    this.solde= 0 ;
	    this.découvertAutorise = 0;
	}


	public Compte(int numero, string nom, int solde, int decouvertAutorise)
	
	{
		this.numero = numero
		this.nom = nom;
		this.solde = solde;
		this.decouvertAutorise = decouvertAutorise;
        
	}

	public  int Numero
    {
        get	{return numero;}
        set { numero = value; }
    }

	public string Nom
	{
		get { return nom; }
		set { nom = value; }
	}

	public int Solde
	{
		get { return solde; }
		set { solde = value; }
	}

	public int DecouvertAutorise
	{
		get { return decouvertAutorise; }
		set { decouvertAutorise = value; }
	}

	public void Afficher()
    {
		Console.WriteLine("");
    }

}


