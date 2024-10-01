using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    public class CurrencyEUR : Currency
    {
        public double exchange_rate_usd { get; } = 95;
        public double exchange_rate_eur { get; } = 103;
        public double exchange_rate_rub { get; } = 1;

        public CurrencyEUR(double v) : base(v) { }

        public CurrencyEUR(double v, double ex_usd, double exchange_rate_eur,
            double ex_rub) : base(v)
        {
            this.exchange_rate_eur = exchange_rate_eur;
            Value = v * this.exchange_rate_eur;
            this.exchange_rate_rub = ex_rub;
            this.exchange_rate_usd = ex_usd;
        }

        public static implicit operator CurrencyUSD(CurrencyEUR current_eur)
        {
            return new CurrencyUSD(current_eur.Value *
                current_eur.exchange_rate_eur / current_eur.exchange_rate_usd);
        }

        public static implicit operator CurrencyRUB(CurrencyEUR current_eur)
        {
            return new CurrencyRUB(current_eur.Value *
                current_eur.exchange_rate_eur / current_eur.exchange_rate_rub);
        }
    }
}
