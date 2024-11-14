using System;
class Laba3
{
    enum Type_schet
    {
        Teku,
        Sber,
    }
    struct Bank_Shcet()
    {
        public string number;
        public string type;
        public int balance;
        public void Print()
        {
            Console.WriteLine($"Номер: {number}, Тип: {type}, Баланс: {balance}");
        }
    }
    enum ВУЗ
    {
        КГУ,
        КАИ,
        КХТИ,
    }
    struct Jober
    {
        public string name;
        public ВУЗ ВУЗ;
        public void Print()
        {
            Console.WriteLine($"Имя: {name}, ВУЗ: {ВУЗ}");
        }
    }
    static void Main()
    {
        Console.WriteLine("3.1 Создать перечисление видов банковского счёта");
        Type_schet bank_schet = Type_schet.Sber;
        Console.WriteLine(bank_schet);

        Console.WriteLine("3.2 Создать структуру с инофрмацией о банковском счёте");
        Bank_Shcet person = new Bank_Shcet();
        person.number = "1234 5678 8765 4321";
        person.type = "Sber";
        person.balance = 1000000;
        person.Print();

        Console.WriteLine("dz 3.1 Создать перечисление Вузов и структуру работник");
        Jober jober = new Jober();
        jober.name = "Дмитрий";
        jober.ВУЗ = ВУЗ.КАИ;
        jober.Print();
    }
}


