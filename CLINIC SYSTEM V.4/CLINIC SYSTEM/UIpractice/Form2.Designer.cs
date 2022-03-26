namespace UIpractice
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.immButton = new System.Windows.Forms.Button();
            this.consultButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // immButton
            // 
            this.immButton.BackColor = System.Drawing.Color.Transparent;
            this.immButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("immButton.BackgroundImage")));
            this.immButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.immButton.Location = new System.Drawing.Point(90, 165);
            this.immButton.Name = "immButton";
            this.immButton.Size = new System.Drawing.Size(60, 82);
            this.immButton.TabIndex = 0;
            this.immButton.UseVisualStyleBackColor = false;
            this.immButton.Click += new System.EventHandler(this.immButton_Click);
            // 
            // consultButton
            // 
            this.consultButton.BackColor = System.Drawing.Color.Transparent;
            this.consultButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("consultButton.BackgroundImage")));
            this.consultButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.consultButton.Location = new System.Drawing.Point(262, 165);
            this.consultButton.Name = "consultButton";
            this.consultButton.Size = new System.Drawing.Size(60, 82);
            this.consultButton.TabIndex = 1;
            this.consultButton.UseVisualStyleBackColor = false;
            this.consultButton.Click += new System.EventHandler(this.consultButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(163, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 51);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Location = new System.Drawing.Point(163, 273);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 51);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "SYSTEM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "CLINICAL ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(413, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.consultButton);
            this.Controls.Add(this.immButton);
            this.Name = "Form2";
            this.Text = "Clinical System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button immButton;
        private System.Windows.Forms.Button consultButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}