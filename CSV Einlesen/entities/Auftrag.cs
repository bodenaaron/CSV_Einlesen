using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Einlesen
{
    public partial class Auftrag
    {
        [Ignore]
        [Browsable(false)]
        public bool inDB{ get; set; }
        [Ignore]
        [Browsable(false)]
        public Projekt projekt { get; set; }
        [ReadOnly(true)]
        [Name("BA/FA ID")]        
        public virtual string BAFA_ID { get; set; }
        [Name("SM-Auftrag T-COM")]
        [ReadOnly(true)]
        public virtual string SMAuftrag_TCOM { get; set; }
        [Name("Projekt-ID")]
        [ReadOnly(true)]
        public virtual string ProjektIDTelekom { get; set; }
        [Name("Auftragsnummer AG")]
        [ReadOnly(true)]
        public virtual string Auftragsnummer_AG { get; set; }
        [Name("Status")]
        [ReadOnly(true)]
        public virtual string Status { get; set; }
        [Name("Aktuelle Gruppe")]
        [ReadOnly(true)]
        public virtual string Aktuelle_Gruppe { get; set; }
        [Name("Aktueller Bearbeiter")]
        [ReadOnly(true)]
        public virtual string Aktueller_Bearbeiter { get; set; }
        [Name("Teilauftragsfall TI")]
        [ReadOnly(true)]
        public virtual string Teilauftragsfall_TI { get; set; }
        [Name("Auftragskurzbeschreibung")]
        
        public virtual string Auftragskurzbeschreibung { get; set; }
        [Name("Beauftragendes Ressort")]
        [ReadOnly(true)]
        public virtual string Beauftragendes_Ressort { get; set; }
        [Name("Auftragseingang Ressort")]
        [ReadOnly(true)]
        public virtual string Auftragseingang_Ressort { get; set; }
        [Name("BA/FA betriebsbereit korr.")]
        [ReadOnly(true)]
        public virtual DateTime BAFA_betriebsbereit_korr { get; set; }
        [Name("Technisch Fertig")]
        [ReadOnly(true)]
        public virtual string Technisch_Fertig { get; set; }
        [Name("ONKZ")]
        [ReadOnly(true)]
        public virtual string ONKZ { get; set; }
        [Name("AsB")]
        [ReadOnly(true)]
        public virtual string AsB { get; set; }
        [Name("LSZ")]
        [ReadOnly(true)]
        public virtual string LSZ { get; set; }
        [Name("LSZ Zusatz")]
        [ReadOnly(true)]
        public virtual string LSZ_Zusatz { get; set; }
        [Name("VPSZ A")]
        [ReadOnly(true)]
        public virtual string VPSZ_A { get; set; }
        [Name("KD Straße")]
        [ReadOnly(true)]
        public virtual string KD_Strasse{ get; set; }
        [Name("KD HsNr")]
        [ReadOnly(true)]
        public virtual string KD_HsNr { get; set; }
        [Name("KD Zusatz")]
        [ReadOnly(true)]
        public virtual string KD_Zusatz { get; set; }
        [Name("KD PLZ")]
        [ReadOnly(true)]
        public virtual string KD_PLZ { get; set; }
        [Name("KD Ort")]
        [ReadOnly(true)]
        public virtual string KD_Ort { get; set; }
        [Name("Mont A Straße")]
        [ReadOnly(true)]
        public virtual string Mont_A_Strasse { get; set; }
        [Name("Mont A HsNr")]
        [ReadOnly(true)]
        public virtual string Mont_A_HsNr { get; set; }
        [Name("Mont A Zusatz Str.")]
        [ReadOnly(true)]
        public virtual string Mont_A_Zusatz_Str { get; set; }
        [Name("Mont A PLZ")]
        [ReadOnly(true)]
        public virtual string Mont_A_PLZ { get; set; }
        [Name("Mont A Ort")]
        [ReadOnly(true)]
        public virtual string Mont_A_Ort { get; set; }
        [Name("Mont A Gebäudeteil")]
        [ReadOnly(true)]
        public virtual string Mont_A_Gebaeudeteil { get; set; }
        [Name("Mont A Geb Zusatz")]
        [ReadOnly(true)]
        public virtual string Mont_A_Geb_Zusatz { get; set; }
        [Name("Mont A Raum")]
        [ReadOnly(true)]
        public virtual string Mont_A_Raum { get; set; }
        [Name("Ressortinterne Vermerke")]
        [ReadOnly(true)]
        public virtual string Ressortinterne_Vermerke { get; set; }
        [Name("Bemerkung zum FA")]
        [ReadOnly(true)]
        public virtual string Bemerkung_zum_FA { get; set; }
        [Name("Langtext / Bemerkung - Vorsystem")]
        [ReadOnly(true)]
        public virtual string Langtext_Bemerkung_Vorsystem { get; set; }
        [Name("EndSZ")]
        [ReadOnly(true)]
        public virtual string EndSZ { get; set; }
        [Name("FSZ A")]
        [ReadOnly(true)]
        public virtual string FSZ_A { get; set; }
        [Name("Relevanz AA_FA")]
        [ReadOnly(true)]
        public virtual string Relevanz_AA_FA { get; set; }
        [Name("BA/FA betriebsbereit")]
        [ReadOnly(true)]
        public virtual string BAFA_betriebsbereit { get; set; }
        [Name("BAFA abgeschlossen")]
        [ReadOnly(true)]
        public virtual string BAFA_abgeschlossen { get; set; }
        [Name("Storno Flag")]
        [ReadOnly(true)]
        public virtual string Storno_Flag { get; set; }
        [Name("Letzter Bearbeiter")]
        [ReadOnly(true)]
        public virtual string Letzter_Bearbeiter { get; set; }        
    }
}

           
