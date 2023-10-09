﻿using System;
using System.Diagnostics.Contracts;
using System.Xml.Serialization;
using System.Collections.Generic;

class CallOuts
{
    int aDate;
    public

    Console.WriteLine(aDate.ToString("HH:mm"));

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
    
    public Police (string name, int serviceNumber)
    {
        this.name = name;
        this.serviceNumber = serviceNumber;
    }
}
class Policestation
{
    public string policeSt;

    public Policestation(string policeSt)
    {
        this.policeSt= policeSt;
    }
}


    



class Reports
{
    public int reportNr;
    private static int reportCounter = 1;
    public Reports (int reportnr)
    {
        this.reportNr = reportNr;
        this.reportNr = reportCounter++;
    }
}
class Program
{
    static void Main ()
    {
        Console.WriteLine("Välkommen till Rapportsystem 80.");
        List<Police> polices = new List <Police>();
      
        polices.Add(new Police("Bengt, Karlsson", 100145));
    
        polices.Add(new Police("Orvar, Pettersson", 102302)); 

        polices.Add(new Police("Lolita, Olsson", 104506));

        polices.Add(new Police("Roffe, Jansson", 102307));
    
        polices.Add(new Police("Janne, Pettersson", 100989)); 

        polices.Add(new Police("Felicia, Mellgren", 116011));


        foreach(Police p in polices)
            Console.WriteLine("Polis: " + p.name + ", Tjänstenr: " + p.serviceNumber);

        List<Policestation> policestation = new List<Policestation>();

        policestation.Add(new Policestation("Norra"));

        policestation.Add(new Policestation("Gunnilse"));

        policestation.Add(new Policestation("Ale"));

        policestation.Add(new Policestation("Angered"));

        foreach(Policestation m in policestation)
            Console.WriteLine("Polisstation: " + m.policeSt);


        List<Crime> crime = new List<Crime>();

        crime.Add(new Crime("Stöld"));

        crime.Add(new Crime("Bedrägeri"));

        crime.Add(new Crime("Rattfylla"));

        crime.Add(new Crime("Narkotikabrott"));

        crime.Add(new Crime("Skadegörelse"));

        crime.Add(new Crime("Misshandel"));

        crime.Add(new Crime("Snatteri"));

        crime.Add(new Crime("Mord"));  

              

    }

} 
// Skap en meny
    // val 1: Registrera utryckningar
    // val 2: Skriva rapport
    // val 3: Personal info. Samt reistrera ny personal.
    // val 4: Informationsammanställning

// Skapa rapport som innehåller rapportnummer + datum + polistation + beskrivning



