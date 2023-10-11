﻿using System;
using System.Diagnostics.Contracts;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Collections;

public class CallOut
{
    string Police;
    public CallOut (string Police)
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
    
    public Police (string name, int serviceNumber)
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
    public Report (int reportnr, string policeSt)
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
    static void Main ()
    {
        Console.WriteLine("Välkommen till Rapportsystem 80.");
        DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime);
        List<Police> polices = new List <Police>();
      
        polices.Add(new Police("Bengt, Karlsson", 100145));
    
        polices.Add(new Police("Orvar, Pettersson", 102302)); 

        polices.Add(new Police("Lolita, Olsson", 104506));

        polices.Add(new Police("Roffe, Jansson", 102307));
    
        polices.Add(new Police("Janne, Pettersson", 100989)); 

        polices.Add(new Police("Felicia, Mellgren", 116011));

        foreach(Police p in polices)
            Console.WriteLine("Polis: " + p.name + ", Tjänstenr: " + p.serviceNumber);
    }
} 
// Skap en meny
    // val 1: Registrera utryckningar
    // val 2: Skriva rapport
    // val 3: Personal info. Samt reistrera ny personal.
    // val 4: Informationsammanställning

// Skapa rapport som innehåller rapportnummer + datum + polistation + beskrivning



