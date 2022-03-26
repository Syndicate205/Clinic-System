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
    public partial class ConsultationEntryForm : Form
    {
        public ConsultationEntryForm()
        {
            InitializeComponent();
        }
        //GLOGAL DECLARATION
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Q:\Database1.mdb";//pathfinder
        int row;
        private void ConsultationEntryForm_Load(object sender, EventArgs e)
        {
            consultaitonNoTextBox.MaxLength = 8;
            patienceCodeTextBox.MaxLength = 8;

            weightTextBox.MaxLength = 6;
            heightTextBox.MaxLength = 3;
            bodyTempTextBox.MaxLength = 4;

            diagCodeTextBox.MaxLength = 8;

            prepTextBox.MaxLength = 8;
            examTextBox.MaxLength = 8;
        }
////////////////////////////////////////////////////KEY PRESS///////////////////////////////////////////////////////////
        private void patienceCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) != true && e.KeyChar != 13 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT * FROM PATIENTFILE";
                OleDbDataReader thisReader = thisCommand.ExecuteReader();

                while (thisReader.Read())
                {
                    if (thisReader["PATIENTCODE"].ToString() == patienceCodeTextBox.Text && thisReader["PATSTATUS"].ToString() == "AC")
                    {
                        MessageBox.Show("Patient is active. Information will be Displayed!");
                        patientNameTextBox.Text = thisReader["PATIENTFIRSTNAME"] + " " + thisReader["PATIENTLASTNAME"].ToString();
                        addressTextBox.Text = thisReader["PATIENTADDRESS"].ToString();
                        maleNameTextBox.Text = thisReader["PATIENTFATHER"] + " " + thisReader["PATIENTLASTNAME"].ToString();
                        femaleNameTextBox.Text = thisReader["PATIENTMOTHER"] + " " + thisReader["PATIENTLASTNAME"].ToString();
                        phoneTextBox.Text = thisReader["PATIENTPHONE"].ToString();
                        genderTextBox.Text = thisReader["PATIENTGENDER"].ToString();
                        bDayTextBox.Text = thisReader["PATIENTBDAY"].ToString();
                        ageTextBox.Text = thisReader["PATIENTAGE"].ToString();
                    }
                    if (thisReader["PATIENTCODE"].ToString() != patienceCodeTextBox.Text && thisReader["PATSTATUS"].ToString() == "AC")
                    {
                        MessageBox.Show("Patient not active");
                        erase();
                    }
                }
            }
        }
        private void consultaitonNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            thisConnection.Open();
            OleDbCommand thisCommand = thisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT * FROM CONSULTATIONHEADERFILE";
            OleDbDataReader thisReader = thisCommand.ExecuteReader();

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (patienceCodeTextBox.Text == string.Empty || diagCodeTextBox.Text == string.Empty || consultaitonNoTextBox.Text == string.Empty ||
                    weightTextBox.Text == string.Empty || heightTextBox.Text == string.Empty || bodyTempTextBox.Text == string.Empty)
                {
                    errorProvider();
                }
                while (thisReader.Read())
                {
                    if (thisReader["CONHNO"].ToString() == consultaitonNoTextBox.Text)
                    {
                        //found = true;
                        MessageBox.Show("Code already exist! Please Input again");
                    }
                }
            }
            if (Char.IsDigit(e.KeyChar) != true && e.KeyChar != 13 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }  
        //row will be used here
        private void diagCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) != true && e.KeyChar != 13 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                //Error Provider
                if (patienceCodeTextBox.Text == string.Empty || diagCodeTextBox.Text == string.Empty || consultaitonNoTextBox.Text == string.Empty ||
                    weightTextBox.Text == string.Empty || heightTextBox.Text == string.Empty || bodyTempTextBox.Text == string.Empty)
                {
                    errorProvider();
                }
                string searchString = diagCodeTextBox.Text;

                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();

                string sql = "SELECT * FROM DIAGNOSISFILE WHERE DIAGCODE = '" + searchString + "'";
                OleDbDataAdapter thisDataAdapter = new OleDbDataAdapter(sql, thisConnection);

                DataSet thisDataSet = new DataSet();
                thisDataAdapter.Fill(thisDataSet, "CONSULTATIONDETAILFILE");
                
                foreach (DataRow theRow in thisDataSet.Tables["CONSULTATIONDETAILFILE"].Rows)
                {
                    if (diagnosisDataGridView != null)
                    {
                        if (Convert.ToString(diagnosisDataGridView.Rows[row].Cells["diagnosisCode"].Value) == diagCodeTextBox.Text)
                        {
                            MessageBox.Show("Diagnosis Code already exist in the dataGridView!");
                        }
                        else
                        {
                            diagnosisExist();
                            row = diagnosisDataGridView.Rows.Add();
                            diagnosisDataGridView.Rows[row].Cells["diagnosisCode"].Value = theRow["DIAGCODE"];
                            diagnosisDataGridView.Rows[row].Cells["descripiton"].Value = theRow["DIAGNAME"];
                            diagnosisDataGridView.Rows[row].Cells["statusColumn"].Value = theRow["DIAGSTATUS"];
                        }
                    }
                }
            }
        }
        private void noteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (noteTextBox.Text == "")
                {
                    if (diagnosisDataGridView.Rows[row].Cells["physicianNotes"].Value == null)
                    {
                        MessageBox.Show("Please Input a direction!");
                    }
                }
                else
                {
                    diagnosisDataGridView.Rows[row].Cells["physicianNotes"].Value = noteTextBox.Text;
                }
            }
        }
        private void referralTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT * FROM IMMUNIZATIONHEADERFILE ";
                OleDbDataReader thisReader = thisCommand.ExecuteReader();
                bool flag = false;
                while (thisReader.Read())
                {
                    if (thisReader["IMMHIMMUNO"].ToString() == referralTextBox.Text)
                    {
                        flag = true;
                        MessageBox.Show("Immunuzation Number is present. Information will be Displayed!");
                        patienceCodeTextBox.Text = thisReader["IMMHPATCODE"].ToString();

                        if (patienceCodeTextBox.Text != string.Empty)
                        {
                            weightTextBox.ReadOnly = true;
                            weightTextBox.BackColor = SystemColors.ActiveBorder;
                            heightTextBox.ReadOnly = true;
                            heightTextBox.BackColor = SystemColors.ActiveBorder;
                            displayRelatedNoPat();
                            weightTextBox.Text = thisReader["IMMHPATWEIGHT"].ToString();
                            heightTextBox.Text = thisReader["IMMHPATHEIGHT"].ToString();
                        }
                    }
                }
                if (referralTextBox.Text == string.Empty)
                {
                    referralTextBox.Text = "NULL";
                    referralTextBox.ReadOnly = true;
                    referralTextBox.TextAlign = HorizontalAlignment.Center;
                }
                else if (flag == false)
                {
                    MessageBox.Show("No records");
                    patienceCodeTextBox.Clear();
                    weightTextBox.ReadOnly = false;
                    weightTextBox.BackColor = SystemColors.Window;
                    heightTextBox.ReadOnly = false;
                    heightTextBox.BackColor = SystemColors.Window;
                    erase();
                }
            }
            if (Char.IsDigit(e.KeyChar) != true && e.KeyChar != 13 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void prepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) != true && e.KeyChar != 13 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT * FROM EMPLOEEFILE WHERE EMPPOSITION LIKE 'Nurse'";
                OleDbDataReader thisReader = thisCommand.ExecuteReader();
                while (thisReader.Read())
                {
                    if (thisReader["EMPIDNO"].ToString() != prepTextBox.Text)
                    {
                        MessageBox.Show("Invalid Employee!");
                        displayPrepTextBox.Clear();
                    }
                    else
                    {
                        displayPrepTextBox.Text = thisReader["EMPFIRSTNAME"] + " " + thisReader["EMPLASTNAME"].ToString();
                        MessageBox.Show("Employee is Authorized to examine");
                    }
                }
            }
        }
        private void examTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) != true && e.KeyChar != 13 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT * FROM EMPLOEEFILE WHERE EMPPOSITION LIKE 'Doctor'";
                OleDbDataReader thisReader = thisCommand.ExecuteReader();
                while (thisReader.Read())
                {
                    if (thisReader["EMPIDNO"].ToString() != examTextBox.Text)
                    {
                        MessageBox.Show("Invalid Employee!");
                        displayExamTextBox.Clear();
                    }
                    else
                    {
                        displayExamTextBox.Text = thisReader["EMPFIRSTNAME"] + " " + thisReader["EMPLASTNAME"].ToString();
                        MessageBox.Show("Employee is Authorized to examine");
                    }
                }
            }
        }
        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (patienceCodeTextBox.Text == string.Empty || diagCodeTextBox.Text == string.Empty || consultaitonNoTextBox.Text == string.Empty ||
                    weightTextBox.Text == string.Empty || heightTextBox.Text == string.Empty || bodyTempTextBox.Text == string.Empty)
                {
                    errorProvider();
                    if (Convert.ToDouble(weightTextBox.Text) == 0)
                    {
                        MessageBox.Show("Zero is a invalid number");
                    }
                }
            }
            if (Char.IsDigit(e.KeyChar) != true && e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Input a Numeric Value");
            }
        }
        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (patienceCodeTextBox.Text == string.Empty || diagCodeTextBox.Text == string.Empty || consultaitonNoTextBox.Text == string.Empty ||
                    weightTextBox.Text == string.Empty || heightTextBox.Text == string.Empty || bodyTempTextBox.Text == string.Empty)
                {
                    errorProvider();
                    if (Convert.ToDouble(heightTextBox.Text) == 0)
                    {
                        MessageBox.Show("Zero is a invalid number");
                    }
                }
            }
            if (Char.IsDigit(e.KeyChar) != true && e.KeyChar != 13 && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input a Numeric Value");
            }
        }
        private void bodyTempTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                double bodyTemp = Convert.ToDouble(bodyTempTextBox.Text);
                if (patienceCodeTextBox.Text == string.Empty || diagCodeTextBox.Text == string.Empty || consultaitonNoTextBox.Text == string.Empty ||
                    weightTextBox.Text == string.Empty || heightTextBox.Text == string.Empty || bodyTempTextBox.Text == string.Empty)
                {
                    errorProvider();
                    if (Convert.ToDouble(bodyTempTextBox.Text) == 0)
                    {
                        MessageBox.Show("Zero is a invalid number");
                    }
                }
                //if (bodyTemp == 37)
                //{
                //    MessageBox.Show("In Good Condition");
                //}
                //else if (bodyTemp > 37.5 && bodyTemp < 44)
                //{
                //    MessageBox.Show("Fever in effect");
                //}
                if(bodyTemp > 45)
                {
                    MessageBox.Show("Very High Fever");
                    bodyTempTextBox.Text = "";
                }
            }
            if (Char.IsDigit(e.KeyChar) != true && e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Input a Numeric Value");
            }
        }
