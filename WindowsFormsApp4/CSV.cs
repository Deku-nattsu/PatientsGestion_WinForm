using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class CSV
    {
        private DataGridView datagrid;
        private string filepath;
        public CSV(DataGridView datagrid,string filepath)
        {
            this.datagrid = datagrid;
            this.filepath = filepath;
        }

        public void Save()
        {
            string csv = "sep=,\n"; // Fix formating in excel

            //Add the Header row for CSV file.
            foreach (DataGridViewColumn column in this.datagrid.Columns)
            {
                csv += column.HeaderText + ',';
            }

            //Add new line.
            csv += "\r\n";

            //Adding the Rows
            foreach (DataGridViewRow row in this.datagrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString().Replace(",", ";") + ',';
                }

                //Add new line.
                csv += "\r\n";
            }

            //Exporting to CSV.
            File.WriteAllText(this.filepath, csv, Encoding.UTF32);
        }
        public void Load()
        {
            this.datagrid.Rows.Clear();
            string delimiters = ",";

            using (TextFieldParser tfp = new TextFieldParser(this.filepath))
            {
                tfp.SetDelimiters(delimiters);
                tfp.ReadFields(); //skip The separator
                tfp.ReadFields(); //skip Column line
                while (!tfp.EndOfData)
                {
                    this.datagrid.Rows.Add(tfp.ReadFields());
                }
            }
        }
    }
}
