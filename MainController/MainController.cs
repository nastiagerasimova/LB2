using System;
using MainController._2_nd_lb_classes;
using MainController._2_nd_lb_classes.Point_and_Figure;

namespace MainController
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] examples = { "Adress", "Rectangle", "Book", "Point and Figure", "User", "Converter", "Employee", "Invoice" };
            while (true)
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Список заданий");
                for (int i = 0; i < examples.Length; i++)
                    Console.WriteLine((i + 1) + ". " + examples[i]);
                Console.WriteLine(new string('-', 30));
                Console.Write("Введите номер задания: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(new string('-', 30));
                switch (n)
                {
                    case 1:
                        #region 1-е Задание
                        Adress MyAdress = new Adress(17044, "Ukraine", "Остер", "8 марта", 12, 1);
                        MyAdress.ShowInfo();
                        #endregion
                        break;
                    case 2:
                        #region 2-е Задание
                        Rectangle MyRectangle = new Rectangle(14.67, 156.4);

                        Console.WriteLine($"Perimeter: {MyRectangle.Perimeter}");
                        Console.WriteLine($"Area: {MyRectangle.Area}");
                        #endregion
                        break;
                    case 3:
                        #region 3-е Задание
                        Book MyBook = new Book(
                            new Title("Мор, ученик смерти"),
                            new Author("Терри Прачетт"),
                            new Content("Морт"));

                        MyBook.Show();
                        #endregion
                        break;
                    case 4:
                        #region 4-е Задание
                        Figure figure = new Figure(
                            new Point(4, 6, "A"),
                            new Point(4, 1, "B"),
                            new Point(27, 40, "C"),
                            new Point(41, 156, "D"),
                            new Point(-347, 97, "E"));
                        figure.Perimeter();
                        #endregion
                        break;
                    case 5:
                        #region 5-е Задание
                        User MyUser = new User("Twilight", "Nastia", "Vladimirovna", 18, "16.09.2020");
                        MyUser.ShowInfo();
                        #endregion
                        break;
                    case 6:
                        #region 6-е Задание
                        Converter converter = new Converter(7, 9, 10, 30);
                        converter.ValueConverter();
                        #endregion
                        break;
                    case 7:
                        #region 7-е Задание
                        Employee employee = new Employee("Владимир", "Пелевин");
                        employee.GetInfo();
                        #endregion
                        break;
                    case 8:
                        #region 8-е Задание
                        Invoice invoice = new Invoice(17044,"Nastia","Samsung" );
                        invoice.Price();
                        #endregion
                        break;
                    default:
                        Console.WriteLine("Введите другую цифру");
                        return;
                }
                Console.WriteLine(new string('-', 30));
                Console.Write(
                    $"Для продолжения нажмите ENTER\n" +
                    $"Для выхода введите -Q или -q \n--> ");
                string quit = Console.ReadLine();
                if (quit == "Q" || quit == "q")
                    break;
            }

        }
    }
}
