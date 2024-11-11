/*1.Выведите на экран информацию о каждом типе данных в виде:
Тип данных – максимальное значение – минимальное значение*/

Console.WriteLine("Задание 1");

Console.WriteLine("Тип данных – Максимальное значение – Минимальное значение");

Console.WriteLine($"byte    - {byte.MaxValue} - {byte.MinValue}");
Console.WriteLine($"sbyte   - {sbyte.MaxValue} - {sbyte.MinValue}");
Console.WriteLine($"short   - {short.MaxValue} - {short.MinValue}");
Console.WriteLine($"ushort  - {ushort.MaxValue} - {ushort.MinValue}");
Console.WriteLine($"int     - {int.MaxValue} - {int.MinValue}");
Console.WriteLine($"uint    - {uint.MaxValue} - {uint.MinValue}");
Console.WriteLine($"long    - {long.MaxValue} - {long.MinValue}");
Console.WriteLine($"ulong   - {ulong.MaxValue} - {ulong.MinValue}");
Console.WriteLine($"float   - {float.MaxValue} - {float.MinValue}");
Console.WriteLine($"double  - {double.MaxValue} - {double.MinValue}");
Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");

/*2.Напишите программу, в которой принимаются данные пользователя в виде имени,
города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
переменной, а затем распечатайте всю информацию в правильном формате.*/

Console.WriteLine("Задание 2");

Person person = new Person();
Console.WriteLine("Введите свое имя:");
person.name = Console.ReadLine();
Console.WriteLine("Введите ваш город:");
person.town = Console.ReadLine();
Console.WriteLine("Введите ваш возраст:");
person.age = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine("Введите ваш PIN:");
person.pin = Convert.ToInt32( Console.ReadLine() );
person.Print();



/*3.Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
строчные.*/

Console.WriteLine("Задание 3");

Console.WriteLine("Введите строку:");
string input = Console.ReadLine(); 

Invert invert = new Invert();
invert.line = input;
invert.Print();



/*4.Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
на экран.*/

Console.WriteLine("Задание 4");

/*5.Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.*/

Console.WriteLine("Задание 5");



/*6.Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с
различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
(процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде
структуры: наименование типа напитка и процент спирта.*/

Console.WriteLine("Задание 6");

struct Student
{
    public string surName;
    public string name;
    public int ID;
    public string birthDate;
    public string categoryOfAlcoholism;
    public int alcoholVolume;

}




struct Person
{
    public string name;
    public string town;
    public int age;
    public int pin;
    public void Print()
    {
        Console.WriteLine($"Имя - {name}, город - {town}, возраст - {age}, пин-код - {pin}");
    }
}

struct Invert
{
    public string line;
    public void Print()
    {
        char[] chars = line.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i]))
            {
                chars[i] = char.ToLower(chars[i]);
            }
            else if (char.IsLower(chars[i]))
            {
                chars[i] = char.ToUpper(chars[i]);
            }
            Console.Write(chars[i]);
        }


    }

}