using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace Opdracht_groen_01___Taxikosten
{
    /// <summary>
    /// Taxi ritprijs berekenen
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();

            beginTijdPicker.ShowUpDown = true;
            eindTijdPicker.ShowUpDown = true;

        }
        #endregion

        int afstand;
        DateTime beginTijd = DateTime.Now;
        DateTime eindTijd = DateTime.Now;
        DateTime beginDatum = DateTime.Now;
        DateTime eindDatum = DateTime.Now;
        TimeSpan ritDuurSpan;
        DateTime startLaagTarief = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
        DateTime eindLaagTarief = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
        double ritDuurMinutes = 0;
        float minuutTariefLaag = 0.25f;
        float minuutTariefHoog = 0.45f;
        float toeslagFactor = 1.00f;
        double minuutPrijsLaag = 0;
        double minuutPrijsHoog = 0;
        double ritPrijs = 0;
        
        private void afstand_ValueChanged(object sender, EventArgs e)
        {
            afstand = Convert.ToInt32(textboxAfstand.Value);
            Debug.WriteLine(afstand);
        }

        private void beginDatumPicker_ValueChanged(object sender, EventArgs e)
        {
            beginDatum = beginDatumPicker.Value;
            Debug.WriteLine(beginDatum);
        }

        private void eindDatumPicker_ValueChanged(object sender, EventArgs e)
        {
            eindDatum = eindDatumPicker.Value;
            Debug.WriteLine(eindDatum);
        }

        private void beginTijdPicker_ValueChanged(object sender, EventArgs e)
        {
            beginTijd = beginTijdPicker.Value;
            Debug.WriteLine(beginTijd);
        }

        public void eindTijdPicker_ValueChanged(object sender, EventArgs e)
        {
            eindTijd = eindTijdPicker.Value;
            Debug.WriteLine(eindTijd);
        }

        private void buttonBereken_Click(object sender, EventArgs e)
        {
            // Ritten beginnen en eindigen op dezelfde dag!

            // reset eventuele vorige waardes
            ritPrijs = 0;
            minuutPrijsLaag = 0;
            minuutPrijsHoog = 0;

            DateTime beginMoment = new DateTime(beginDatum.Year, beginDatum.Month, beginDatum.Day, 
                beginTijd.Hour, beginTijd.Minute, beginTijd.Second);
            DateTime eindMoment = new DateTime(eindDatum.Year, eindDatum.Month, eindDatum.Day, 
                eindTijd.Hour, eindTijd.Minute, eindTijd.Second);
            
            ritDuurSpan = eindMoment - beginMoment;
            // Maak double ritDuurMinutes van TimeSpan ritDuurSpan
            ritDuurMinutes = ritDuurSpan.TotalMinutes;

            Debug.WriteLine("ritDuurSpan = " + ritDuurSpan);
            Debug.WriteLine("ritDuurMinutes = " + ritDuurMinutes);

            // Check of de weekendtoeslag moet worden toegepast
            if (beginDatum.DayOfWeek == DayOfWeek.Friday && beginTijd.Hour >= 22 || 
                beginDatum.DayOfWeek == DayOfWeek.Saturday || 
                beginDatum.DayOfWeek == DayOfWeek.Sunday || 
                beginDatum.DayOfWeek == DayOfWeek.Monday && beginTijd.Hour <= 6)
            {
                toeslagFactor = 1.15f;
                Debug.WriteLine("Toeslag actief!");
                checkboxToeslag.Checked = true;
            }
            else
            {
                toeslagFactor = 1.00f;
                checkboxToeslag.Checked = false;
            }

            // Bereken tarief a.d.h.v. begin- en eindtijd. 5 mogelijkheden.

            // 1. Volledig in bereik (begin en eindig tussen 8:00 en 18:00)
            if (beginTijd.Hour >= 8 && beginTijd.Hour < 18 && eindTijd.Hour < 18)
            {
                minuutPrijsLaag = ritDuurMinutes * minuutTariefLaag;
                Debug.WriteLine("1. minuutPrijsLaag = " + minuutPrijsLaag);
            }
            // 2. Volledig buiten bereik VOOR, of volledig buiten bereik NA (begin en eindig voor 8:00 óf na 18:00)
            else if (beginTijd.Hour < 8 && eindTijd.Hour < 8 || beginTijd.Hour >= 18 && eindTijd.Hour >= 18)
            {
                minuutPrijsHoog = ritDuurMinutes * minuutTariefHoog;
                Debug.WriteLine("2. minuutPrijsHoog = " + minuutPrijsHoog);
            }
            // 3. Begin buiten, eindig in (begin voor 8:00, eindig tussen 8:00 en 18:00)
            else if (beginTijd.Hour < 8 && eindTijd.Hour >= 8 && eindTijd.Hour < 18 )
            {
                // bereken tijd t/m 8:00
                TimeSpan ritDuurBuiten = startLaagTarief - beginTijd;
                // zet TimeSpan om naar minuten
                double ritDuurBuitenMin = ritDuurBuiten.TotalMinutes;
                minuutPrijsHoog = ritDuurBuitenMin * minuutTariefHoog;
                Debug.WriteLine("3. minuutPrijsHoog = " + minuutPrijsHoog);

                // bereken resterende rit tijd
                TimeSpan ritDuurBinnen = ritDuurSpan - ritDuurBuiten;
                // zet TimeSpan om naar minuten
                double ritDuurBinnenMin = ritDuurBinnen.TotalMinutes;
                minuutPrijsLaag = ritDuurBinnenMin * minuutTariefLaag;
                Debug.WriteLine("3. minuutPrijsLaag = " + minuutPrijsLaag);
            }
            // 4. Begint in, eindig buiten (begin tussen 8:00 en 18:00, eindig na 18:00)
            else if (beginTijd.Hour >= 8 && beginTijd.Hour < 18 && eindTijd.Hour >= 18)
            {
                // bereken tijd tot 18:00
                TimeSpan ritDuurBinnen = eindLaagTarief - beginTijd;
                // zet TimeSpan om naar minuten
                double ritDuurBinnenMin = ritDuurBinnen.TotalMinutes;
                minuutPrijsLaag = ritDuurBinnenMin * minuutTariefLaag;
                Debug.WriteLine("4. minuutPrijsLaag = " + minuutPrijsLaag);

                // bereken resterende rit tijd
                TimeSpan ritDuurBuiten = ritDuurSpan - ritDuurBinnen;
                // zet TimeSpan om naar minuten
                double ritDuurBuitenMin = ritDuurBuiten.TotalMinutes;
                minuutPrijsHoog = ritDuurBuitenMin * minuutTariefHoog;
                Debug.WriteLine("4. minuutPrijsHoog = " + minuutPrijsHoog);
            }
            // 5. Begint voor, eindig na (begin voor 8:00, eindig na 18:00)
            else if (beginTijd.Hour < 8 && eindTijd.Hour >= 18)
            {
                // bereken tijd t/m 8:00
                TimeSpan ritDuurBuitenVoor = startLaagTarief - beginTijd;
                // zet TimeSpan om naar minuten
                double ritDuurBuitenVoorMin = ritDuurBuitenVoor.TotalMinutes;
                minuutPrijsHoog = ritDuurBuitenVoorMin * minuutTariefHoog;
                Debug.WriteLine("5. minuutPrijsHoog = " + minuutPrijsHoog);

                // bereken tijd na 18:00
                TimeSpan ritDuurBuitenNa = eindTijd - eindLaagTarief;
                // zet TimeSpan om naar minuten
                double ritDuurBuitenNaMin = ritDuurBuitenNa.TotalMinutes;
                minuutPrijsHoog += ritDuurBuitenNaMin * minuutTariefHoog;
                Debug.WriteLine("5. minuutPrijsHoog = " + minuutPrijsHoog);

                // bereken resterende rit tijd
                TimeSpan ritDuurBinnen = ritDuurSpan - (ritDuurBuitenVoor + ritDuurBuitenNa);
                // zet TimeSpan om naar minuten
                double ritDuurBinnenMin = ritDuurBinnen.TotalMinutes;
                minuutPrijsLaag = ritDuurBinnenMin * minuutTariefLaag;
                Debug.WriteLine("5. minuutPrijsLaag = " + minuutPrijsLaag);
            }

            berekenPrijs();

        }

        private void berekenPrijs()
        {
            ritPrijs = (minuutPrijsLaag + minuutPrijsHoog + afstand) * toeslagFactor;
            ritPrijs = Math.Round(ritPrijs, 2);
            textboxRitprijs.Text = ritPrijs.ToString("c", CultureInfo.CreateSpecificCulture("nl-NL"));
            Debug.WriteLine("ritPrijs: " + ritPrijs);
        }

    }
}
