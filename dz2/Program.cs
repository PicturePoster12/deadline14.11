using System;
using System.Text.RegularExpressions;

class Program
{
    struct Data()
    {
        public string name;
        public string city;
        public int age;
        public string PIN;
        public void Print()
        {
            Console.WriteLine($"Имя: {name}, Город: {city}, Возраст: {age}, Пин-код: {PIN}");
        }
    }
    struct Student()
    {
        public string surname;
        public string name;
        public string ID;
        public DateTime DOB;
        public char categoryOfAlchogol;
        public double kolvoNapitka;
    }
    struct Drinks()
    {
        public string nazvanie;
        public int procent;
    }
    static void Main()
    {
        /*Console.Write("1.");
        Console.WriteLine("Тип данных – максимальное значение – минимальное значение");
        Console.WriteLine($"byte – {byte.MaxValue} – {byte.MinValue}");
        Console.WriteLine($"sbyte – {sbyte.MaxValue} – {sbyte.MinValue}");
        Console.WriteLine($"short – {short.MaxValue} – {short.MinValue}");
        Console.WriteLine($"ushort – {ushort.MaxValue} – {ushort.MinValue}");
        Console.WriteLine($"int – {int.MaxValue} – {int.MinValue}");
        Console.WriteLine($"uint – {uint.MaxValue} – {uint.MinValue}");
        Console.WriteLine($"long – {long.MaxValue} – {long.MinValue}");
        Console.WriteLine($"ulong – {ulong.MaxValue} – {ulong.MinValue}");
        Console.WriteLine($"float – {float.MaxValue} – {float.MinValue}");
        Console.WriteLine($"double – {double.MaxValue} – {double.MinValue}");
        Console.WriteLine($"decimal – {decimal.MaxValue} – {decimal.MinValue}");

        Console.WriteLine("2.");
        try
        {
            Data data = new Data();
            Console.WriteLine("Введите имя:");
            data.name = Console.ReadLine();
            Console.WriteLine("Введите город:");
            data.city = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            data.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пин-код:");
            data.PIN = Console.ReadLine();
            data.Print();
        }
        catch(FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }

        Console.WriteLine("3. Замена регистра букв");
        Console.WriteLine("Введите строку");
        char[] str = Console.ReadLine().ToCharArray();
        string new_str = "";
        for (int i = 0; i < str.Length; ++i)
        {
            if (str[i].ToString() == str[i].ToString().ToLower())
            {
                new_str += str[i].ToString().ToUpper();
            }
            else
            {
                new_str += str[i].ToString().ToLower();
            }
        }
        Console.WriteLine(new_str);

        Console.WriteLine("4. Количество вхождений подстроки");
        Console.WriteLine("Введите строку");
        string stroka = Console.ReadLine();
        Console.WriteLine("Введите подстроку");
        string podstroka = Console.ReadLine();
        int count = Regex.Matches(stroka, Regex.Escape(podstroka)).Count;
        Console.WriteLine($"Подстрока {podstroka} входит в основную строку {count} раз");

        Console.WriteLine("5. Определить колияество бутылок");
        try
        {
            Console.WriteLine("Введите цену бутылки виски:");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку в Duty Free:");
            double salePrice = Convert.ToInt32(Console.ReadLine()) * 0.01;
            Console.WriteLine("Введите стоимость отпуска:");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            if (salePrice <= 0 | salePrice > 1)
            {
                Console.WriteLine("Неверная скидка");
            }
            else
            {
                double DutyFree = normPrice * (1 - salePrice);
                double economia = normPrice - DutyFree;
                int kolichestvo = (int)(holidayPrice / economia);
                Console.WriteLine($"Необходимо купить {kolichestvo} бутылок");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }*/

        Console.WriteLine("6. Посчитать объём выпитого, процент спирта");
        Student student1 = new Student()
        {   surname = "Иванов",
            name = "Иван",
            ID = "123",
            DOB = new DateTime(2001, 01, 01),
            categoryOfAlchogol = 'c',
            kolvoNapitka = 1
        };
        Student student2 = new Student()
        { surname = "Петров",
            name = "Петр",
            ID = "234",
            DOB = new DateTime(2002, 02, 02),
            categoryOfAlchogol = 'd',
            kolvoNapitka = 0.75, 
        };
        Student student3 = new Student() {
            surname = "Максимов",
            name = "Максим",
            ID = "345",
            DOB = new DateTime(2003, 03, 03),
            categoryOfAlchogol = 'a',
            kolvoNapitka = 1.5,
        };
        Student student4 = new Student() 
        {
            surname = "Михайлов",
            name = "Михаил",
            ID = "456",
            DOB = new DateTime(2004, 04, 04),
            categoryOfAlchogol = 'b',
            kolvoNapitka = 1.2,
        };
        Student student5 = new Student()
        {
            surname = "Алексеев",
            name = "Алексей",
            ID = "567",
            DOB = new DateTime(2005, 05, 05),
            categoryOfAlchogol = 'c',
            kolvoNapitka = 0.3,
        };
        Drinks beer = new Drinks()
        {
            nazvanie = "Пиво",
            procent = 5,

        };
        Drinks vodka = new Drinks()
        {
            nazvanie = "Водка",
            procent = 40,
        };
        Drinks juice = new Drinks()
        {
            nazvanie = "Сок",
            procent = 0,
        };
        double vsegoVypito = student1.kolvoNapitka + student2.kolvoNapitka + student3.kolvoNapitka + student4.kolvoNapitka + student5.kolvoNapitka;
        double vsegoAlchogol = (student1.kolvoNapitka * beer.procent * 0.01 + student2.kolvoNapitka * juice.procent * 0.01 + student3.kolvoNapitka * vodka.procent * 0.01 + student4.kolvoNapitka * vodka.procent * 0.01 + student5.kolvoNapitka * beer.procent * 0.01);
        Console.WriteLine($"Общий объём выпитого = {vsegoVypito}");
        Console.WriteLine($"Общий объём алкоголя = {vsegoAlchogol}");
        Console.WriteLine($"{student1.name} выпил {Math.Round(student1.kolvoNapitka / vsegoVypito * 100, 1)} %");
        Console.WriteLine($"{student2.name} выпил {Math.Round(student2.kolvoNapitka / vsegoVypito * 100,1)} %");
        Console.WriteLine($"{student3.name} выпил {Math.Round(student3.kolvoNapitka / vsegoVypito * 100,1)} %");
        Console.WriteLine($"{student4.name} выпил {Math.Round(student4.kolvoNapitka / vsegoVypito * 100,1)} %");
        Console.WriteLine($"{student5.name} выпил {Math.Round(student5.kolvoNapitka / vsegoVypito * 100,1)} %");
    }
}