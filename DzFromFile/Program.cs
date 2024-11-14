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
person.age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваш PIN:");
person.pin = Convert.ToInt32(Console.ReadLine());
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

Console.WriteLine("Введите строку:");
string str = Console.ReadLine();

Console.WriteLine("Введите подстроку:");
string substr = Console.ReadLine();

int cntOccurrences = 0;

for (int i = 0; i < str.Length - substr.Length + 1; i++)
{
    bool flag = true;

    for (int j = 0; j < substr.Length; j++)
    {
        if (str[i + j] != substr[j])
        {
            flag = false;
            break;
        }
    }

    if (flag)
    {
        cntOccurrences++;
    }
}

Console.WriteLine($"Количество вхождений подстроки: {cntOccurrences}");

/*5.Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.*/

Console.WriteLine("Задание 5");

Console.WriteLine("Введите стандартную цену бутылки:");
int normPrice = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите величину скидки:");
int salePrice = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите стоимость отпуска");
int holidayPrice = Convert.ToInt32(Console.ReadLine());


if (salePrice > 0 && salePrice <= 100)
{
    double benefit = normPrice * (salePrice / 100.0);

    int cntDays = Convert.ToInt32(Math.Ceiling(holidayPrice / benefit));

    Console.WriteLine(cntDays);
}
else
{
    Console.WriteLine("Значение скидки не корректное");
}



/*6.Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с
различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
(процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде
структуры: наименование типа напитка и процент спирта.*/

Console.WriteLine("Задание 6");

AlcoholicBeverage gin = new AlcoholicBeverage 
{
    alcoholicBeverageName = "Gin",
    alcoholPercentage = 37.5m
};

AlcoholicBeverage absinthe = new AlcoholicBeverage
{
    alcoholicBeverageName = "Absinthe",
    alcoholPercentage = 60m
};

AlcoholicBeverage kvass = new AlcoholicBeverage
{
    alcoholicBeverageName = "Kvass",
    alcoholPercentage = 1.5m
};

AlcoholicBeverage sake = new AlcoholicBeverage
{
    alcoholicBeverageName = "Sake",
    alcoholPercentage = 15m
};

Student student1 = new Student
{
    id = 1,
    firstName = "Иван",
    lastName = "Алпатов",
    birthDate = new DateTime(2003, 2, 3),
    alcoholismType = AlcoholismType.AlcoholicStudent,
    alcoholVolume = 2m,
    alcoholicBeverage = gin
};

Student student2 = new Student
{
    id = 2,
    firstName = "Сергей",
    lastName = "Иванов",
    birthDate = new DateTime(2002, 5, 3),
    alcoholismType = AlcoholismType.DrinksOnHolidaysStudent,
    alcoholVolume = 5m,
    alcoholicBeverage = absinthe
};

Student student3 = new Student
{
    id = 3,
    firstName = "Света",
    lastName = "Васильева",
    birthDate = new DateTime(2000, 7, 16),
    alcoholismType = AlcoholismType.NonDrinkingStudent,
    alcoholVolume = 1.2m,
    alcoholicBeverage = kvass
};

Student student4 = new Student
{
    id = 4,
    firstName = "Игорь",
    lastName = "Огурцов",
    birthDate = new DateTime(2001, 8, 18),
    alcoholismType = AlcoholismType.LikesToDrinkStudent,
    alcoholVolume = 0.3m,
    alcoholicBeverage = sake
};

Student student5 = new Student
{
    id = 5,
    firstName = "Марина",
    lastName = "Косаткина",
    birthDate = new DateTime(2000, 12, 4),
    alcoholismType = AlcoholismType.AlcoholicStudent,
    alcoholVolume = 4m,
    alcoholicBeverage = gin
};

decimal volume = student1.alcoholVolume + student2.alcoholVolume + student3.alcoholVolume + student4.alcoholVolume + student5.alcoholVolume;
Console.WriteLine($"Общий объём выпитого: {volume}");

decimal volumeAlkohol = (student1.alcoholVolume * student1.alcoholicBeverage.alcoholPercentage) / 100 + 
    (student2.alcoholVolume * student2.alcoholicBeverage.alcoholPercentage) / 100 + 
    (student3.alcoholVolume * student3.alcoholicBeverage.alcoholPercentage) / 100 + 
    (student4.alcoholVolume * student4.alcoholicBeverage.alcoholPercentage) / 100 + 
    (student5.alcoholVolume * student5.alcoholicBeverage.alcoholPercentage) / 100;
Console.WriteLine($"Общий объём алкоголя: {volumeAlkohol}");

Console.WriteLine($"{student1.firstName} {student1.lastName}: выпил {(student1.alcoholVolume / volume) * 100}% от общего количества," +
    $" {(student1.alcoholicBeverage.alcoholPercentage * student1.alcoholVolume) / volumeAlkohol}% от общего количества спирта");
Console.WriteLine($"{student2.firstName} {student2.lastName}: выпил {(student2.alcoholVolume / volume) * 100}% от общего количества," +
    $" {(student2.alcoholicBeverage.alcoholPercentage * student2.alcoholVolume) / volumeAlkohol}% от общего количества спирта");
Console.WriteLine($"{student3.firstName} {student3.lastName}: выпил {(student3.alcoholVolume / volume) * 100}% от общего количества," +
    $" {(student3.alcoholicBeverage.alcoholPercentage * student3.alcoholVolume) / volumeAlkohol}% от общего количества спирта");
Console.WriteLine($"{student4.firstName} {student4.lastName}: выпил {(student4.alcoholVolume / volume) * 100}% от общего количества, " +
    $"{(student4.alcoholicBeverage.alcoholPercentage * student4.alcoholVolume) / volumeAlkohol}% от общего количества спирта");
Console.WriteLine($"{student5.firstName} {student5.lastName}: выпил {(student5.alcoholVolume / volume) * 100}% от общего количества, " +
    $"{(student5.alcoholicBeverage.alcoholPercentage * student5.alcoholVolume) / volumeAlkohol}% от общего количества спирта");






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


struct Student
{
    public int id;
    public string firstName;
    public string lastName;
    public DateTime birthDate;
    public AlcoholismType alcoholismType;
    public decimal alcoholVolume;
    public AlcoholicBeverage alcoholicBeverage;
}

enum AlcoholismType
{
    AlcoholicStudent,
    LikesToDrinkStudent,
    DrinksOnHolidaysStudent,
    NonDrinkingStudent
}

struct AlcoholicBeverage
{
    public string alcoholicBeverageName;
    public decimal alcoholPercentage;
}