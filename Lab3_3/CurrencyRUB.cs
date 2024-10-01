using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    public class CurrencyRUB : Currency
    {
        public double exchange_rate_usd { get; } = 95;
        public double exchange_rate_eur { get; } = 103;
        public double exchange_rate_rub { get; } = 1;

        public CurrencyRUB(double v) : base(v) { }

        public CurrencyRUB(double v, double ex_usd, double ex_eur,
            double exchange_rate_rub) : base(v)
        {
            this.exchange_rate_rub = exchange_rate_rub;
            Value = v;
            this.exchange_rate_usd = ex_usd;
            this.exchange_rate_eur = ex_eur;
        }

        public static implicit operator CurrencyEUR(CurrencyRUB current_rub)
        {
            return new CurrencyEUR(current_rub.Value *
                current_rub.exchange_rate_rub / current_rub.exchange_rate_eur);
        }

        public static implicit operator CurrencyUSD(CurrencyRUB current_rub)
        {
            return new CurrencyUSD(
                current_rub.Value *
                current_rub.exchange_rate_rub / current_rub.exchange_rate_usd);
        }
    }
}
