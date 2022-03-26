using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; //Microsoft Access Database
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIpractice
{
    public partial class ImmunizationEntryForm : Form
    {
        public ImmunizationEntryForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Q:\Database1.mdb";//pathfinder
        //KEYPRESS 
        private void patienceCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Linking the ACCESS and Visual Studio
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT * FROM PATIENTFILE";
                OleDbDataReader thisReader = thisCommand.ExecuteReader();
                bool found = false;
                while (thisReader.Read())
                {
                    if (thisReader["PATIENTCODE"].ToString() == patienceCodeTextBox.Text)
                    {
                        found = true;
                        patientNameTextBox.Text = thisReader["PATIENTFIRSTNAME"] +" "+ thisReader["PATIENTLASTNAME"].ToString();
                        addressTextBox.Text = thisReader["PATIENTADDRESS"].ToString();
                        maleNameTextBox.Text = thisReader["PATIENTFATHER"] + " " + thisReader["PATIENTLASTNAME"].ToString();
                        femaleNameTextBox.Text = thisReader["PATIENTMOTHER"] + " " + thisReader["PATIENTLASTNAME"].ToString();
                        phoneTextBox.Text = thisReader["PATIENTPHONE"].ToString();
                        genderTextBox.Text = thisReader["PATIENTGENDER"].ToString();
                        bDayTextBox.Text = thisReader["PATIENTBDAY"].ToString();
                        ageTextBox.Text = thisReader["PATIENTAGE"].ToString();
                    }
                }
                //Display Message if code !found
                if (found == false)
                {
                    MessageBox.Show("Patient code not found!");
                }
            }
        }
        int row;
        private void vaccineInfoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(vaccineCodeTextBox.Text == string.Empty)
                {
                    this.codeErrorProvider.SetError(vaccineCodeTextBox, "Please Enter Vaccination Code! ");
                }
                this.codeErrorProvider.SetError(vaccineCodeTextBox, "");
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                string searchString = vaccineCodeTextBox.Text;

                string sql = "Select VACCODE, VACNAME, VACDESC, REACTION, VACNUMSHOT FROM VACCINEFILE WHERE VACCODE LIKE '" + searchString + "'";
                OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

                DataSet thisDataSet = new DataSet();
                thisDataAdapter.Fill(thisDataSet, "VACCINEFILE");
                
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.InsertCommand = new OleDbCommand(sql, thisConnection);
               
                //Start of modification (dataGridView)   
                foreach (DataRow theRow in thisDataSet.Tables["VACCINEFILE"].Rows)
                {
                    row = vaccinceDataGridView.Rows.Add();
                    vaccinceDataGridView.Rows[row].Cells["VacCode"].Value = theRow["VACCODE"];
                    vaccinceDataGridView.Rows[row].Cells["VacName"].Value = theRow["VACNAME"];
                    vaccinceDataGridView.Rows[row].Cells["VacDesc"].Value = theRow["VACDESC"];
                    vaccinceDataGridView.Rows[row].Cells["vacShot"].Value = theRow["VACNUMSHOT"];
                }
            }//end of if
        }
        private void shotNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (shotNumberTextBox.Text == string.Empty)
                {
                    this.shotErrorProvider.SetError(shotNumberTextBox, "Please Enter Shot Number!");
                }
                else
                {
                    string searchString = vaccineCodeTextBox.Text;
                    OleDbConnection thisConnection = new OleDbConnection(connectionString);
                    thisConnection.Open();
                    OleDbCommand thisCommand1 = thisConnection.CreateCommand();
                    thisCommand1.CommandText = "SELECT * FROM VACCINEFILE WHERE VACCODE = '" + searchString + "'";
                    OleDbDataReader thisReader1 = thisCommand1.ExecuteReader();

                    if (thisReader1.Read())
                    {
                        if (Convert.ToInt16(thisReader1["VACNUMSHOT"].ToString()) <= Convert.ToInt16(shotNumberTextBox.Text))
                        {
                            MessageBox.Show("error");
                            return;
                        }
                        else
                        {
                            vaccineNumShot();
                        }
                    }
                }
            }
        }
        private void reactionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //int row = vaccinceDataGridView.Rows.Add();
                vaccinceDataGridView.Rows[row].Cells["reaction"].Value = reactionTextBox.Text;
            }
        }
        private void immunizationNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (immunizationNumTextBox.Text == string.Empty)
                {
                    this.immuNoErrorProvider.SetError(immunizationNumTextBox, "Please Enter Immunization Number! ");
                }
            }
        }
        private void prepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool found = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT * FROM EMPLOEEFILE WHERE EMPPOSITION LIKE 'Staff'";
                OleDbDataReader thisReader = thisCommand.ExecuteReader();
                while (thisReader.Read())
                {
                    if (thisReader["EMPIDNO"].ToString() == prepTextBox.Text)
                    {
                        found = true;
                        displayPrepTextBox.Text = thisReader["EMPFIRSTNAME"] +  " " + thisReader["EMPLASTNAME"].ToString();
                    }
                }
            }
        }
        private void immuTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool found = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT * FROM EMPLOEEFILE WHERE EMPPOSITION LIKE 'Doctor'";
                OleDbDataReader thisReader = thisCommand.ExecuteReader();
                while (thisReader.Read())
                {
                    if (thisReader["EMPIDNO"].ToString() == immuTextBox.Text)
                    {
                        found = true;
                        displayImmuTextBox.Text = thisReader["EMPFIRSTNAME"] + " " + thisReader["EMPLASTNAME"].ToString();
                    }
                }
            }
        }
        //Buttons 
        private void updateButton_Click(object sender, EventArgs e)
        {
            //Error Provider 
                if (patienceCodeTextBox.Text == string.Empty)
                {
                    patienceCodeTextBox.Focus();
                    petientErrorProvider.SetError(patienceCodeTextBox, "Field is Empty");
                
                }
                else if (immunizationNumTextBox.Text == string.Empty)
                {
                    immunizationNumTextBox.Focus();
                    immuNoErrorProvider.SetError(immunizationNumTextBox, "Field is Empty");
                }
            //Calling the Detail code and performing the Header Code 
                OleDbConnection thisConnection = new OleDbConnection(connectionString);

                string sql = "SELECT * FROM IMMUNIZATIONHEADERFILE";

                OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, connectionString);

                OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);

                DataSet thisDataSet = new DataSet();
                thisAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                thisAdapter.Fill(thisDataSet, "IMMUNIZATIONHEADERFILE");

           //For Immunization Header File
               DataRow findRow = thisDataSet.Tables["IMMUNIZATIONHEADERFILE"].Rows.Find(immunizationNumTextBox.Text);
                if (findRow == null)
                {
                    OleDbDataAdapter headerAdapter = new OleDbDataAdapter(sql, connectionString);
                    OleDbCommandBuilder headerBuilder = new OleDbCommandBuilder(headerAdapter);

                    headerAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    headerAdapter.Fill(thisDataSet, "IMMUNIZATIONHEADERFILE");

                    DataRow thisRow = thisDataSet.Tables["IMMUNIZATIONHEADERFILE"].NewRow();
                    thisRow["IMMHIMMUNO"] = immunizationNumTextBox.Text;
                    thisRow["IMMHDATE"] = dateTimePicker.Value;
                    thisRow["IMMHPATCODE"] = patienceCodeTextBox.Text;
                    //Error Provider
                    if (weightTextBox.Text == string.Empty)
                    {
                        immunizationNumTextBox.Focus();
                        weightErrorProvider.SetError(weightTextBox, "Field is Empty");
                    }
                    else
                    {
                        thisRow["IMMHPATWEIGHT"] = weightTextBox.Text;
                    }
                    if (heightTextBox.Text == string.Empty)
                    {
                        patienceCodeTextBox.Focus();
                        heightErrorProvider.SetError(heightTextBox, "Field is Empty");
                    }
                    else
                    {
                        thisRow["IMMHPATHEIGHT"] = heightTextBox.Text;
                    }

                    thisRow["IMMHPREPBY"] = displayPrepTextBox.Text;
                    thisRow["IMMHIMMUBY"] = displayImmuTextBox.Text;
                    thisDataSet.Tables["IMMUNIZATIONHEADERFILE"].Rows.Add(thisRow);
                    headerAdapter.Update(thisDataSet, "IMMUNIZATIONHEADERFILE");

                    MessageBox.Show("Entries Recorded");
                }
                if (findRow != null)
                {
                    MessageBox.Show("Immunuzation Number already Exist");
                }
                detailMethod();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Global / Not in Group Box
            immunizationNumTextBox.Clear();
            //dateTimePicker.Text = " ";
            prepTextBox.Clear();
            immuTextBox.Clear();
            vaccinceDataGridView.DataSource = "";
            displayPrepTextBox.Clear();
            displayImmuTextBox.Clear();

            //Patient Info
            patienceCodeTextBox.Clear();
            patientNameTextBox.Clear();
            phoneTextBox.Clear();
            addressTextBox.Clear();
            maleNameTextBox.Clear();
            femaleNameTextBox.Clear();
            genderTextBox.Clear();
            bDayTextBox.Clear();
            ageTextBox.Clear();
            weightTextBox.Clear();
            heightTextBox.Clear();

            //Vaccine Info
            vaccineCodeTextBox.Clear();
            shotNumberTextBox.Clear();
            reactionTextBox.Clear();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void transferButton_Click_1(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            this.Hide();
            newform.ShowDialog();
        }
        //METHODS
        public void detailMethod()
        {
            //string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Q:\Database1.mdb";
            OleDbConnection detailConnection = new OleDbConnection();
            detailConnection.ConnectionString = connectionString;
            detailConnection.Open();
            DataSet thisDataSetDetail = new DataSet();
            for (int row = 0; row < vaccinceDataGridView.Rows.Count - 1; row++)
            {
                string sql = @"Insert Into IMMUNIZATIONDETAILFILE (IMMDIMMUNINO, IMMDVACCODE, IMMDSHOTNUM, IMMDREACTION) values('" + immunizationNumTextBox.Text + "', '" + vaccinceDataGridView.Rows[row].Cells[0].Value + "', '" + vaccinceDataGridView.Rows[row].Cells[3].Value + "','" + vaccinceDataGridView.Rows[row].Cells[4].Value + "')";

                OleDbCommand thisCommand2 = detailConnection.CreateCommand();
                thisCommand2.CommandText = sql;
                thisCommand2.ExecuteNonQuery();
            }  
        }   
        private void vaccineNumShot()
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            thisConnection.Open();
            OleDbCommand thisCommand2 = thisConnection.CreateCommand();
            thisCommand2.CommandText = "SELECT * FROM VACCINEPATIENTFILE WHERE (VACVCODE = '" + vaccineCodeTextBox.Text + "')";
            OleDbDataReader thisReader2 = thisCommand2.ExecuteReader();
            if (thisReader2.Read())
            {
                string shotNum = shotNumberTextBox.Text;
                int a = Convert.ToInt16(thisReader2["VACPATSHOTNUM"].ToString());
                int b = Convert.ToInt16(shotNum);

                if (b <= a)
                {
                    MessageBox.Show("error");
                    return;
                }
                else
                {
                    vaccinceDataGridView.Rows[row].Cells["vacShot"].Value = shotNumberTextBox.Text;
                }
            }
        }
        public void validate()
        {

        }
        
    }
}




