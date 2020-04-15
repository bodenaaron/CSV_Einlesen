using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSV_Einlesen
{
    public partial class MainForm : Form
    {
        DBManager dbm = new DBManager();
        List<Auftrag> auftraege;
        string path;
        Read read = new Read();
        public MainForm()
        {            
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            reinitializeComponent();
        }

        private void reinitializeComponent()
        {
            cmb_projekt.DataSource = new BindingSource(dbm.getProjekteDictionary(), null);
            cmb_projekt.DisplayMember = "Key";
            cmb_projekt.ValueMember = "Value";
            cmb_projekt.SelectedItem = null;
            cmb_projekt.Click += new System.EventHandler(this.cmb_projekt_Clicked);
        }

        private void btn_open_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Alle|*|CSV|*.csv |Excel|*.xlsx";
            openFileDialog.Title = "CSV auswählen";
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            fillTable(read.read(path));
        }        
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_projekt.SelectedItem==null)
            {
                cmb_projekt.BackColor = Color.OrangeRed;
                return;
            }
            else { cmb_projekt.BackColor = Color.White; }
            List<Auftrag> dbAuftraege = new List<Auftrag>();
            foreach (DataGridViewRow row in table.Rows)
            {
                if (row.Cells[0].Value!=null&& (bool)row.Cells[0].Value)
                {
                    Auftrag currentObject = (Auftrag)row.DataBoundItem;
                    if (!currentObject.inDB)
                    {
                        currentObject.projekt = ((KeyValuePair<string, Projekt>)cmb_projekt.SelectedItem).Value;
                    }                    
                    dbAuftraege.Add(currentObject);
                }                
            }
            dbm.save(dbAuftraege);
            fillTable(read.read(path));
        }

        private void markRows()
        {
            foreach (DataGridViewRow row in table.Rows)
            {
                Auftrag currentObject = (Auftrag)row.DataBoundItem;
                if (!currentObject.inDB)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else { row.DefaultCellStyle.BackColor = Color.White; }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "eictronic_V1_1DataSet.tblProjekte". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.tblProjekteTableAdapter.Fill(this.eictronic_V1_1DataSet.tblProjekte);

        }

        private void fillTable(List<Auftrag> auftraege)
        {
            if (path == "")
            {
                return;
            }
            if (path.Contains(".xlsx"))
            {
                string output = Path.ChangeExtension(path, ".csv");
                ExcelFileHelper.SaveAsCsv(path, output);
                path = output;
            }

            auftraege = read.read(path);
            auftraege = auftraege.OrderBy(a => a.inDB).ToList();
            table.DataSource = auftraege;
            markRows();
            table.Columns["Auftragskurzbeschreibung"].DisplayIndex = 3;
            table.Columns["Auftragskurzbeschreibung"].Width = table.Columns["Auftragskurzbeschreibung"].GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);
        }

        private void cmb_projekt_Clicked(object sender, EventArgs e)
        {
            cmb_projekt.BackColor = Color.White;
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
