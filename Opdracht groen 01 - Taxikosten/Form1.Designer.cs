namespace Opdracht_groen_01___Taxikosten
{
    partial class Form1
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
            this.textboxAfstand = new System.Windows.Forms.NumericUpDown();
            this.beginDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.eindDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.checkboxToeslag = new System.Windows.Forms.CheckBox();
            this.labelAfstand = new System.Windows.Forms.Label();
            this.labelBeginDatum = new System.Windows.Forms.Label();
            this.labelBeginTijd = new System.Windows.Forms.Label();
            this.labelRitprijs = new System.Windows.Forms.Label();
            this.labelEindDatum = new System.Windows.Forms.Label();
            this.beginTijdPicker = new System.Windows.Forms.DateTimePicker();
            this.eindTijdPicker = new System.Windows.Forms.DateTimePicker();
            this.textboxRitprijs = new System.Windows.Forms.TextBox();
            this.buttonBereken = new System.Windows.Forms.Button();
            this.labelEindtijd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textboxAfstand)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxAfstand
            // 
            this.textboxAfstand.Location = new System.Drawing.Point(156, 54);
            this.textboxAfstand.Name = "textboxAfstand";
            this.textboxAfstand.Size = new System.Drawing.Size(109, 22);
            this.textboxAfstand.TabIndex = 0;
            this.textboxAfstand.ValueChanged += new System.EventHandler(this.afstand_ValueChanged);
            // 
            // beginDatumPicker
            // 
            this.beginDatumPicker.Location = new System.Drawing.Point(156, 122);
            this.beginDatumPicker.Name = "beginDatumPicker";
            this.beginDatumPicker.Size = new System.Drawing.Size(233, 22);
            this.beginDatumPicker.TabIndex = 1;
            this.beginDatumPicker.ValueChanged += new System.EventHandler(this.beginDatumPicker_ValueChanged);
            // 
            // eindDatumPicker
            // 
            this.eindDatumPicker.Location = new System.Drawing.Point(158, 182);
            this.eindDatumPicker.Name = "eindDatumPicker";
            this.eindDatumPicker.Size = new System.Drawing.Size(231, 22);
            this.eindDatumPicker.TabIndex = 2;
            this.eindDatumPicker.ValueChanged += new System.EventHandler(this.eindDatumPicker_ValueChanged);
            // 
            // checkboxToeslag
            // 
            this.checkboxToeslag.AutoCheck = false;
            this.checkboxToeslag.AutoSize = true;
            this.checkboxToeslag.Location = new System.Drawing.Point(156, 232);
            this.checkboxToeslag.Name = "checkboxToeslag";
            this.checkboxToeslag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkboxToeslag.Size = new System.Drawing.Size(100, 21);
            this.checkboxToeslag.TabIndex = 5;
            this.checkboxToeslag.Text = "Toeslag j/n";
            this.checkboxToeslag.UseVisualStyleBackColor = true;
            // 
            // labelAfstand
            // 
            this.labelAfstand.AutoSize = true;
            this.labelAfstand.Location = new System.Drawing.Point(58, 54);
            this.labelAfstand.Name = "labelAfstand";
            this.labelAfstand.Size = new System.Drawing.Size(56, 17);
            this.labelAfstand.TabIndex = 6;
            this.labelAfstand.Text = "Afstand";
            // 
            // labelBeginDatum
            // 
            this.labelBeginDatum.AutoSize = true;
            this.labelBeginDatum.Location = new System.Drawing.Point(58, 122);
            this.labelBeginDatum.Name = "labelBeginDatum";
            this.labelBeginDatum.Size = new System.Drawing.Size(83, 17);
            this.labelBeginDatum.TabIndex = 7;
            this.labelBeginDatum.Text = "Begindatum";
            // 
            // labelBeginTijd
            // 
            this.labelBeginTijd.AutoSize = true;
            this.labelBeginTijd.Location = new System.Drawing.Point(407, 127);
            this.labelBeginTijd.Name = "labelBeginTijd";
            this.labelBeginTijd.Size = new System.Drawing.Size(62, 17);
            this.labelBeginTijd.TabIndex = 8;
            this.labelBeginTijd.Text = "Begintijd";
            // 
            // labelRitprijs
            // 
            this.labelRitprijs.AutoSize = true;
            this.labelRitprijs.Location = new System.Drawing.Point(58, 356);
            this.labelRitprijs.Name = "labelRitprijs";
            this.labelRitprijs.Size = new System.Drawing.Size(51, 17);
            this.labelRitprijs.TabIndex = 9;
            this.labelRitprijs.Text = "Ritprijs";
            // 
            // labelEindDatum
            // 
            this.labelEindDatum.AutoSize = true;
            this.labelEindDatum.Location = new System.Drawing.Point(66, 182);
            this.labelEindDatum.Name = "labelEindDatum";
            this.labelEindDatum.Size = new System.Drawing.Size(75, 17);
            this.labelEindDatum.TabIndex = 10;
            this.labelEindDatum.Text = "Einddatum";
            // 
            // beginTijdPicker
            // 
            this.beginTijdPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.beginTijdPicker.Location = new System.Drawing.Point(486, 122);
            this.beginTijdPicker.Name = "beginTijdPicker";
            this.beginTijdPicker.Size = new System.Drawing.Size(100, 22);
            this.beginTijdPicker.TabIndex = 3;
            this.beginTijdPicker.ValueChanged += new System.EventHandler(this.beginTijdPicker_ValueChanged);
            // 
            // eindTijdPicker
            // 
            this.eindTijdPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.eindTijdPicker.Location = new System.Drawing.Point(486, 182);
            this.eindTijdPicker.Name = "eindTijdPicker";
            this.eindTijdPicker.Size = new System.Drawing.Size(95, 22);
            this.eindTijdPicker.TabIndex = 4;
            this.eindTijdPicker.ValueChanged += new System.EventHandler(this.eindTijdPicker_ValueChanged);
            // 
            // textboxRitprijs
            // 
            this.textboxRitprijs.Location = new System.Drawing.Point(156, 356);
            this.textboxRitprijs.Name = "textboxRitprijs";
            this.textboxRitprijs.ReadOnly = true;
            this.textboxRitprijs.Size = new System.Drawing.Size(100, 22);
            this.textboxRitprijs.TabIndex = 7;
            // 
            // buttonBereken
            // 
            this.buttonBereken.Location = new System.Drawing.Point(156, 284);
            this.buttonBereken.Name = "buttonBereken";
            this.buttonBereken.Size = new System.Drawing.Size(123, 42);
            this.buttonBereken.TabIndex = 6;
            this.buttonBereken.Text = "Bereken prijs";
            this.buttonBereken.UseVisualStyleBackColor = true;
            this.buttonBereken.Click += new System.EventHandler(this.buttonBereken_Click);
            // 
            // labelEindtijd
            // 
            this.labelEindtijd.AutoSize = true;
            this.labelEindtijd.Location = new System.Drawing.Point(415, 182);
            this.labelEindtijd.Name = "labelEindtijd";
            this.labelEindtijd.Size = new System.Drawing.Size(54, 17);
            this.labelEindtijd.TabIndex = 15;
            this.labelEindtijd.Text = "Eindtijd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEindtijd);
            this.Controls.Add(this.buttonBereken);
            this.Controls.Add(this.textboxRitprijs);
            this.Controls.Add(this.eindTijdPicker);
            this.Controls.Add(this.beginTijdPicker);
            this.Controls.Add(this.labelEindDatum);
            this.Controls.Add(this.labelRitprijs);
            this.Controls.Add(this.labelBeginTijd);
            this.Controls.Add(this.labelBeginDatum);
            this.Controls.Add(this.labelAfstand);
            this.Controls.Add(this.checkboxToeslag);
            this.Controls.Add(this.eindDatumPicker);
            this.Controls.Add(this.beginDatumPicker);
            this.Controls.Add(this.textboxAfstand);
            this.Name = "Form1";
            this.Text = "Ritprijs berekenen";
            ((System.ComponentModel.ISupportInitialize)(this.textboxAfstand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown textboxAfstand;
        private System.Windows.Forms.DateTimePicker beginDatumPicker;
        private System.Windows.Forms.DateTimePicker eindDatumPicker;
        private System.Windows.Forms.CheckBox checkboxToeslag;
        private System.Windows.Forms.Label labelAfstand;
        private System.Windows.Forms.Label labelBeginDatum;
        private System.Windows.Forms.Label labelBeginTijd;
        private System.Windows.Forms.Label labelRitprijs;
        private System.Windows.Forms.Label labelEindDatum;
        private System.Windows.Forms.DateTimePicker beginTijdPicker;
        private System.Windows.Forms.DateTimePicker eindTijdPicker;
        private System.Windows.Forms.TextBox textboxRitprijs;
        private System.Windows.Forms.Button buttonBereken;
        private System.Windows.Forms.Label labelEindtijd;
    }
}

