using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Einlesen
{
    public partial class WMSTIStatus
    {
        public virtual string id { get; set; }
        public virtual ISet<DBAuftrag> auftraege { get; set; }       
        
        public WMSTIStatus(string id)
        {
            this.id = id;
        }
        public WMSTIStatus() { }
    }
}
