using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddNewData3
{
    internal class Program
    {
       public static Random rnd = new Random();
        static void Main(string[] args)
        {
            //FileReader.ReadFile();

            
            int id = 0;
            string sqlExpression = string.Empty;

            //for (int i = 0; i < 30; i++)
            //	Console.Write($"\"{i.ToString()}\", ");
            //List<string> mark = new List<string>() { "BMW", "Mercedes", "NUVA", "LADA", "HYUNDAI", "NISSAN", "AUDI", "FORD", "HONDA", "JEEP", "MITSUBISHI", "SKODA" };
            //List<string> color = new List<string>() { "Красный", "Белый", "Синий", "Зеленый", "Серебристый", "Серый", "Черный", "Коричневый", "Бирюзовый", "Желтный" };
            List<string> num = new List<string>() { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29" };
            List<string> graid = new List<string>() { "junior", "middle", "senior" };
            List<string> names = new List<string>()
            { "Милана", "Максим", "Аделина", "Елена", "Роберт", "Марк", "Али", "Ульяна", "София", "Иван", "Владимир", "Илья", "Ян", "Валерий", "Сергей", "Иван", "Петр", "Даниил", "Денис", "Аарон", "Абигейл", "Адам", "Адриан", "Алана", "Алекс", "Алисия", "Алисса", "Аллен", "Эллисон", "Эндрю", "Анджела", "Анита", "Энтони", "Антуан", "Антуанетта", "Артур", "Одри", "Барбара", "Бенджамин", "Бетти", "Билл", "Бобби", "Бонни", "Брэндон", "Бренда", "Брайан", "Бриттани", "Брук", "Брюс", "Брайан", "Кейтлин", "Кэлвин", "Кэмерон", "Карен", "Карл", "Кэрол", "Кэролайн", "Кэрри", "Кэсси", "Чарльз", "Шарлотта", "Чейз", "Челси", "Крис", "Кристина", "Кристофер", "Синди", "Клэр", "Кларенс", "Кларк", "Клинтон", "Конни", "Кори", "Крейг", "Кристи", "Дэниел", "Даррен", "Дэвид", "Дебора", "Денис", "Деннис", "Дерек", "Диана", "Диана", "Дик", "Дональд", "Донна", "Дорис", "Дуглас", "Дрю", "Дастин", "Дуэйн", "Эдвард", "Эдвин", "Элейн", "Элизабет", "Эллиот", "Элмер", "Эльза", "Эмили", "Эмма", "Эрик", "Эрнест", "Этан", "Эвелин", "Эван", "Ева", "Фрэнк", "Фред", "Фредди", "Гэри", "Джин", "Дженнифер", "Джерри", "Джессика", "Джим", "Джоан", "Джо", "Джон", "Джонатан", "Джордан", "Джозеф", "Джошуа", "Джудит", "Джулия", "Джулиан", "Джун", "Джастин", "Карен", "Кейт", "Кэти", "Кейтлин", "Кейтлин", "Кейтлин", "Кен", "Кендалл" };
            List<string> sur_names = new List<string>() {
                "Иванов", "Петров", "Сидоров", "Козлов", "Васильев", "Соколов", "Попов", "Михайлов", "Новиков", "Федоров", "Кузнецов", "Смирнов", "Захаров", "Волков", "Лебедев", "Морозов", "Александров", "Ефремов", "Борисов", "Павлов", "Семенов", "Голубев", "Виноградов", "Дмитриев", "Куликов", "Макаров", "Егоров", "Григорьев", "Марков", "Кузнецов", "Топоро", "Котусов", "Кулагин", "Сидлеров", "Бочкарев", "Калчу", "Николаве", "Якунов", "Путин", "Звезда", "Победитель", "Ильин" };
            List<string> Deps = new List<string> { "Managers", "Administration", "DevOps", "Programmers", "Tech Support", "Sponsor" };
            List<string> City_2 = new List<string> { "Paris", "New York City", "Tokyo", "London", "Sydney", "Rio de Janeiro", "Cairo", "Mumbai", "Cape Town", "Toronto", "Barcelona", "Dubai", "Moscow", "Rome", "Singapore" };
            List<string> Plane = new List<string> { "Boeing 777", "Airbus A340", "Airbus A330", "Boeing 747", "Boeing 767", "Airbus A320", "TU-154", "UL-85" };
            List<string> Companies = new List<string> { "Аэрофлот", "S7 Airlines", "Азимут", "Utair ", "Победа", "Red Wings Airlines", "Qatar Airways", "Eurowings", "American Airlines" };
            List<string> randWords = new List<string> { "a", "b", "c", "d" };
            var City = new Dictionary<string, int>()
            {
                {"Республика Башкортостан", 02},
                {"Республика Алтай", 04},
                {"Республика Ингушетия", 06},
                {"Республика Калмыкия", 08},
                {"Республика Карелия", 10},
                {"Республика Марий Эл", 12},
                {"Республика Саха (Якутия)", 14},
                {"Республика Татарстан", 16},
                {"Удмуртская Республика", 18},
                {"Чувашская Республика", 21},
                {"Краснодарский край", 23},
                {"Приморский край", 25},
                {"Хабаровский край", 27},
                {"Архангельская область", 29},
                {"Белгородская область", 31},
                {"Владимирская область", 33},
                {"Вологодская область", 35},
                {"Ивановская область", 37},
                {"Калининградская область", 39},
                {"Камчатский край", 41},
                {"Кировская область", 43},
                {"Курганская область", 45},
                {"Ленинградская область", 47},
                {"Магаданская область", 49},
                {"Мурманская область", 51},
                {"Новгородская область", 53},
                {"Омская область", 55},
                {"Орловская область", 57},
                {"Пермский край", 59},
                {"Ростовская область", 61},
                {"Самарская область", 63},
                {"Сахалинская область", 65},
                {"Смоленская область", 67},
                {"Тульская область", 71},
                {"Ульяновская область", 73},
                {"Забайкальский край", 75},
                {"Москва", 77},
                {"Еврейская автономная область", 79},
                {"Луганская Народная Республика", 81},
                {"Ненецкий автономный округ", 83},
                {"Запорожская область", 85},
                {"Чукотский автономный округ", 87},
                {"Севастополь", 92},
                {"Чеченская республика", 95},
            };
            Dictionary<string, string> Cars = new Dictionary<string, string>()
            {
                { "Audi A4", "C" },
                { "BMW 5 Series", "C" },
                { "Mercedes-Benz E-Class", "E" },
                { "Toyota Camry", "C" },
                { "Honda Accord", "C" },
                { "Volkswagen Passat", "C" },
                { "Ford Mustang", "E" },
                { "Chevrolet Camaro", "E" },
                { "Dodge Challenger", "E" },
                { "Mazda MX-5 Miata", "E" },
                { "Toyota Supra", "E" },
                { "Nissan 370Z", "E" },
                { "Jeep Wrangler", "M" },
                { "Ford Bronco", "M" },
                { "Chevrolet Tahoe", "M" },
                { "GMC Yukon", "M" },
                { "Tesla Model S", "F" },
                { "Tesla Model 3", "F" },
            };
            Dictionary<string, int> Planes = new Dictionary<string, int>()
            {
                {"Boeing 777", 400 },
                {"Airbus A340", 359 },
                {"Airbus A330",268},
                { "Boeing 747",366},
                {"Boeing 767",275 },
                {"Airbus A320", 180 },
                { "TU-154",180},
                { "UL-85",350}
            };
            Dictionary<string, int> Categories = new Dictionary<string, int>
            {
                { "Молочные продукты",1},
                { "Бытовые продукты",2},
                { "Хлебные продукты",3},
                { "Чайные продукты",4},
                { "Кофейные продукты",5},
                { "Мясные продукты",6},
                { "Посуда",7},
                { "Фрукты",8},
                { "Овощи",9},
                { "Рыба и морепродукты",10}
            };

           List<string> Products = new List<string>() { "Молоко", "Икра", "Хлеб", "Яблоки", "Бананы", "Картофель", "Масло", "Сыр", "Колбаса", "Чай", "Кофе", "Йогурт", "Мед", "Макароны", "Рыба", "Мясо", "Сок", "Вино", "Пиво", "Чипсы" };

            Console.WriteLine("Введите число генерации");
            int count = Int32.Parse(Console.ReadLine());
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CTE_1;Integrated Security=True";
            //$"Data Source={sqlserver};Database={sqlDB};User Id={username};Password={password}"
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Успешное подлючение!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //int s4 = 0;
            Task task = new Task(() =>
            {
                for (id = 0; id < count; id++)
                {


                    sqlExpression = $"insert into OrderDetails values({id+1},{rnd.Next(1,37)},{rnd.Next(1,25)})";
                    Console.WriteLine($"{sqlExpression}");
                    //sqlExpression = $"insert into UserActivity values ({id},'{rnd.Next(2020, 2024)}{num[rnd.Next(1, 12)]}{num[rnd.Next(1,29)]}')";


                    //sqlExpression = $"insert into Employess values ('{names[rnd.Next(1, names.Count)]}','{sur_names[rnd.Next(1, sur_names.Count)]}','{rnd.Next(1970, 2000)}{num[rnd.Next(1, 12)]}{num[rnd.Next(1, 28)]}',{rnd.Next(1000, 5000)},'{Deps[rnd.Next(1, Deps.Count)]}')";
                    //sqlExpression = $"insert into Categories values('{Categories.ElementAt(id).Key}',{rnd.Next(2,15)})";
                    //sqlExpression = $"insert into Orders values ('{rnd.Next(500,10000)}')";
                    //sqlExpression = $"insert into Order_detail values ({id},{rnd.Next(0,2)})";
                    //sqlExpression = $"insert into Products_4 values('{Products[id]}',{rnd.Next(250,1500)})";
                    //sqlExpression = $"insert into Orders_4 values({id},'{rnd.Next(2022, 2024)}{num[rnd.Next(1, 12)]}{num[rnd.Next(1,28)]}',{rnd.Next(1,21)})";
                    //
                    //var c1 = Planes.ElementAt(rnd.Next(1, Planes.Count)).Key;//3|400
                    //var c2 = Planes[c1];
                    //sqlExpression = $"insert into Airplanes values ('{c1}','{rnd.Next(1990, 2022)}{num[rnd.Next(1, 12)]}{num[rnd.Next(1, 29)]}',{c2},'{rnd.Next(2022, 2024)}{num[rnd.Next(1, 12)]}{num[rnd.Next(1, 29)]}',{rnd.Next(1,1500)})";
                    //sqlExpression = $"insert into Pilots values ('{names[rnd.Next(1, names.Count)]}','{sur_names[rnd.Next(1, sur_names.Count)]}',{rnd.Next(25, 45)},{rnd.Next(1, 19)})";
                    //sqlExpression = $"insert into City values ('{City_2[id]}')";
                    //int a1 = rnd.Next(0, City_2.Count);
                    //int a2 = rnd.Next(0, City_2.Count);
                    //string city1 = City_2[rnd.Next(0, City_2.Count)];//2  150
                    //string city2 = City_2[rnd.Next(0, City_2.Count)];
                    //if (a1 != a2)
                    //{
                    //    sqlExpression = $"insert into Flying values ({a1},{a2},{rnd.Next(1, 174)},'{rnd.Next(2024, 2025)}{num[rnd.Next(1, 12)]}{num[rnd.Next(1, 29)]}',{rnd.Next(90, 270)},{rnd.Next(1, 149)})";
                    //    Console.WriteLine(sqlExpression);
                    //}
                    //else count++;




                    //int a = 0;
                    //while (true)
                    //{
                    //    a = rnd.Next(0, 1000);
                    //    if (a % 10 == 0)
                    //        break;
                    //}


                    //sqlExpression = $"insert into Employess_2 values ('{names[rnd.Next(0, names.Count)]}','{sur_names[rnd.Next(0, sur_names.Count)]}',{rnd.Next(1,6)})";//76
                    //var c1 = Math.Round(rnd.NextDouble() * 900, 2).ToString().Replace(",", ".");//76
                    //sqlExpression = $"insert into Salary values ({id+75},{c1})";
                    //sqlExpression = $"insert into Graid values ({id},'{graid[rnd.Next(0,3)]}')";//76
                    //sqlExpression = $"insert into Sales values ('{rnd.Next(2020, 2024)}{num[rnd.Next(1,12)]}{num[rnd.Next(1,29)]}',{rnd.Next(1,11)})";//76


                    //Console.WriteLine(sqlExpression);


                    //sqlExpression = $"insert into Employess values ('{names[rnd.Next(0, names.Count)]}','{sur_names[rnd.Next(0, sur_names.Count)]}')";//1-50
                    //var c1 = Math.Round(rnd.NextDouble() * 900, 2).ToString().Replace(",", "."); //4|150
                    //               //Console.WriteLine($"{c1}");
                    //sqlExpression = $"insert into Bonuses values ({rnd.Next(1, 50)},{c1},'{rnd.Next(2022, 2024)}{num[rnd.Next(1, 12)]}{num[rnd.Next(1,29)]}')";
                    //Console.WriteLine(sqlExpression);


                    //sqlExpression = $"insert into Customers values ('{names[rnd.Next(0, names.Count)]}','{sur_names[rnd.Next(0,sur_names.Count)]}','{rnd.Next(9999,999999)}')";//1|500

                    //sqlExpression = $"insert into City values ('{City_2[id]}')";//2|10

                    //var c1 = Cars.ElementAt(rnd.Next(0, Cars.Count)).Key;//3|400
                    //var c2 = Cars[c1];
                    //sqlExpression = $"insert into Cars values ('{c1}','{c2}','{rnd.Next(1000,100000)}','{GetMeNumber()}',{rnd.Next(2009,2024)})";

                    //var c1 = Math.Round(rnd.NextDouble() * 5, 2).ToString().Replace(",","."); //4|150
                    //sqlExpression = $"insert into Drivers values ('{names[rnd.Next(0, names.Count)]}','{sur_names[rnd.Next(0,sur_names.Count)]}',{rnd.Next(2,30)},{rnd.Next(21,65)},{c1})";

                    // var c1 = Math.Round(rnd.NextDouble() * 50, 2).ToString().Replace(",","."); //5|150
                    // sqlExpression = $"insert into Orders values ({rnd.Next(1,400)},{rnd.Next(1,150)},{rnd.Next(0,11)},{c1},{rnd.Next(0,2)},{rnd.Next(20, 1000)})";
                    //Console.WriteLine(sqlExpression);
                    //sqlExpression = $"insert into Active_drivers values ({rnd.Next(1, 150)},{rnd.Next(1, 400)},{rnd.Next(78, 226)})"; //6|500




                    ///////////////


                    //sqlExpression = $"insert into Passengers values ('{names[rnd.Next(0,names.Count)]} {sur_names[rnd.Next(0,sur_names.Count)]}')"; //1  500

                    //string city1 = City_2[rnd.Next(0,City_2.Count)];//2  150
                    //string city2 = City_2[rnd.Next(0, City_2.Count)];
                    //if(city1 != city2)
                    //{
                    //sqlExpression = $"insert into Trip values ('{Companies[rnd.Next(0, Companies.Count)]}','{Plane[rnd.Next(0,Plane.Count)]}','{city1}','{city2}')";
                    //}
                    //else count++

                    //sqlExpression = $"insert into Pass_in_trip values ({rnd.Next(0, 160)},{rnd.Next(0, 500)},'{rnd.Next(0,30)}{randWords[rnd.Next(0,randWords.Count)]}')"; //3 count+-300 (okolo 90 zapisey)

                    //sqlExpression = $"insert into Emps values ('{names[rnd.Next(0, names.Count)]}','{sur_names[rnd.Next(0, sur_names.Count)]}',{rnd.Next(1000, 10000)},'{Deps[rnd.Next(0,Deps.Count)]}')";
                    //sqlExpression = $"insert into People values ('{names[rnd.Next(0, names.Count)]}','{sur_names[rnd.Next(0, sur_names.Count)]}',{rnd.Next(0, 65)})";
                    //sqlExpression = $"insert into Customers values ('{names[rnd.Next(0,names.Count)]}')";
                    //sqlExpression = $"insert into Customers values ('{names[rnd.Next(0,names.Count)]}')";
                    //sqlExpression = $"insert into Orders values ({rnd.Next(0,200)},{rnd.Next(0,10000)})";
                    //sqlExpression = $"insert into Employees values ('{names[rnd.Next(0,names.Count)]}','{sur_names[rnd.Next(0, sur_names.Count)]}',{a},{rnd.Next(1,6)})";
                    ;



                    //SqlCommand command = new SqlCommand(sqlExpression, connection);
                    //try
                    //{
                    //    command.ExecuteNonQuery();
                    //    Console.WriteLine(sqlExpression);
                    //    s4++;
                    //}
                    //catch (Exception ex)
                    //{
                    //    //Console.WriteLine(ex.ToString());
                    //}

                }
                //Console.WriteLine($"\nДанные внесены! Подключение закарыватеся {s4}");
                connection.Close();
            });
            task.Start();
            Console.Write("Ввод данных! Это может занять некоторое время");
            int y = Console.CursorTop;
            while (task.IsCompleted == false)
                GetDots(y);
            //WaitConsole(Console.CursorTop);


            Console.Read();
        }
        private static string GetMeNumber()
        {
            List<string> words = new List<string>() {"A", "B", "C", "D", "E", "F", "G", "I", "Y", "M", "N", };
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{words[rnd.Next(0, words.Count)]}{rnd.Next(99, 999)}{words[rnd.Next(0, words.Count)]}{words[rnd.Next(0, words.Count)]}");
            return stringBuilder.ToString();
        }
        private static void GetDots(int y)
        {
            int time = 500;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(45, y);
            Console.Write(".");
            Thread.Sleep(time);
            Console.SetCursorPosition(46, y);
            Console.Write(".");
            Thread.Sleep(time);
            Console.SetCursorPosition(47, y);
            Console.Write(".");
            Thread.Sleep(time);
            Console.SetCursorPosition(48, y);
            Console.Write(".");
            Thread.Sleep(time);
            Console.SetCursorPosition(45, y);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(".");
            Console.Write(".");
            Console.Write(".");
            Console.Write(".");
        }
    }
}
