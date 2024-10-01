using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    public class CurrencyUSD : Currency
    {
        public double exchange_rate_usd { get; } = 95;
        public double exchange_rate_eur { get; } = 103;
        public double exchange_rate_rub { get; } = 1;

        public CurrencyUSD(double v) : base(v) { }

        public CurrencyUSD(double v, double exchange_rate_usd, double ex_eur,
            double ex_rub) : base(v)
        {
            this.exchange_rate_usd = exchange_rate_usd;
            Value = v * this.exchange_rate_usd;
            this.exchange_rate_rub = ex_rub;
            this.exchange_rate_eur = ex_eur;
        }

        public static implicit operator CurrencyEUR(CurrencyUSD current_usd)
        {
            return new CurrencyUSD(current_usd.Value *
                current_usd.exchange_rate_usd / current_usd.exchange_rate_eur);
        }

        public static implicit operator CurrencyRUB(CurrencyUSD current_usd)
        {
            return new CurrencyRUB(current_usd.Value *
                current_usd.exchange_rate_rub / current_usd.exchange_rate_usd);
        }
    }
}
