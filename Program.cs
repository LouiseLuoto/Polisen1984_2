﻿using System;
using System.Diagnostics.Contracts;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography;

public class CallOut
{
    string Police;

    public CallOut(string Police)
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
class Police
{
    public string name;
    public int serviceNumber;
    public Police(string name, int serviceNumber)
    {
        this.name = name;
        this.serviceNumber = serviceNumber;
    }
}
class Report
{
    public int reportNr;
    private static int reportCounter = 1;
    public string policeSt;
    public Report(int reportnr, string policeSt)
    {
        this.reportNr = reportNr;
        this.reportNr = reportCounter++;
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




class Program
{
    
    static void ReportFunction()
    {
        Console.Write("Välj vilken polis som deltog: ");    //Hämta från lista
        string policechoice = Console.ReadLine();
        Console.Write("Vilken typ av brott: ");             //Hämta index från Crime
        string crime = Console.ReadLine();
        Console.Write("Tidpunkt för brottet med format HHMM: ");
        DateTime timeCrime = DateTime.Parse(Console.ReadLine());
        Console.Write("Plats för brottet: ");
        string place = Console.ReadLine();
    }

    static void RapportFunction()
    {
        Console.Write("Skriv rapportnummer: "); //fixa så att den skapar ett ++
        int reportnr = int.Parse(Console.ReadLine());
        Console.Write("Skriv datum med format YY/MM/DD: ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        string policeStation = Console.ReadLine();
        Console.Write("Polisstation: ");             //Hämta index från Polis
    }

    static void PolisAdd(List<Police> polices)
    {
        // polices.Add(new Police("Bengt Karlsson", 100145));

        System.Console.WriteLine("Skriv in namnet");
        string namn = Console.ReadLine();
        System.Console.WriteLine("Skriv in Tjänstenummer");
        int UI = int.Parse(Console.ReadLine());

        polices.Add(new Police (namn,UI));


    }

    static void Meny(){

        Console.WriteLine("Välkommen till Rapportsystem 80.");
        Console.WriteLine(" [RE]gistrering av utryckningar");
        Console.WriteLine(" [RP]gistrering av Polis");  // Lägg till registering av polis funktion
        Console.WriteLine(" [R]apporter");
        Console.WriteLine(" [L]ist");
        Console.WriteLine(" [A]vsluta");

        /*DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime);*/
    }

    static void ListFunction(List<Police> polices){

        foreach(var police in polices)
        {
            System.Console.WriteLine($"{police.name}"+ $"{police.serviceNumber}");    
        }


    }

    static void Main()
    {
        List<Police> polices = new List<Police>();


        bool isRunning = true;
        while (isRunning)
        {   
            Meny();
            string choice = Console.ReadLine().ToUpper();
            polices.Add(new Police("Bengt Karlsson", 100145));
            polices.Add(new Police("Orvar Pettersson", 102302));
            polices.Add(new Police("Lolita Olsson", 104506));
            polices.Add(new Police("Roffe Jansson", 102307));
            polices.Add(new Police("Janne Pettersson", 100989));
            polices.Add(new Police("Felicia Mellgren", 116011));
            switch (choice)
            {
                case "RE":
                    ReportFunction();
                    break;
                case "RP":
                    PolisAdd(polices);
                    break;
                case "R":
                    RapportFunction();
                    break;
                case "L":
                    ListFunction(polices);
                    break;
                case "A":
                    isRunning = false;
                    break;

            }
            Console.ReadKey();
        }
    }
}
// Skap en meny
// val 1: Registrera utryckningar
// val 2: Skriva rapport
// val 3: Personal info. Samt reistrera ny personal.
// val 4: Informationsammanställning

// Skapa rapport som innehåller rapportnummer + datum + polistation + beskrivning