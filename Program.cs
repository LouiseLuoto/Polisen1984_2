﻿using System;
using System.Diagnostics.Contracts;
class Police
{
    public string name;
    
    public Police (string name)
    {
        this.name = name;
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
internal class Program
{
    static void Main ()
    {
        List<Police> polices = new List <Police>();

        Police police = new Police("Bengt karlsson");
        polices.Add(police);

        Police police2 = new Police("Orvar Pettersson");
        polices.Add(police2); 

        Police police3 = new Police("Ylva Jonsson");
        polices.Add(police3);

        Police police4 = new Police("Felicia Mellgren");
        polices.Add(police4);

        foreach(Police p in polices)
            Console.WriteLine(p.name);

        List<Policestation> policestation = new List<Policestation>();

        Policestation policest = new Policestation("Norra");
        policestation.Add(policest);

        Policestation policest2 = new Policestation("Gunnilse");
        policestation.Add(policest2);

        Policestation policest3 = new Policestation("Ale");
        policestation.Add(policest3);

        Policestation policest4 = new Policestation("Angered");
        policestation.Add(policest4);

        foreach(Policestation m in policestation)
            Console.WriteLine(m.policeSt);
    }
} 