using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Einlesen
{
    public partial class Projekt
    {
        public virtual int id { get; set; }
        public virtual ISet<DBAuftrag> auftraege { get; set; }

        public virtual string bezeichnung { get; set; }

        public Projekt()
        {

        }
    }
}
