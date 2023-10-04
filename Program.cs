using System;
namespace Police
{
    class Police
    {
        public string name;
    }
    internal class Program
    {
        static void Main ()
        {
            List<Police> polices = new List <Police>();
            Police police = new Police();
            police.name = "Bengt Karlsson";
            polices.Add(police);
            Police police2 = new Police();
            police.name = "Orvar Pettersson";
            polices.Add(police); 
            Police police3 = new Police();
            police.name = "Ylva Jonsson";
            polices.Add(police);
            Police police4 = new Police();
            police.name = "Felicia Mellgren";
            polices.Add(police);
        }
    }
}