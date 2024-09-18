namespace PresidentForm
{
    partial class Survey
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
            this.CitizenCheckBox = new System.Windows.Forms.CheckBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ResidencyLabel = new System.Windows.Forms.Label();
            this.ResidencyDial = new System.Windows.Forms.NumericUpDown();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.rebel = new System.Windows.Forms.CheckBox();
            this.termDial = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResidencyDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termDial)).BeginInit();
            this.SuspendLayout();
            // 
            // CitizenCheckBox
            // 
            this.CitizenCheckBox.AutoSize = true;
            this.CitizenCheckBox.Location = new System.Drawing.Point(22, 12);
            this.CitizenCheckBox.Name = "CitizenCheckBox";
            this.CitizenCheckBox.Size = new System.Drawing.Size(355, 24);
            this.CitizenCheckBox.TabIndex = 0;
            this.CitizenCheckBox.Text = "I am natural born citizen of the United States.";
            this.CitizenCheckBox.UseVisualStyleBackColor = true;
            this.CitizenCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(12, 48);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(75, 20);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Birthday: ";
            this.AgeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResidencyLabel
            // 
            this.ResidencyLabel.AutoSize = true;
            this.ResidencyLabel.Location = new System.Drawing.Point(12, 89);
            this.ResidencyLabel.Name = "ResidencyLabel";
            this.ResidencyLabel.Size = new System.Drawing.Size(499, 20);
            this.ResidencyLabel.TabIndex = 3;
            this.ResidencyLabel.Text = "How many years have you been a legal resident of the United States?";
            this.ResidencyLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ResidencyDial
            // 
            this.ResidencyDial.Location = new System.Drawing.Point(517, 83);
            this.ResidencyDial.Name = "ResidencyDial";
            this.ResidencyDial.Size = new System.Drawing.Size(120, 26);
            this.ResidencyDial.TabIndex = 4;
            this.ResidencyDial.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // birthday
            // 
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday.Location = new System.Drawing.Point(93, 43);
            this.birthday.MaxDate = new System.DateTime(2024, 9, 17, 0, 0, 0, 0);
            this.birthday.MinDate = new System.DateTime(1904, 9, 17, 0, 0, 0, 0);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(200, 26);
            this.birthday.TabIndex = 5;
            this.birthday.Value = new System.DateTime(2024, 9, 17, 0, 0, 0, 0);
            // 
            // rebel
            // 
            this.rebel.AutoSize = true;
            this.rebel.Location = new System.Drawing.Point(2, 137);
            this.rebel.Name = "rebel";
            this.rebel.Size = new System.Drawing.Size(318, 24);
            this.rebel.TabIndex = 6;
            this.rebel.Text = "I have reblled against the United States.";
            this.rebel.UseVisualStyleBackColor = true;
            // 
            // termDial
            // 
            this.termDial.Location = new System.Drawing.Point(405, 179);
            this.termDial.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.termDial.Name = "termDial";
            this.termDial.Size = new System.Drawing.Size(120, 26);
            this.termDial.TabIndex = 7;
            this.termDial.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "How many terms have you already served as President?";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 85);
            this.button1.TabIndex = 9;
            this.button1.Text = "Determine Presidential Eligibility";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(317, 344);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 10;
            this.result.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Survey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.termDial);
            this.Controls.Add(this.rebel);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.ResidencyDial);
            this.Controls.Add(this.ResidencyLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.CitizenCheckBox);
            this.Name = "Survey";
            this.Text = "Presidential Eligibility";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResidencyDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termDial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CitizenCheckBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label ResidencyLabel;
        private System.Windows.Forms.NumericUpDown ResidencyDial;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.CheckBox rebel;
        private System.Windows.Forms.NumericUpDown termDial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
    }
}

