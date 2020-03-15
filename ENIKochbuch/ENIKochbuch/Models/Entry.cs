using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ENIKochbuch.Models
{
    public enum Klassifikation{vegetarisch,vegan,fleichhaltig, keineAngaben };
    public enum Schwierigkeit { leicht, mittel, schwer, keineAngaben};
    public enum Saison {Frühling, Sommer, Herbst, Winter, alles, keineAngaben };
   public enum Gang { Hauptspeiße, Dessert, Nachspeiße, keineAngaben }

    public class Entry
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Beschreibung { get; set; }
        public Klassifikation Klassifikation { get; set; }
        public int Portionen { get; set; }
        public Schwierigkeit Schwierigkeit { get; set; }
        public Saison Saison { get; set; }
        public Gang Gang { get; set; }

        public Entry() : this(0, " "," ", Klassifikation.keineAngaben,0,Schwierigkeit.keineAngaben,Saison.keineAngaben,Gang.keineAngaben) { }
        public Entry(int Id, String Name,String Beschreibung,Klassifikation Klassifikation, int Portion, Schwierigkeit Schwierigkeit, Saison Saison, Gang Gang)
        {
            this.Id = Id;
            this.Name = Name;
            this.Beschreibung = Beschreibung;
            this.Klassifikation = Klassifikation;
            this.Portionen = Portionen;
            this.Schwierigkeit = Schwierigkeit;
            this.Saison = Saison;
            this.Gang = Gang;
        }
    }
}