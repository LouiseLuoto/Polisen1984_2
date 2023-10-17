﻿using System;
using System.Diagnostics.Contracts;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography;
public class Program
{
    public static List<Police> polices = new List<Police>();



    static void PolisAdd(List<Police> polices)
    {
        // polices.Add(new Police("Bengt Karlsson", 100145));
        
        System.Console.WriteLine("Skriv in namnet");
        string namn = Console.ReadLine() +"";
        System.Console.WriteLine("Skriv in Tjänstenummer");
        int UI = int.Parse(Console.ReadLine() +"");

        polices.Add(new Police (namn,UI));
    }
        /*DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime);*/
    static void Main()
    {
        polices.Add(new Police("Bengt Karlsson", 100145));
        polices.Add(new Police("Orvar Pettersson", 102302));
        polices.Add(new Police("Lolita Olsson", 104506));
        polices.Add(new Police("Roffe Jansson", 102307));
        polices.Add(new Police("Janne Pettersson", 100989));
        polices.Add(new Police("Felicia Mellgren", 116011));
        bool isRunning = true;
        while (isRunning)
        {   
            Console.WriteLine("Välkommen till Rapportsystem 80.");
            Console.WriteLine("1. Registrering av utryckningar");
            Console.WriteLine("2. Rapporter");
            Console.WriteLine("3. Lägga till personal.");
            Console.WriteLine("4. Avsluta");
            string choice = Console.ReadLine()+"";
            switch (choice)
            {
                case "1":

                    Callout.RegistrationOfCallout(polices);
                    break;
                case "2":
                    Report.Reports();
                    break;
                case "3":
                    /*Program.ListFunction();
                    break;*/
                /*case "L":
                    ListFunction(polices);
                    break;*/
                case "4":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Vad menar du nu? Testa igen!");
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