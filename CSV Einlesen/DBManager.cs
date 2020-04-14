using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Einlesen
{
    class DBManager
    {
        private ISession getSession()
        {
            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            sessionFactory.Close();
            return session;
        }

        private void closeSession(ISession session, ITransaction tx)
        {
            session.Clear();
            session.Close();
            tx.Dispose();
        }

        public void save(List<Auftrag> auftraege)
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            foreach (Auftrag a in auftraege)
            {
                if (a.Auftragskurzbeschreibung.Length>60)
                {
                    a.Auftragskurzbeschreibung = a.Auftragskurzbeschreibung.Substring(0, 59);
                }
               
                DBAuftrag dba = new DBAuftrag(a, getWMSTI(), getProjekte());
                ICriteria crit = session.CreateCriteria<DBAuftrag>();
                crit.Add(Restrictions.Like("SMAuftrag_TCOM", dba.SMAuftrag_TCOM));
                DBAuftrag currentAuftrag = (DBAuftrag)crit.List<DBAuftrag>().FirstOrDefault();
                if (currentAuftrag != null)
                {
                    currentAuftrag.Auftragskurzbeschreibung = a.Auftragskurzbeschreibung;

                    //currentAuftrag.BAFA_ID = a.BAFA_ID;
                    //currentAuftrag.SMAuftrag_TCOM = a.SMAuftrag_TCOM;
                    //currentAuftrag.Status = new WMSTIStatus(a.Status);
                    //currentAuftrag.Teilauftragsfall_TI = a.Teilauftragsfall_TI;
                    //
                    //currentAuftrag.BAFA_betriebsbereit_korr = a.BAFA_betriebsbereit_korr;
                    //currentAuftrag.ONKZ = a.ONKZ;
                    //currentAuftrag.AsB = a.AsB;
                    //currentAuftrag.KD_Strasse = a.KD_Strasse;
                    //currentAuftrag.KD_HsNr = a.KD_HsNr;
                    //currentAuftrag.KD_Zusatz = a.KD_Zusatz;
                    //currentAuftrag.KD_PLZ = a.KD_PLZ;
                    //currentAuftrag.KD_Ort = a.KD_Ort;
                    //currentAuftrag.Mont_A_Strasse = a.Mont_A_Strasse;
                    //currentAuftrag.Mont_A_HsNr = a.Mont_A_HsNr;
                    //currentAuftrag.Mont_A_Zusatz_Str = a.Mont_A_Zusatz_Str;
                    //currentAuftrag.Mont_A_Ort = a.Mont_A_Ort;
                    //currentAuftrag.Langtext_Bemerkung_Vorsystem = a.Langtext_Bemerkung_Vorsystem;
                    if (a.projekt != null)
                    {
                        currentAuftrag.Projekt = a.projekt;
                    }
                    
                }
                
                else {
                    dba.WMSTIStatus = new WMSTIStatus("Neu");
                    dba.auftraggeber = "Telekom";
                    session.SaveOrUpdate(dba);
                }
            }
            tx.Commit();
            closeSession(session, tx);
        }

        public List<WMSTIStatus> getWMSTI()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();
            ICriteria crit = session.CreateCriteria<WMSTIStatus>();
            return (List<WMSTIStatus>)crit.List<WMSTIStatus>();
        }
        public List<Projekt> getProjekte()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<Projekt>();
            return (List<Projekt>)crit.List<Projekt>();                                   
        }
        public Dictionary<string, Projekt> getProjekteDictionary()
        {
            Dictionary<string, Projekt> dic_Projekte = new Dictionary<string, Projekt>();
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();


            ICriteria crit = session.CreateCriteria<Projekt>();
            List<Projekt> projekte = (List<Projekt>)crit.List<Projekt>();

            foreach (Projekt p in projekte)
            {
                dic_Projekte.Add(p.bezeichnung,p);
            }
            return dic_Projekte;
        }
        public List<Auftrag> checkDB(List<Auftrag> auftraege)
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            foreach (Auftrag a in auftraege)
            {
                a.SMAuftrag_TCOM=a.SMAuftrag_TCOM.Substring(3);
                DBAuftrag dba = new DBAuftrag(a, getWMSTI(), getProjekte());
                ICriteria crit = session.CreateCriteria<DBAuftrag>();
                crit.Add(Restrictions.Like("SMAuftrag_TCOM", dba.SMAuftrag_TCOM));
                DBAuftrag currentAuftrag = (DBAuftrag)crit.List<DBAuftrag>().FirstOrDefault();

                if (currentAuftrag!=null)
                {
                    a.inDB = true;
                }
                else { a.inDB = false; }
            }
            return auftraege;
        }

        /*private void getBearbeiter()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<Bearbeiter>();
            crit.Add(Restrictions.IsNotNull("bearbeiterVorname"));
            dbPDF.bearbeiter = (List<Bearbeiter>)crit.List<Bearbeiter>();
            dbPDF.dic_Bearbeiter = new Dictionary<string, Bearbeiter>();
            //Object in String umwandeln
            foreach (Bearbeiter an in dbPDF.bearbeiter)
            {
                dbPDF.dic_Bearbeiter.Add(an.bearbeiterVorname + " " + an.bearbeiterName, an);
            }


            closeSession(session, tx);
        }*/
    }
}
