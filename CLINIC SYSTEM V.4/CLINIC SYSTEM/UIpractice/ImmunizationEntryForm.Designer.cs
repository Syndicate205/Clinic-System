namespace UIpractice
{
    partial class ImmunizationEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImmunizationEntryForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shotNumberTextBox = new System.Windows.Forms.TextBox();
            this.reactionTextBox = new System.Windows.Forms.TextBox();
            this.vaccineCodeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vaccinceDataGridView = new System.Windows.Forms.DataGridView();
            this.VacCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacShot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.immunizationNumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabelBox = new System.Windows.Forms.Label();
            this.patientGroupBox = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.bDayTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.femaleNameTextBox = new System.Windows.Forms.TextBox();
            this.maleNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.patienceCodeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pCodeLabelBox = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.prepTextBox = new System.Windows.Forms.TextBox();
            this.immuTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayPrepTextBox = new System.Windows.Forms.TextBox();
            this.displayImmuTextBox = new System.Windows.Forms.TextBox();
            this.petientErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.immuNoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.weightErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.heightErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.shotErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.codeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transferButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinceDataGridView)).BeginInit();
            this.patientGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petientErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.immuNoErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shotErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.shotNumberTextBox);
            this.groupBox1.Controls.Add(this.reactionTextBox);
            this.groupBox1.Controls.Add(this.vaccineCodeTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.vaccinceDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(323, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 275);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vaccine Info";
            // 
            // shotNumberTextBox
            // 
            this.shotNumberTextBox.Location = new System.Drawing.Point(456, 28);
            this.shotNumberTextBox.Name = "shotNumberTextBox";
            this.shotNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.shotNumberTextBox.TabIndex = 8;
            this.shotNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shotNumberTextBox_KeyPress);
            // 
            // reactionTextBox
            // 
            this.reactionTextBox.Location = new System.Drawing.Point(123, 68);
            this.reactionTextBox.Name = "reactionTextBox";
            this.reactionTextBox.Size = new System.Drawing.Size(433, 26);
            this.reactionTextBox.TabIndex = 7;
            this.reactionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reactionTextBox_KeyPress);
            // 
            // vaccineCodeTextBox
            // 
            this.vaccineCodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.vaccineCodeTextBox.Location = new System.Drawing.Point(123, 31);
            this.vaccineCodeTextBox.Name = "vaccineCodeTextBox";
            this.vaccineCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.vaccineCodeTextBox.TabIndex = 6;
            this.vaccineCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vaccineInfoTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(360, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Shot Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(53, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Reaction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vaccine Code";
            // 
            // vaccinceDataGridView
            // 
            this.vaccinceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaccinceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VacCode,
            this.VacName,
            this.VacDesc,
            this.vacShot,
            this.reaction});
            this.vaccinceDataGridView.Location = new System.Drawing.Point(6, 100);
            this.vaccinceDataGridView.Name = "vaccinceDataGridView";
            this.vaccinceDataGridView.RowHeadersVisible = false;
            this.vaccinceDataGridView.Size = new System.Drawing.Size(559, 150);
            this.vaccinceDataGridView.TabIndex = 0;
            // 
            // VacCode
            // 
            this.VacCode.HeaderText = "Vaccince Code";
            this.VacCode.Name = "VacCode";
            this.VacCode.Width = 125;
            // 
            // VacName
            // 
            this.VacName.HeaderText = "Vaccine Name";
            this.VacName.Name = "VacName";
            this.VacName.Width = 125;
            // 
            // VacDesc
            // 
            this.VacDesc.HeaderText = "Vaccine Description";
            this.VacDesc.Name = "VacDesc";
            this.VacDesc.Width = 160;
            // 
            // vacShot
            // 
            this.vacShot.HeaderText = "Vaccine Shot";
            this.vacShot.Name = "vacShot";
            this.vacShot.Width = 120;
            // 
            // reaction
            // 
            this.reaction.HeaderText = "Reaction";
            this.reaction.Name = "reaction";
            // 
            // immunizationNumTextBox
            // 
            this.immunizationNumTextBox.Location = new System.Drawing.Point(217, 67);
            this.immunizationNumTextBox.Name = "immunizationNumTextBox";
            this.immunizationNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.immunizationNumTextBox.TabIndex = 11;
            this.immunizationNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.immunizationNumTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "IMMUNIZATION UPDATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "PERPETUAL SWCCOVR GENERAL HOSPITAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PEDIATRIC CLINICAL SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Immunization No.";
            // 
            // dateLabelBox
            // 
            this.dateLabelBox.AutoSize = true;
            this.dateLabelBox.BackColor = System.Drawing.Color.Transparent;
            this.dateLabelBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabelBox.Location = new System.Drawing.Point(736, 66);
            this.dateLabelBox.Name = "dateLabelBox";
            this.dateLabelBox.Size = new System.Drawing.Size(37, 18);
            this.dateLabelBox.TabIndex = 13;
            this.dateLabelBox.Text = "Date";
            // 
            // patientGroupBox
            // 
            this.patientGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.patientGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.patientGroupBox.Controls.Add(this.label19);
            this.patientGroupBox.Controls.Add(this.label18);
            this.patientGroupBox.Controls.Add(this.heightTextBox);
            this.patientGroupBox.Controls.Add(this.weightTextBox);
            this.patientGroupBox.Controls.Add(this.ageTextBox);
            this.patientGroupBox.Controls.Add(this.bDayTextBox);
            this.patientGroupBox.Controls.Add(this.genderTextBox);
            this.patientGroupBox.Controls.Add(this.femaleNameTextBox);
            this.patientGroupBox.Controls.Add(this.maleNameTextBox);
            this.patientGroupBox.Controls.Add(this.addressTextBox);
            this.patientGroupBox.Controls.Add(this.phoneTextBox);
            this.patientGroupBox.Controls.Add(this.patientNameTextBox);
            this.patientGroupBox.Controls.Add(this.label17);
            this.patientGroupBox.Controls.Add(this.label16);
            this.patientGroupBox.Controls.Add(this.label15);
            this.patientGroupBox.Controls.Add(this.label14);
            this.patientGroupBox.Controls.Add(this.label13);
            this.patientGroupBox.Controls.Add(this.label12);
            this.patientGroupBox.Controls.Add(this.label11);
            this.patientGroupBox.Controls.Add(this.label10);
            this.patientGroupBox.Controls.Add(this.patienceCodeTextBox);
            this.patientGroupBox.Controls.Add(this.label8);
            this.patientGroupBox.Controls.Add(this.label9);
            this.patientGroupBox.Controls.Add(this.pCodeLabelBox);
            this.patientGroupBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientGroupBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.patientGroupBox.Location = new System.Drawing.Point(12, 90);
            this.patientGroupBox.Name = "patientGroupBox";
            this.patientGroupBox.Size = new System.Drawing.Size(305, 382);
            this.patientGroupBox.TabIndex = 15;
            this.patientGroupBox.TabStop = false;
            this.patientGroupBox.Text = "Patient Info";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(265, 349);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 18);
            this.label19.TabIndex = 28;
            this.label19.Text = "cm.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(265, 322);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 18);
            this.label18.TabIndex = 27;
            this.label18.Text = "Kg.";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(111, 346);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(153, 26);
            this.heightTextBox.TabIndex = 26;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(111, 314);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(153, 26);
            this.weightTextBox.TabIndex = 25;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(111, 282);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ReadOnly = true;
            this.ageTextBox.Size = new System.Drawing.Size(153, 26);
            this.ageTextBox.TabIndex = 24;
            // 
            // bDayTextBox
            // 
            this.bDayTextBox.Location = new System.Drawing.Point(111, 252);
            this.bDayTextBox.Name = "bDayTextBox";
            this.bDayTextBox.ReadOnly = true;
            this.bDayTextBox.Size = new System.Drawing.Size(153, 26);
            this.bDayTextBox.TabIndex = 23;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(111, 220);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(153, 26);
            this.genderTextBox.TabIndex = 22;
            // 
            // femaleNameTextBox
            // 
            this.femaleNameTextBox.Location = new System.Drawing.Point(111, 188);
            this.femaleNameTextBox.Name = "femaleNameTextBox";
            this.femaleNameTextBox.Size = new System.Drawing.Size(153, 26);
            this.femaleNameTextBox.TabIndex = 21;
            // 
            // maleNameTextBox
            // 
            this.maleNameTextBox.Location = new System.Drawing.Point(111, 156);
            this.maleNameTextBox.Name = "maleNameTextBox";
            this.maleNameTextBox.Size = new System.Drawing.Size(153, 26);
            this.maleNameTextBox.TabIndex = 20;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(111, 124);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(153, 26);
            this.addressTextBox.TabIndex = 19;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(111, 92);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(153, 26);
            this.phoneTextBox.TabIndex = 18;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(111, 60);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(153, 26);
            this.patientNameTextBox.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 18);
            this.label17.TabIndex = 16;
            this.label17.Text = "Height";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 317);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 18);
            this.label16.TabIndex = 15;
            this.label16.Text = "Weight";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(73, 285);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "Age";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "Birthday";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Mother\'s Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Father\'s Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Telephone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Address";
            // 
            // patienceCodeTextBox
            // 
            this.patienceCodeTextBox.Location = new System.Drawing.Point(111, 28);
            this.patienceCodeTextBox.Name = "patienceCodeTextBox";
            this.patienceCodeTextBox.Size = new System.Drawing.Size(153, 26);
            this.patienceCodeTextBox.TabIndex = 8;
            this.patienceCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patienceCodeTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Patient Name";
            // 
            // pCodeLabelBox
            // 
            this.pCodeLabelBox.AutoSize = true;
            this.pCodeLabelBox.Location = new System.Drawing.Point(18, 31);
            this.pCodeLabelBox.Name = "pCodeLabelBox";
            this.pCodeLabelBox.Size = new System.Drawing.Size(87, 18);
            this.pCodeLabelBox.TabIndex = 2;
            this.pCodeLabelBox.Text = "Patient Code";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(336, 381);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 18);
            this.label20.TabIndex = 29;
            this.label20.Text = "Prepared By";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(323, 405);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 18);
            this.label21.TabIndex = 30;
            this.label21.Text = "Immunized By";
            // 
            // prepTextBox
            // 
            this.prepTextBox.Location = new System.Drawing.Point(425, 379);
            this.prepTextBox.Name = "prepTextBox";
            this.prepTextBox.Size = new System.Drawing.Size(153, 20);
            this.prepTextBox.TabIndex = 31;
            this.prepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prepTextBox_KeyPress);
            // 
            // immuTextBox
            // 
            this.immuTextBox.Location = new System.Drawing.Point(425, 405);
            this.immuTextBox.Name = "immuTextBox";
            this.immuTextBox.Size = new System.Drawing.Size(153, 20);
            this.immuTextBox.TabIndex = 32;
            this.immuTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.immuTextBox_KeyPress);
            // 
            // updateButton
            // 
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(379, 429);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(93, 40);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Save";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(478, 429);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(93, 38);
            this.clearButton.TabIndex = 34;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(577, 427);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 40);
            this.exitButton.TabIndex = 35;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayPrepTextBox
            // 
            this.displayPrepTextBox.BackColor = System.Drawing.Color.Silver;
            this.displayPrepTextBox.Location = new System.Drawing.Point(584, 379);
            this.displayPrepTextBox.Name = "displayPrepTextBox";
            this.displayPrepTextBox.ReadOnly = true;
            this.displayPrepTextBox.Size = new System.Drawing.Size(153, 20);
            this.displayPrepTextBox.TabIndex = 36;
            // 
            // displayImmuTextBox
            // 
            this.displayImmuTextBox.BackColor = System.Drawing.Color.Silver;
            this.displayImmuTextBox.Location = new System.Drawing.Point(584, 404);
            this.displayImmuTextBox.Name = "displayImmuTextBox";
            this.displayImmuTextBox.ReadOnly = true;
            this.displayImmuTextBox.Size = new System.Drawing.Size(153, 20);
            this.displayImmuTextBox.TabIndex = 37;
            // 
            // petientErrorProvider
            // 
            this.petientErrorProvider.ContainerControl = this;
            // 
            // immuNoErrorProvider
            // 
            this.immuNoErrorProvider.ContainerControl = this;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(779, 64);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker.TabIndex = 38;
            // 
            // weightErrorProvider
            // 
            this.weightErrorProvider.ContainerControl = this;
            // 
            // heightErrorProvider
            // 
            this.heightErrorProvider.ContainerControl = this;
            // 
            // shotErrorProvider
            // 
            this.shotErrorProvider.ContainerControl = this;
            // 
            // codeErrorProvider
            // 
            this.codeErrorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(676, 427);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(93, 40);
            this.transferButton.TabIndex = 40;
            this.transferButton.Text = "Home";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click_1);
            // 
            // ImmunizationEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 481);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.displayImmuTextBox);
            this.Controls.Add(this.displayPrepTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.immuTextBox);
            this.Controls.Add(this.prepTextBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.patientGroupBox);
            this.Controls.Add(this.dateLabelBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.immunizationNumTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ImmunizationEntryForm";
            this.Text = "Immunization Entry Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinceDataGridView)).EndInit();
            this.patientGroupBox.ResumeLayout(false);
            this.patientGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petientErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.immuNoErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shotErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox shotNumberTextBox;
        private System.Windows.Forms.TextBox reactionTextBox;
        private System.Windows.Forms.TextBox vaccineCodeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView vaccinceDataGridView;
        private System.Windows.Forms.TextBox immunizationNumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabelBox;
        private System.Windows.Forms.GroupBox patientGroupBox;
        private System.Windows.Forms.TextBox maleNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox patienceCodeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label pCodeLabelBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox bDayTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox femaleNameTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox prepTextBox;
        private System.Windows.Forms.TextBox immuTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox displayPrepTextBox;
        private System.Windows.Forms.TextBox displayImmuTextBox;
        private System.Windows.Forms.ErrorProvider petientErrorProvider;
        private System.Windows.Forms.ErrorProvider immuNoErrorProvider;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ErrorProvider weightErrorProvider;
        private System.Windows.Forms.ErrorProvider heightErrorProvider;
        private System.Windows.Forms.ErrorProvider shotErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacShot;
        private System.Windows.Forms.DataGridViewTextBoxColumn reaction;
        private System.Windows.Forms.ErrorProvider codeErrorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button transferButton;

    }
}