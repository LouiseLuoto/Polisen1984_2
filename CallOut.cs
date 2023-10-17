using System.Diagnostics.Contracts;

public class Callout
{
    public static List<Callout> policesCall = new List<Callout>();
    

    public static void RegistrationOfCallout(List<Police> polices)
    {
        Console.Write("Välj hur många poliser som deltog i insatsen: ");
        int number = int.Parse(Console.ReadLine()+"");
        for(int i=0; i<number; i++)
            Console.WriteLine($"{i}. Namn: {polices[i].name}."+ " " + $"U-nummer: {polices[i].serviceNumber}");
        //for (int i = 0; i < policesCall; i++)
        Console.Write("Välj vilken polis som deltog: ");
        string policechoice = (Console.ReadLine()+"");

        policesCall.Add(new Callout(policechoice));


        Console.Write("Vilken typ av brott: ");             //Hämta index från Crime
        string crime = Console.ReadLine() +"";
        Console.Write("Tidpunkt för brottet med format HH:MM: ");
        DateTime timeCrime = DateTime.Parse(Console.ReadLine() +"");
        Console.Write("Plats för brottet: ");
        string place = Console.ReadLine() +"";
    }
    string Police;
    public Callout(string Police)
    {
        this.Police = Police;
    }
    public enum Crime
    {
        Stöld,
        Narkotikabrott,
        Brott,
        Bedrägeri,
        Misshandel,
        Snatteri,
        Skadegörelse,
        Mord,
        Skattebrott
    }
}
