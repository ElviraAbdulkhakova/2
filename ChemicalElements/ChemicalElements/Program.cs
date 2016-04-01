using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalElements
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            ChemicalElement Chlorum;
            Chlorum.shortname = "Cl";
            Chlorum.fullname = "Chlorum";
            Chlorum.number = 17;
            Chlorum.mass = 35.453;
            Chlorum.element_group = ChemicalElement.group.seventeenth;
            Chlorum.element_period = ChemicalElement.period.third;
            Chlorum.metal = false;

            Console.WriteLine(Chlorum);
        }
    }

    //struct describe chemical elements according to the periodic system of Mendeleev
    struct ChemicalElement
    {
        public enum group
        {
            first = 1, second = 2, third = 3, fourth = 4, fifth = 5, sixth = 6,
            seventh = 7, eighth = 8, ninth = 9, tenth = 10, eleventh = 11, twelfth = 12,
            thirteen = 13, fourteen = 14, fifteenth = 15, sixteen = 16, seventeenth = 17, eighteenth = 18
        };
        public enum period { first = 1, second = 2, third = 3, fourth = 4, fifth = 5, sixth = 6, seventh = 7, eighth = 8 };   
   
        public string shortname;
        public string fullname;
        public int number;
        public double mass;
        public group element_group;
        public period element_period;
        public bool metal;

        public override string ToString()
        {

            return String.Format("Element of the periodic system of Mendeleev:\n\nshortname - {0}\nfullname - {1}\nnumber - {2}\nmass - {3}\ngroup - {4}\nperiod - {5}\nmetal - {6}",shortname, fullname, number, mass, (int)element_group, (int)element_period,metal );
        }

    }
}
