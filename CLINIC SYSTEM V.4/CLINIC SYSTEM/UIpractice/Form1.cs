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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Q:\Database1.mdb";//pathfinder
            
            if(e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Dwight Gay");
                OleDbConnection thisConnection = new OleDbConnection(connectionString);

                string searchString = searchNameTextBox.Text;
                //string sql = "Select EMPIDNO, EMPFIRSTNAME, EMPLASTNAME FROM EMPLOEEFILE WHERE EMPLASTNAME LIKE 'D%'";
                string sql = "Select EMPIDNO, EMPFIRSTNAME, EMPLASTNAME FROM EMPLOEEFILE WHERE EMPLASTNAME LIKE '"+searchString+"%'";

                OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

                DataSet thisDataSet = new DataSet();
                //thisAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                thisDataAdapter.Fill(thisDataSet, "EMPLOEEFILE");

                employeeDataGridView.DataSource = thisDataSet.Tables["EMPLOEEFILE"];
            }//endif
        }
    }
}
