using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using bntu.vsrpp.vmisyakova.Core.Models;
using bntu.vsrpp.vmisyakova.Core.Extensions;

namespace bntu.vsrpp.vmisyakova.lab2
{
    public partial class MainWindow : Form
    {
        List<Currency> currencies = new List<Currency>();
        List<Rate> rates = new List<Rate>();
        List<Rate> ratesDaily = new List<Rate>();
        Rate currentRate = new Rate();
        Rate targetRate = new Rate();


        public MainWindow()
        {
            InitializeComponent();
            DoRequests();
            AddDataToComboBoxes();
            cbCurrencyInput.SelectedIndex = 0;
            cbCurrencyOutput.SelectedIndex = 0;
        }

        private void DoRequests()
        {
            currencies.AddRange(HttpX.GetCurrencies());
            rates.AddRange(HttpX.GetRates(
                $"https://www.nbrb.by/api/exrates/rates?periodicity=0"));
            ratesDaily.AddRange(rates.ToArray());
            rates.AddRange(HttpX.GetRates(
                $"https://www.nbrb.by/api/exrates/rates?periodicity=1"));
        }

        private void AddDataToComboBoxes()
        {
            foreach (Currency item in this.currencies)
            {
                if (rates.Any(a => a.Cur_ID.Equals(item.Cur_ID)))
                {
                    cbCurrencyInput.Items.Add(item.Cur_Name);
                    cbCurrencyOutput.Items.Add(item.Cur_Name);
                }
            }

            cbCurrencyInput.Items.Add("Белорусский рубль");
            cbCurrencyOutput.Items.Add("Белорусский рубль");
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string currency;
            if (!cbCurrencyInput.SelectedItem.Equals(null) && !cbCurrencyOutput.SelectedItem.Equals(null) &&
                cbCurrencyOutput.Items.Contains(cbCurrencyInput.SelectedItem) &&
                cbCurrencyInput.Items.Contains(cbCurrencyOutput.SelectedItem))
            {
                currency = cbCurrencyInput.Text;
                cbCurrencyInput.SelectedItem = cbCurrencyOutput.SelectedItem;
                cbCurrencyOutput.SelectedIndex = cbCurrencyOutput.Items.IndexOf(currency);
            }
            if (!tbValueInput.Text.Equals("") && !tbValueOutput.Text.Equals(""))
                btnConvert_Click(null, null);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!tbValueInput.Text.Equals(""))
            {
                decimal valueInput = 0;
                decimal curRateValue = 0;
                decimal targetRateValue = 0;
                decimal curRateScale = 0;
                decimal targetRateScale = 0;

                if (tbValueInput.Text.Length > 0)
                    decimal.TryParse(tbValueInput.Text, out valueInput);

                if (!cbCurrencyInput.SelectedItem.Equals(null) && !cbCurrencyOutput.SelectedItem.Equals(null))
                {
                    if (cbCurrencyInput.SelectedItem.Equals("Белорусский рубль"))
                    {
                        curRateValue = 1;
                        curRateScale = 1;
                    }

                    else
                    {
                        curRateValue = (decimal)currentRate.Cur_OfficialRate;
                        curRateScale = currentRate.Cur_Scale;
                    }

                    if (cbCurrencyOutput.SelectedItem.Equals("Белорусский рубль"))
                    {
                        targetRateValue = 1;
                        targetRateScale = 1;
                    }
                    else
                    {
                        targetRateValue = (decimal)targetRate.Cur_OfficialRate;
                        targetRateScale = targetRate.Cur_Scale;
                    }

                    tbValueOutput.Text = string.Format("{0:0.0000}",(valueInput * curRateValue * targetRateScale /
                        targetRateValue / curRateScale));
                }
            }
            else
            {
                MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuildGraph_Click(object sender, EventArgs e)
        {
            List<string> rateNames = new List<string>();
            foreach (Rate rate in ratesDaily)
                rateNames.Add(currencies.Find(a => a.Cur_ID.Equals(rate.Cur_ID)).Cur_QuotName);
            rateNames.Remove("Белорусский рубль");
            GraphBuilder graphBuilder = new GraphBuilder(ratesDaily, currencies, rateNames);
            graphBuilder.Show();
        }

        private void cbCurrencyInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rateName;
            var curId = 0;
            List<Currency> foundCurrencies;

            if (!cbCurrencyInput.SelectedItem.Equals("Белорусский рубль"))
            {
                rateName = cbCurrencyInput.SelectedItem.ToString();

                foundCurrencies = currencies.FindAll(a => a.Cur_Name.Equals(rateName));
                foreach (Currency item in foundCurrencies)
                {
                    if (rates.Any(a => a.Cur_ID.Equals(item.Cur_ID)))
                    {
                        curId = item.Cur_ID;
                        break;
                    }
                }

                currentRate = rates.Find(a => a.Cur_ID.Equals(curId));
            }
            if (!tbValueInput.Text.Equals("") && !tbValueOutput.Text.Equals(""))
                btnConvert_Click(null, null);
        }

        private void cbCurrencyOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rateName;
            var curId = 0;
            List<Currency> foundCurrencies;

            if (!cbCurrencyOutput.SelectedItem.Equals("Белорусский рубль"))
            {
                rateName = cbCurrencyOutput.SelectedItem.ToString();

                foundCurrencies = currencies.FindAll(a => a.Cur_Name.Equals(rateName));
                foreach (Currency item in foundCurrencies)
                {
                    if (rates.Any(a => a.Cur_ID.Equals(item.Cur_ID)))
                    {
                        curId = item.Cur_ID;
                        break;
                    }
                }

                targetRate = rates.Find(a => a.Cur_ID.Equals(curId));
            }
            if (!tbValueInput.Text.Equals("") && !tbValueOutput.Text.Equals(""))
                btnConvert_Click(null, null);
        }
    }
}
