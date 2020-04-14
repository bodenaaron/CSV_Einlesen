using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Einlesen
{
    class Read
    {
        
        public List<Auftrag> read(string path)
        {
            DBManager dbm = new DBManager();
            var reader = new StreamReader(path, Encoding.Default);
            IEnumerable<Auftrag> records;
            var csv = new CsvReader(reader, CultureInfo.CurrentCulture);
            {
                csv.Configuration.Delimiter = ";";
                records= csv.GetRecords<Auftrag>();
            }
            List<Auftrag> auftraege = records.ToList();

            return dbm.checkDB(auftraege);
        }
    }
}
