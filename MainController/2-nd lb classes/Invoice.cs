using System;

namespace MainController._2_nd_lb_classes
{
    class Invoice
    {
        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public int Account { get; private set; }
        public string Customer { get; private set; }
        public string Provider { get; private set; }

        string[] goods = { "Клавиатура", "Монитор", "Флешка", "Телефон", "Ноутбук", "Планшет", "Плеер", "Мышь", "Блок питания", "Колонки" };
        static int [] quality = { 15, 20, 0, 2, 7, 10, 0, 30, 4, 2 };

        const double tax = 20; // НДС - 20%

        public void Price()
        {
            double[] price = { 300,3000,100,5000,20000,10000,2399.99,459.99,1499.99,2099.99};

            Console.WriteLine($"Выберите номер товара, который хотите заказать:");
            for (int i = 0; i < goods.Length; i++)
                Console.WriteLine($"{i + 1}. {goods[i]} по цене: {price[i]} UAH\t*Осталось в наличии {quality[i]} штук*");

            Console.Write("--> ");
            int n = Convert.ToInt32(Console.ReadLine());

            if ((quality[n - 1]-1)<0)
            {
                Console.WriteLine($"\nТовара {goods[n-1]} нет в наличии");
            }
            else
            {
                quality[n - 1]--;
                Console.WriteLine(
                    $"\nАккаунт: {Account}\n" +
                    $"Покупатель: {Customer}\n" +
                    $"Поставщик: {Provider}\n" +
                    $"Товар: {goods[n-1]}\n" +
                    $"Цена: {price[n-1]}\n" +
                    $"Цена с НДС: {(price[n-1]*tax/100)+price[n-1]}");
            }    
        }
    }
}
