using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using bntu.vsrpp.vmisyakova.Core.Models;
using OxyPlot;
using OxyPlot.Series;
using bntu.vsrpp.vmisyakova.Core.Extensions;

namespace bntu.vsrpp.vmisyakova.lab2
{
    public partial class GraphBuilder : Form
    {
        List<Currency> currencies = new List<Currency>();
        List<RateShort> rateDynamic;
        List<DateTime> days = new List<DateTime>();
        List<decimal> rateDynamicValues = new List<decimal>();
        int currentRateId;
        string rateName;
        DateTime curDateTime;
        DateTime nextDateTime;
        List<Currency> foundCurrencies;
        List<Currency> foundCurrenciesChanged = new List<Currency>();

        public GraphBuilder(List<Rate> rates, List<Currency> currencies, List<string> rateNames)
        {
            InitializeComponent();
            dateTimePickerStart.MinDate = new DateTime(2016, 7, 1);
            dateTimePickerStart.MaxDate = DateTime.Today.Subtract(new TimeSpan(1, 0, 0, 0));
            dateTimePickerEnd.MinDate = new DateTime(2016, 7, 1);
            dateTimePickerEnd.MaxDate = DateTime.Today;
            this.currencies = currencies;
            rateDynamic = new List<RateShort>();
            cbCurrencies.Items.AddRange(rateNames.ToArray());
            cbCurrencies.SelectedIndex = 0;
        }

        private void DisplayResults()
        {
            int i = 1;
            PlotModel plotModel = new PlotModel();
            LineSeries lineSeries = new LineSeries();
            foreach (RateShort item in rateDynamic)
            {
                days.Add(item.Date);
                rateDynamicValues.Add((decimal)item.Cur_OfficialRate);
                lineSeries.Points.Add(new DataPoint(i, (double)item.Cur_OfficialRate));
                i++;
            }
            plotModel.Series.Add(lineSeries);
            plotView.Model = plotModel;
            lblMin.Text = "Min= " + string.Format("{0:0.0000}", rateDynamic.Min(a => a.Cur_OfficialRate));
            lblMax.Text = "Max= " + string.Format("{0:0.0000}", rateDynamic.Max(a => a.Cur_OfficialRate));
            lblAvg.Text = "Avg= " + string.Format("{0:0.0000}", rateDynamic.Average(a => a.Cur_OfficialRate));
        }

        private void btnBuildGraph_Click(object sender, EventArgs e)
        {
            rateDynamic.Clear();
            rateName = cbCurrencies.SelectedItem.ToString();
            foundCurrencies = currencies.FindAll(a => a.Cur_QuotName.Equals(rateName));
            foundCurrenciesChanged = currencies.FindAll(a => a.Cur_QuotName.Equals(rateName));

            foreach (Currency item in foundCurrencies)
            {
                if (item.Cur_DateEnd < dateTimePickerStart.Value)
                    foundCurrenciesChanged.Remove(item);
            }

            if (rateDynamicValues.Count > 0)
                rateDynamicValues.Clear();

            curDateTime = dateTimePickerStart.Value;
            nextDateTime = dateTimePickerEnd.Value;

            currentRateId = foundCurrenciesChanged[0].Cur_ID;

            for (; ; )
            {
                if (curDateTime.AddDays(365) < foundCurrenciesChanged.Find(a => a.
                        Cur_ID.Equals(currentRateId)).Cur_DateEnd)
                {

                    if (curDateTime.AddDays(365) < dateTimePickerEnd.Value)
                    {
                        nextDateTime = curDateTime.AddDays(365);
                    }

                    else
                    {
                        nextDateTime = dateTimePickerEnd.Value;
                    }
                }
                else
                    nextDateTime = foundCurrenciesChanged.Find(a => a.
                        Cur_ID.Equals(currentRateId)).Cur_DateEnd;

                rateDynamic.AddRange(HttpX.GetRateDynamic("https://www.nbrb.by/API/ExRates/Rates/Dynamics/" +
                    $"{currentRateId}?startDate={curDateTime.ToString("s")}" +
                    $"&endDate={nextDateTime.ToString("s")}").ToArray());

                curDateTime = nextDateTime.AddDays(1);

                if (nextDateTime.Equals(dateTimePickerEnd.Value))
                    break;

                if (curDateTime > foundCurrenciesChanged.Find(a => a.
                    Cur_ID.Equals(currentRateId)).Cur_DateEnd)
                {
                    if (foundCurrenciesChanged.Any(a => a.Cur_DateStart.Equals(curDateTime)))
                        currentRateId = foundCurrenciesChanged.Find(a => a.Cur_DateStart.Equals(curDateTime)).
                            Cur_ID;
                    else
                        break;
                }
            }

            DisplayResults();
        }
    }
}
