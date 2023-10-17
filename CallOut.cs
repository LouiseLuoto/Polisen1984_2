public class Callout
{
    public static void RegistrationOfCallout()
    {
        Console.Write("Välj vilken polis som deltog: ");
        int policechoice = Convert.ToInt32(Console.ReadLine());
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
