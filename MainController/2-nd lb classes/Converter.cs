using System;

namespace MainController._2_nd_lb_classes
{
    class Converter
    {
        public Converter(double USD,double EUR,double RUB,double UAH)
        {
            _usd = USD;
            _eur = EUR;
            _rub = RUB;
            _uah = UAH;
        }

        static double _usd;
        static double _eur;
        static double _rub;
        static double _uah;

        const double UAHtoUSD = 1/28.0000;
        const double UAHtoEUR = 1/32.9800;
        const double UAHtoRUB = 1/0.3630;

        public void ValueConverter()
        {
            Console.Write(
                "Выберите валюту для конвертации:\n" +
                "1.UAH\n" +
                "2.USD\n" +
                "3.EUR\n" +
                "4.RUB\n" +
                "--> ");
            int from = Convert.ToInt32(Console.ReadLine());

            Console.Write(
                "Выбирите в какую валюту произвести перевод:\n" +
                "1.UAH\n" +
                "2.USD\n" +
                "3.EUR\n" +
                "4.RUB\n" +
                "--> ");
            int to = Convert.ToInt32(Console.ReadLine());

            double temp_value; // Валюта для конвертации в UAH
            double result_value;
            double input_value;

            string from_value_name;
            string to_value_name;

            switch (from)
            {
                case 1:
                    input_value = _uah;
                    from_value_name = "UAH";
                    temp_value = _uah;
                    break;
                case 2:
                    input_value = _usd;
                    from_value_name = "USD";
                    temp_value = _usd / UAHtoUSD;
                    break;
                case 3:
                    input_value = _eur;
                    from_value_name = "EUR";
                    temp_value = _eur / UAHtoEUR;
                    break;
                case 4:
                    input_value = _rub;
                    from_value_name = "RUB";
                    temp_value = _rub / UAHtoRUB;
                    break;
                default:
                    input_value = 0;
                    from_value_name = "###";
                    temp_value = 0;
                    break;
            }

            switch (to)
            {
                case 1:
                    to_value_name = "UAH";
                    result_value = temp_value;
                    break;
                case 2:
                    to_value_name = "USD";
                    result_value = temp_value * UAHtoUSD;
                    break;
                case 3:
                    to_value_name = "EUR";
                    result_value = temp_value * UAHtoEUR;
                    break;
                case 4:
                    to_value_name = "RUB";
                    result_value = temp_value * UAHtoRUB;
                    break;
                default:
                    to_value_name = "###";
                    result_value = 0;
                    break;
            }

            Console.WriteLine($"Результат конвертации {input_value} {from_value_name} => {to_value_name} : {result_value} {to_value_name}");
        }

    }
}
