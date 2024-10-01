using Lab3_3;

/*Console.WriteLine("Enter the exchange rate of USD");
double usd_rate = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the exchange rate of EUR");
double eur_rate = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the exchange rate of RUB");
double rub_rate = Convert.ToDouble(Console.ReadLine());*/

CurrencyRUB rub1 = new CurrencyRUB(100/*, usd_rate, eur_rate, rub_rate*/);

CurrencyEUR eur1 = new CurrencyEUR(3/*, usd_rate, eur_rate, rub_rate*/);

rub1 = eur1;

eur1 = rub1;

CurrencyUSD usd1 = eur1;

Console.WriteLine(rub1.Value);
Console.WriteLine(eur1.Value);
Console.WriteLine(usd1.Value);
