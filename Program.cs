﻿using System;
using System.Diagnostics.Contracts;
using System.Xml.Serialization;
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
class Crime
{
    public string crime;
    public Crime (string crime)
    {
        this.crime = crime;
    }
}
internal class Program
{
    static void Main ()
    {
        List<Police> polices = new List <Police>();
      
        polices.Add(new Police("Bengt, Karlsson", 1001));
    
        polices.Add(new Police("Orvar, Pettersson", 1002)); 

        polices.Add(new Police("Lolita, Olsson", 1006));

        polices.Add(new Police("Roffe, Jansson", 1007));
    
        polices.Add(new Police("Janne, Pettersson", 1009)); 

        polices.Add(new Police("Felica, Mellgren", 1011));


        foreach(Police p in polices)
            Console.WriteLine(p.name);

        List<Policestation> policestation = new List<Policestation>();

        policestation.Add(new Policestation("Norra"));

        policestation.Add(new Policestation("Gunnilse"));

        policestation.Add(new Policestation("Ale"));

        policestation.Add(new Policestation("Angered"));

        foreach(Policestation m in policestation)
            Console.WriteLine(m.policeSt);


        List<Crime> crime = new List<Crime>();

        crime.Add(new Crime("Stöld"));

        crime.Add(new Crime("Bedrägeri"));

        crime.Add(new Crime("Rattfylla"));

        crime.Add(new Crime("Narkotikabrott"));

        crime.Add(new Crime("Skadegörelse"));

        crime.Add(new Crime("Misshandel"));

        crime.Add(new Crime("Snatteri"));

        crime.Add(new Crime("Mord"));  

        foreach(Crime n in crime)
            Console.WriteLine(n.crime);                

    }

} 