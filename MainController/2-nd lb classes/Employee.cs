using System;

namespace MainController._2_nd_lb_classes
{
    class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        const double MinSalary = 10000; // Минимальная з/п
        const double Tax = 19.5; // 19,5 %
        const double IncreaceForExp = 10; // За каждые 3 года работы + 10 %
        const double IncreaceForPost = 35; //За повышение + 35 % к з/п

        public Employee(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public void GetInfo()
        {
            double salary=0;
            Console.Write(
                "Введите номер должности:\n" +
                "1.Продавец-консультант\n" +
                "2.Старший продавец\n" +
                "3.Менеджер\n" +
                "4.Старший менеджер\n" +
                "5.Зам. Директор\n" +
                "6.Директор\n" +
                "-->");
            string[] PostName = {"Продавец-консультант","Старший продавец","Менеджер","Старший менеджер","Зам. Директор","Директор"};
            int post = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите стаж работы: ");
            int experience = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i < post; i++)
            {
                if (post > 6)
                    break;
                salary = (MinSalary * i*IncreaceForPost / 100) + MinSalary;
            }

            int temp = 0;

            for(int i = 0; i <= experience; i += 3)
            {
                salary += temp*IncreaceForExp*salary/100;
                temp++;
            }

            Console.WriteLine(
                $"\nФамилия: {LastName}\n" +
                $"Имя: {Name}\n" +
                $"Должность: {PostName[post-1]}\n" +
                $"Оклад: {salary}\n" +
                $"Налоговый сбор: {salary*Tax/100}");
        }
    }
}
