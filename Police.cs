public class Police
{
    public static void PrintPolices(List<Police> polices)
    {
        for(int i=1; i<polices.Count; i++)
            Console.WriteLine($"{i}. Namn: {polices[i].name}."+ " " + $"U-nummer: {polices[i].serviceNumber}");
    }
    public string name;
    public int serviceNumber;
    public Police(string name, int serviceNumber)
    {
        this.name = name;
        this.serviceNumber = serviceNumber;
    }
}
