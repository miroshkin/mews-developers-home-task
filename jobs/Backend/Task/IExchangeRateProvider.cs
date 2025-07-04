﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExchangeRateUpdater
{
    public interface IExchangeRateProvider
    {
        Task<IEnumerable<ExchangeRate>> GetExchangeRatesAsync<T>(IEnumerable<Currency> currencies);
    }
}