///////////////////////////////////////////////////BUTTONS/////////////////////////////////////////////////////////////
        private void clearButton_Click(object sender, EventArgs e)
        {
            consultaitonNoTextBox.Clear();
            referralTextBox.Clear();
            displayExamTextBox.Clear();
            displayPrepTextBox.Clear();
            prepTextBox.Clear();
            examTextBox.Clear();

            //PATIENT INFO GROUP BOX
            patienceCodeTextBox.Clear();
            patientNameTextBox.Clear();
            addressTextBox.Clear();
            phoneTextBox.Clear();
            maleNameTextBox.Clear();
            femaleNameTextBox.Clear();
            genderTextBox.Clear();
            bDayTextBox.Clear();
            ageTextBox.Clear();
            weightTextBox.Clear();
            heightTextBox.Clear();
            bodyTempTextBox.Clear();

            //DIAGNOS INFO GROUP BOX
            diagCodeTextBox.Clear();
            noteTextBox.Clear();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void transferButton_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            this.Hide();
            newform.ShowDialog();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Calling the Detail code and performing the Header Code 
            OleDbConnection thisConnection = new OleDbConnection(connectionString);

            string sql = "SELECT * FROM CONSULTATIONHEADERFILE";

            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(sql, connectionString);

            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            thisAdapter.Fill(thisDataSet, "CONSULTATIONHEADERFILE");
            DataRow headerRow = thisDataSet.Tables["CONSULTATIONHEADERFILE"].Rows.Find(consultaitonNoTextBox.Text);
            if (headerRow == null)
            {
                DataRow thisRow = thisDataSet.Tables["CONSULTATIONHEADERFILE"].NewRow();
                //Error Provider 
                if (patienceCodeTextBox.Text == string.Empty || diagCodeTextBox.Text == string.Empty || consultaitonNoTextBox.Text == string.Empty ||
                    weightTextBox.Text == string.Empty || heightTextBox.Text == string.Empty || bodyTempTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Some Fields are Empty");
                    errorProvider();
                }
                else if (patienceCodeTextBox.Text != string.Empty || diagCodeTextBox.Text != string.Empty || consultaitonNoTextBox.Text != string.Empty ||
                    weightTextBox.Text != string.Empty || heightTextBox.Text != string.Empty || bodyTempTextBox.Text != string.Empty)
                {
                    thisRow["CONHNO"] = consultaitonNoTextBox.Text;
                    thisRow["CONPATWEIGHT"] = weightTextBox.Text;
                    thisRow["CONPATHEIGHT"] = heightTextBox.Text;
                    thisRow["CONPATBODYTEMP"] = bodyTempTextBox.Text;
                    thisRow["CONHIMMREF"] = referralTextBox.Text;
                    thisRow["CONHDATE"] = dateTimePicker.Value;
                    thisRow["CONPATCODE"] = patienceCodeTextBox.Text;
                    thisRow["CONHPREPBY"] = displayPrepTextBox.Text;
                    thisRow["CONHEXAMBY"] = displayExamTextBox.Text;
                    thisRow["CONHSTATUS"] = diagnosisDataGridView.Rows[row].Cells["statusColumn"].Value;
                    
                    detailMethod();

                    if (admissionCheckBox.Checked == true)
                    {
                        thisRow["CONHREFSLIPS"] = "AD";
                    }
                    if (labTestCheckBox.Checked == true)
                    {
                        thisRow["CONHREFSLIPS"] = "LT";
                    }
                    if (admissionCheckBox.Checked == true && labTestCheckBox.Checked == true)
                    {
                        thisRow["CONHREFSLIPS"] = "BT";
                    }
                    else
                    {
                        thisRow["CONHREFSLIPS"] = "NA";
                    }
                    thisDataSet.Tables["CONSULTATIONHEADERFILE"].Rows.Add(thisRow);
                    thisAdapter.Update(thisDataSet, "CONSULTATIONHEADERFILE");
                    MessageBox.Show("Recorded!");
                }
                else
                {
                    MessageBox.Show("Consultation No. is needed!");
                }
            }
        }
