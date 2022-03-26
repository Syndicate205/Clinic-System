using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb; //Microsoft Access database file 
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIpractice
{
    public partial class EmployeeEntryForm : Form
    {
        public EmployeeEntryForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Q:\Database1.mdb";//pathfinder

            OleDbConnection thisConnection = new OleDbConnection(connectionString);

            string sql = "SELECT * FROM EMPLOEEFILE";

            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, connectionString);

            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            thisAdapter.Fill(thisDataSet, "EMPLOEEFILE");

            //DataRow thisRow = thisDataSet.Tables["EMPLOEEFILE"].NewRow();

            DataRow findRow = thisDataSet.Tables["EMPLOEEFILE"].Rows.Find(idNoTextBox.Text);
            if (findRow == null)
            {
                DataRow thisRow = thisDataSet.Tables["EMPLOEEFILE"].NewRow();
                thisRow["EMPIDNO"] = idNoTextBox.Text;
                thisRow["EMPFIRSTNAME"] = firstTextBox.Text;
                thisRow["EMPLASTNAME"] = lastTextBox.Text;
                thisRow["EMPADDRESS"] = addressTextBox.Text;
                thisRow["EMPCONTACT"] = contactTextBox.Text;
                thisDataSet.Tables["EMPLOEEFILE"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "EMPLOEEFILE");
                MessageBox.Show("Entries Recorded!");
            }
            else
            {
                MessageBox.Show("Duplicate Entries","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            //thisDataSet.Tables["EMPLOEEFILE"].Rows.Add(thisRow);
            //thisAdapter.Update(thisDataSet, "EMPLOEEFILE");
            //MessageBox.Show("Entries Recorded....");
        }
    }
}
