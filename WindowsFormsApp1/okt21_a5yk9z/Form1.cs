using okt21_a5yk9z.Entities;
using okt21_a5yk9z.MNBServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace okt21_a5yk9z
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();

            //init datagrid, combobox
            dataGridView1.DataSource = Rates;

            comboBox1.DataSource = Currencies;
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetCurrenciesRequestBody();

            var result = mnbService.GetCurrencies(request).GetCurrenciesResult;


            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement.FirstChild.ChildNodes)
            {
                Currencies.Add(element.InnerText);
            
            }

            //MessageBox.Show(result);


            RefreshData();
        }

        private void RefreshData() {
            Rates.Clear();

            ParseXML(InitService());

            PlotData();
        }

        private string InitService() {
            // A változó deklarációk jobb oldalán a "var" egy dinamikus változó típus.
            // A "var" változó az első értékadás pillanatában a kapott érték típusát veszi fel, és később nem változtatható.
            // Jelen példa első sora tehát ekvivalens azzal, ha a "var" helyélre a MNBArfolyamServiceSoapClient-t írjuk.
            // Ebben a formában azonban olvashatóbb a kód, és változtatás esetén elég egy helyen átírni az osztály típusát.



            var mnbService = new MNBArfolyamServiceSoapClient();



            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = comboBox1.SelectedItem.ToString(),
                startDate = dateTimePicker1.Value.ToString(), //datetimeok egybol mukodnek?
                endDate = dateTimePicker2.Value.ToString()
            };


            // Ebben az esetben a "var" a GetExchangeRates visszatérési értékéből kapja a típusát.
            // Ezért a response változó valójában GetExchangeRatesResponseBody típusú.
            var response = mnbService.GetExchangeRates(request);

            // Ebben az esetben a "var" a GetExchangeRatesResult property alapján kapja a típusát.
            // Ezért a result változó valójában string típusú.
            var result = response.GetExchangeRatesResult;

            //MessageBox.Show(result);

            return result;

        }

        private void ParseXML(string result) {
            // XML document létrehozása és az aktuális XML szöveg betöltése
            var xml = new XmlDocument();
            xml.LoadXml(result);


            // Végigmegünk a dokumentum fő elemének gyermekein
            foreach (XmlElement element in xml.DocumentElement)
            {

                // Létrehozzuk az adatsort és rögtön hozzáadjuk a listához
                // Mivel ez egy referencia típusú változó, megtehetjük, hogy előbb adjuk a listához és csak később töltjük fel a tulajdonságait
                var rate = new RateData();
                Rates.Add(rate);

                // Dátum
                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                // Valuta
                var childElement = (XmlElement)element.ChildNodes[0];

                if (childElement == null)
                    continue;
                rate.Currency = childElement.GetAttribute("curr");

                // Érték
                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        private void PlotData() {
            chart1.DataSource = Rates;

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chart1.Legends[0];
            legend.Enabled = false;

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
