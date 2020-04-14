using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Einlesen
{
    public partial class DBAuftrag
    {
        public virtual int id { get; set; }
        public virtual Projekt Projekt { get; set; }
        public virtual string BAFA_ID { get; set; }
        public virtual string SMAuftrag_TCOM { get; set; }
        //public virtual Projekt Projekt { get; set; }
        public virtual WMSTIStatus Status { get; set; }
        public virtual string Teilauftragsfall_TI { get; set; }
        public virtual string Auftragskurzbeschreibung { get; set; }
        public virtual DateTime BAFA_betriebsbereit_korr { get; set; }
        public virtual string ONKZ { get; set; }
        public virtual string AsB { get; set; }
        public virtual string KD_Strasse { get; set; }        
        public virtual string KD_HsNr { get; set; }
        public virtual string KD_Zusatz { get; set; }
        public virtual string KD_PLZ { get; set; }
        public virtual string KD_Ort { get; set; }
        public virtual string Mont_A_Strasse { get; set; }
        public virtual string Mont_A_HsNr { get; set; }
        public virtual string Mont_A_Zusatz_Str { get; set; }
        public virtual string Mont_A_Ort { get; set; }
        public virtual string Langtext_Bemerkung_Vorsystem { get; set; } 
        public virtual string bearbeiter { get; set; }

        public virtual string auftraggeber { get; set; }
        
        public DBAuftrag()
        {

        }
        public virtual WMSTIStatus WMSTIStatus { get; set; }
        #region
        /*public DBAuftrag(Auftrag a)
        {
            Aktueller_Bearbeiter = a.Aktueller_Bearbeiter;
            Aktuelle_Gruppe = a.Aktuelle_Gruppe;
            AsB = a.AsB;
            Auftragseingang_Ressort = a.Auftragseingang_Ressort;
            Auftragskurzbeschreibung = a.Auftragskurzbeschreibung;
            Auftragsnummer_AG = a.Auftragsnummer_AG;
            BAFA_abgeschlossen = a.BAFA_abgeschlossen;
            BAFA_betriebsbereit = a.BAFA_betriebsbereit;
            BAFA_betriebsbereit_korr = a.BAFA_betriebsbereit_korr;
            BAFA_ID = a.BAFA_ID;
            Beauftragendes_Ressort = a.Beauftragendes_Ressort;
            Bemerkung_zum_FA = a.Bemerkung_zum_FA;
            EndSZ = a.EndSZ;
            FSZ_A = a.FSZ_A;
            KD_HsNr = a.KD_HsNr;
            KD_Ort = a.KD_Ort;
            KD_PLZ = a.KD_PLZ;
            KD_Strasse = a.KD_Strasse;
            KD_Zusatz = a.KD_Zusatz;
            Langtext_Bemerkung_Vorsystem = a.Langtext_Bemerkung_Vorsystem;
            Letzter_Bearbeiter = a.Letzter_Bearbeiter;
            LSZ = a.LSZ;
            LSZ_Zusatz = a.LSZ_Zusatz;
            Mont_A_Gebaeudeteil = a.Mont_A_Gebaeudeteil;
            Mont_A_Geb_Zusatz = a.Mont_A_Geb_Zusatz;
            Mont_A_HsNr = a.Mont_A_HsNr;
            Mont_A_Ort = a.Mont_A_Ort;
            Mont_A_PLZ = a.Mont_A_PLZ;
            Mont_A_Raum = a.Mont_A_Raum;
            Mont_A_Strasse = a.Mont_A_Strasse;
            Mont_A_Zusatz_Str = a.Mont_A_Zusatz_Str;
            ONKZ = a.ONKZ;
            ProjektID = a.ProjektID;
            Relevanz_AA_FA = a.Relevanz_AA_FA;
            Ressortinterne_Vermerke = a.Ressortinterne_Vermerke;
            SMAuftrag_TCOM = a.SMAuftrag_TCOM;
            Status = a.Status;
            Storno_Flag = a.Storno_Flag;
            Technisch_Fertig = a.Technisch_Fertig;
            Teilauftragsfall_TI = a.Teilauftragsfall_TI;
            VPSZ_A = a.VPSZ_A;
        }*/
        #endregion

        public DBAuftrag(Auftrag a, List<WMSTIStatus> s, List<Projekt> p)
        {            
            AsB = a.AsB;            
            Auftragskurzbeschreibung = a.Auftragskurzbeschreibung;                        
            BAFA_betriebsbereit_korr = a.BAFA_betriebsbereit_korr;
            BAFA_ID = a.BAFA_ID;            
            KD_HsNr = a.KD_HsNr;
            KD_Ort = a.KD_Ort;
            KD_PLZ = a.KD_PLZ;
            KD_Strasse = a.KD_Strasse;
            KD_Zusatz = a.KD_Zusatz;
            Langtext_Bemerkung_Vorsystem = a.Langtext_Bemerkung_Vorsystem;            
            Mont_A_HsNr = a.Mont_A_HsNr;
            Mont_A_Ort = a.Mont_A_Ort;            
            Mont_A_Strasse = a.Mont_A_Strasse;
            Mont_A_Zusatz_Str = a.Mont_A_Zusatz_Str;
            ONKZ = a.ONKZ;            
            SMAuftrag_TCOM = a.SMAuftrag_TCOM;                      
            Teilauftragsfall_TI = a.Teilauftragsfall_TI;
            bearbeiter = "System";
            Projekt = a.projekt;
            foreach (WMSTIStatus w in s)
            {
                if (a.Status==w.id)
                {
                    Status = w;
                }
            }
            

        }

    }
}
