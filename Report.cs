public class Report
{
    public static void Reports()
    {
        Console.Write("Skriv rapportnummer: "); //fixa så att den skapar ett ++
        int reportnr = int.Parse(Console.ReadLine() +"");
        Console.Write("Skriv datum med format YY/MM/DD: ");
        DateTime date = DateTime.Parse(Console.ReadLine() +"");
        Console.Write("Polisstation: ");
        string policeStation = Console.ReadLine() +"";
    }
    public int reportNr;
    private static int reportCounter = 1;
    public string policeSt;
    public Report(int reportnr, string policeSt)
    {
        this.reportNr = reportnr;
        //this. = reportCounter++;
        this.policeSt = policeSt;
    }
    public enum Policestation
    {
        Norra,
        Gunnilse,
        Ale,
        Angered,
        City
    }
}
