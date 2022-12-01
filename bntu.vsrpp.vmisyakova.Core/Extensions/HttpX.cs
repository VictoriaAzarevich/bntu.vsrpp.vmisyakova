﻿using System.Collections.Generic;
using bntu.vsrpp.vmisyakova.Core.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace bntu.vsrpp.vmisyakova.Core.Extensions
{
    public class HttpX
    {
        static HttpClient httpClient = new HttpClient();

        public static Currency[] GetCurrencies()
        {
            string obj = null;

            HttpResponseMessage responseMessage = httpClient.
                GetAsync($"https://www.nbrb.by/api/exrates/currencies").Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                obj = responseMessage.Content.ReadAsStringAsync().Result;
                Currency[] currencies = JsonConvert.DeserializeObject<Currency[]>(obj);
                return currencies;
            }

            return null;
        }

        public static Rate[] GetRates(string path)
        {
            string obj = null;

            HttpResponseMessage responseMessage = httpClient.GetAsync(path).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                obj = responseMessage.Content.ReadAsStringAsync().Result;
                Rate[] currencies = JsonConvert.DeserializeObject<Rate[]>(obj);
                return currencies;
            }

            return null;
        }

        public static List<RateShort> GetRateDynamic(string path)
        {
            string obj = null;

            HttpResponseMessage responseMessage = httpClient.GetAsync(path).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                obj = responseMessage.Content.ReadAsStringAsync().Result;
                List<RateShort> rates = JsonConvert.DeserializeObject<List<RateShort>>(obj);
                return rates;
            }

            return null;
        }
    }
}