////////////////////////////////////////////////METHODS/////////////////////////////////////////////////////////////
        public void displayRelatedNoPat()
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            thisConnection.Open();
            OleDbCommand thisCommand = thisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT * FROM PATIENTFILE ";
            OleDbDataReader thisReader = thisCommand.ExecuteReader();

            while (thisReader.Read())
            {
                if (thisReader["PATIENTCODE"].ToString() == patienceCodeTextBox.Text)
                {
                    patientNameTextBox.Text = thisReader["PATIENTFIRSTNAME"] + " " + thisReader["PATIENTLASTNAME"].ToString();
                    addressTextBox.Text = thisReader["PATIENTADDRESS"].ToString();
                    maleNameTextBox.Text = thisReader["PATIENTFATHER"] + " " + thisReader["PATIENTLASTNAME"].ToString();
                    femaleNameTextBox.Text = thisReader["PATIENTMOTHER"] + " " + thisReader["PATIENTLASTNAME"].ToString();
                    phoneTextBox.Text = thisReader["PATIENTPHONE"].ToString();
                    genderTextBox.Text = thisReader["PATIENTGENDER"].ToString();
                    bDayTextBox.Text = thisReader["PATIENTBDAY"].ToString();
                    ageTextBox.Text = thisReader["PATIENTAGE"].ToString();
                }
            }
        }
        public void diagnosisExist()
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            thisConnection.Open();
            OleDbCommand thisCommand = thisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT * FROM DIAGNOSISFILE";
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                if (thisReader["DIAGCODE"].ToString() == diagCodeTextBox.Text)
                {
                    MessageBox.Show("Diagnosis Code Exist!");
                }
            }
        }
        public void erase()
        {
            patientNameTextBox.Clear();
            addressTextBox.Clear();
            phoneTextBox.Clear();
            maleNameTextBox.Clear();
            femaleNameTextBox.Clear();
            genderTextBox.Clear();
            bDayTextBox.Clear();
            ageTextBox.Clear();
            weightTextBox.Clear();
            heightTextBox.Clear();
            bodyTempTextBox.Clear();
        }
        public void errorProvider()
        {
            if (consultaitonNoTextBox.Text == string.Empty)
            {
                this.consultationErrorProvider.SetError(consultaitonNoTextBox, "Please Enter Consultation Number! ");
            }
            if (patienceCodeTextBox.Text == string.Empty)
            {
                patientErrorProvider.SetError(patienceCodeTextBox, "Please Enter Patient Code!");
            }
            if (diagCodeTextBox.Text == string.Empty)
            {
                this.diagnosisErrorProvider.SetError(diagCodeTextBox, "Please Enter Diagnosis Code! ");
            }
            if (weightTextBox.Text == string.Empty)
            {
                this.weightErrorProvider.SetError(weightTextBox, "Please Enter weight! ");
            }
            if (heightTextBox.Text == string.Empty)
            {
                this.heightErrorProvider.SetError(heightTextBox, "Please Enter height! ");
            }
            if (bodyTempTextBox.Text == string.Empty)
            {
                this.bodyTempErrorProvider.SetError(bodyTempTextBox, "Please Enter body temp value! ");
            }
            if (displayPrepTextBox.Text == string.Empty)
            {
                this.prepErrorProvider.SetError(displayPrepTextBox, "Please Enter authorized Code! ");
            }
            if (displayExamTextBox.Text == string.Empty)
            {
                this.examErrorProvider.SetError(displayExamTextBox, "Please Enter authorized Code! ");
            }
        }
        public void detailMethod()
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Q:\Database1.mdb";
            OleDbConnection detailConnection = new OleDbConnection();
            detailConnection.ConnectionString = connectionString;
            detailConnection.Open();
            DataSet thisDataSetDetail = new DataSet();

            //keyshit();
            for (int rows = 0; rows < diagnosisDataGridView.Rows.Count - 1; rows++)
            {
                string sql = @"Insert Into CONSULTATIONDETAILFILE (CONIDNO, CONDDIAGCODE, CONDNOTES, CONDSTATUS) values('" + consultaitonNoTextBox.Text + "', '" + diagnosisDataGridView.Rows[rows].Cells[0].Value + "', '" + diagnosisDataGridView.Rows[rows].Cells[2].Value + "', '" + diagnosisDataGridView.Rows[rows].Cells[3].Value + "')";

                OleDbCommand thisCommand2 = detailConnection.CreateCommand();
                thisCommand2.CommandText = sql;
                thisCommand2.ExecuteNonQuery();
            }

        }

        
    }
}