////////////////////////DETAIL ERROR CODE//////////////////////////////////////////
/*
                       thisRow["IMMDIMMUNINO"] = immunizationNumTextBox.Text;
                       thisRow["IMMDVACCODE"] = VacCode;
                       thisRow["IMMDSHOTNUM"] = x;
                       thisRow["IMMDREACTION"] = reaction;
                        * 
                   }
           /*
           OleDbConnection thisConnection = new OleDbConnection(connectionString);

           string sql = "SELECT * FROM IMMUNIZATIONDETAILFILE";

           OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, connectionString);

           OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);

           DataSet thisDataSet = new DataSet();
           thisAdapter.Fill(thisDataSet, "IMMUNIZATIONDETAILFILE");
            
           //Start
           DataColumn[] keys = new DataColumn[2];
           keys[0] = thisDataSet.Tables["IMMUNIZATIONDETAILFILE"].Columns["IMMDIMMUNINO"];
           keys[1] = thisDataSet.Tables["IMMUNIZATIONDETAILFILE"].Columns["IMMDVACCODE"];

           thisDataSet.Tables["IMMUNIZATIONDETAILFILE"].PrimaryKey = keys;

           String[] valuesToSearch = new String[2];
           valuesToSearch[0] = immunizationNumTextBox.Text;
           valuesToSearch[1] = vaccineCodeTextBox.Text;
           //End 
            
           //For Immunization Detail File
           DataRow findRow = thisDataSet.Tables["IMMUNIZATIONDETAILFILE"].Rows.Find(valuesToSearch);
           if (findRow == null)
           {
               DataRow thisRow = thisDataSet.Tables["IMMUNIZATIONDETAILFILE"].NewRow();
                
               //Error Provider
               if (shotNumberTextBox.Text == string.Empty)
               {
                   immunizationNumTextBox.Focus();
                   shotErrorProvider.SetError(shotNumberTextBox, "Field is Empty");
               }
               if (immunizationNumTextBox.Text == string.Empty)
               {
                   immunizationNumTextBox.Focus();
                   immuNoErrorProvider.SetError(immunizationNumTextBox, "Field is Empty");
               }
               else
               {
                   int x = Convert.ToInt32(vaccinceDataGridView.Rows[row].Cells["vacShot"].Value);
                   for (int forRow = 0; forRow < vaccinceDataGridView.Rows.Count - 1; forRow++)
                   {
                       string sql = "Insert Into IMMUNIZATIONDETAILFILE (IMMDIMMIHNO, IMMDVACCODE, IMMDSHOTNUM) values(" + immunizationNumTextBox.Text + ", " + vaccinceDataGridView.Rows[row].Cells[0].Value + ", " + vaccinceDataGridView.Rows[row].Cells[4].Value + ")";

                       OleDbCommand thisCommand2 = con.CreateCommand();
                       thisCommand2.CommandText = sql;
                       thisCommand2.ExecuteNonQuery();

                       /*
                       thisRow["IMMDIMMUNINO"] = immunizationNumTextBox.Text;
                       thisRow["IMMDVACCODE"] = VacCode;
                       thisRow["IMMDSHOTNUM"] = x;
                       thisRow["IMMDREACTION"] = reaction;
                        * 
                   }
               }
               //thisDataSet.Tables["IMMUNIZATIONDETAILFILE"].Rows.Add(thisRow);
               //thisAdapter.Update(thisDataSet, "IMMUNIZATIONDETAILFILE");
           }*/

            /*
             * //OleDbConnection thisConnection = new OleDbConnection(connectionString);
            
            //string sql = "SELECT * FROM IMMUNIZATIONDETAILFILE";
            
            //OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, connectionString);
            
            //OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            
            //DataSet thisDataSet = new DataSet();
            //thisAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //thisAdapter.Fill(thisDataSet, "IMMUNIZATIONDETAILFILE");

            ////For Immunization Header File
            //DataRow findRow = thisDataSet.Tables["IMMUNIZATIONDETAILFILE"].Rows.Find(immunizationNumTextBox.Text);
            //validate();
            //if (findRow == null)
            //{
            //    OleDbDataAdapter detailAdapter = new OleDbDataAdapter(sql, connectionString);
            //    OleDbCommandBuilder detailBuilder = new OleDbCommandBuilder(detailAdapter);

            //    detailAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //    detailAdapter.Fill(thisDataSet, "IMMUNIZATIONDETAILFILE");
                 
            //    DataRow thisRow = thisDataSet.Tables["IMMUNIZATIONDETAILFILE"].NewRow();
            //    for (int forRow = 0; forRow < vaccinceDataGridView.Rows.Count - 1; forRow++)
            //    {
            //        thisRow["IMMDIMMUNINO"] = immunizationNumTextBox.Text;
            //        thisRow["IMMDVACCODE"] = vaccinceDataGridView.Rows[row].Cells["VacCode"].Value;
            //        thisRow["IMMDSHOTNUM"] = vaccinceDataGridView.Rows[row].Cells["vacShot"].Value;
            //        thisRow["IMMDREACTION"] = vaccinceDataGridView.Rows[row].Cells["reaction"].Value;
            //    }
            //    thisDataSet.Tables["IMMUNIZATIONDETAILFILE"].Rows.Add(thisRow);
            //    detailAdapter.Update(thisDataSet, "IMMUNIZATIONDETAILFILE");

            //    MessageBox.Show("Details Recorded");
            
            MessageBox.Show("Detail Recorded");*/
////////////////////////SHOT NUMBER ERROR CODE//////////////////////////////////////////
/*
            if (e.KeyChar == (char)Keys.Enter && vaccinceDataGridView.Rows.Count != 0)
            {
                vaccinceDataGridView.Rows[0].Cells["vacShot"].Value = shotNumberTextBox.Text;
            }
            if (e.KeyChar == (char)Keys.Enter && vaccinceDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Code is Empty");
            }*/
////////////////////////IMMUNIZATION ERROR CODE//////////////////////////////////////////
    //else
    //{
    //    this.immuNoErrorProvider.SetError(immunizationNumTextBox, "");
    //    string sql = "SELECT * FROM IMMUNIZATIONDETAILFILE";
    //    OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, connectionString);
    //    OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
    //    DataSet thisDataSet = new DataSet();
    //    thisAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
    //    thisAdapter.Fill(thisDataSet, "IMMUNIZATIONDETAILFILE");
    //    DataRow findRow = thisDataSet.Tables["IMMUNIZATIONDETAILFILE"].Rows.Find(immunizationNumTextBox.Text);
    //    if (findRow != null)
    //    {
    //        MessageBox.Show("Immunuzation Number already Exist");
    //    }
    //}