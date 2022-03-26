namespace UIpractice
{
    partial class EmployeeEntryForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.contactLabel = new System.Windows.Forms.Label();
            this.idNoLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.idNoTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.lastTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(359, 84);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 41);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(68, 145);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(64, 13);
            this.contactLabel.TabIndex = 1;
            this.contactLabel.Text = "Contact No.";
            // 
            // idNoLabel
            // 
            this.idNoLabel.AutoSize = true;
            this.idNoLabel.Location = new System.Drawing.Point(58, 22);
            this.idNoLabel.Name = "idNoLabel";
            this.idNoLabel.Size = new System.Drawing.Size(74, 13);
            this.idNoLabel.TabIndex = 2;
            this.idNoLabel.Text = "Employee ID#";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(87, 115);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // idNoTextBox
            // 
            this.idNoTextBox.Location = new System.Drawing.Point(138, 15);
            this.idNoTextBox.Name = "idNoTextBox";
            this.idNoTextBox.Size = new System.Drawing.Size(152, 20);
            this.idNoTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(139, 112);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(152, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(139, 145);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(152, 20);
            this.contactTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(139, 52);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(152, 20);
            this.firstTextBox.TabIndex = 9;
            // 
            // lastTextBox
            // 
            this.lastTextBox.Location = new System.Drawing.Point(139, 84);
            this.lastTextBox.Name = "lastTextBox";
            this.lastTextBox.Size = new System.Drawing.Size(152, 20);
            this.lastTextBox.TabIndex = 10;
            // 
            // EmployeeEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 175);
            this.Controls.Add(this.lastTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.idNoTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.idNoLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.saveButton);
            this.Name = "EmployeeEntryForm";
            this.Text = "Employee Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label idNoLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox idNoTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox lastTextBox;
    }
}