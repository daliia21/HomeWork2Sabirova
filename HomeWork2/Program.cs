using static System.Runtime.InteropServices.JavaScript.JSType;


/*Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского
счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей
значение и вывести это значение на печать.*/

//Console.WriteLine("Упражнение 3.1");


BankAccount type = BankAccount.Savings;

Console.WriteLine($"Вид банковского счета - {type}");


/*Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском
счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
значениями и напечатать результат.*/

//Console.WriteLine("Упражнение 3.2");



BankAcc acc = new BankAcc();
acc.numberAcc = 3445678954347865;
acc.typeAcc = "Сберегательный";
acc.balanceAcc = 3452;
acc.Print();




/*Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
распечатать.*/

//Console.WriteLine("Упражнение 3.1");




employeeProfile newProfile = new employeeProfile();
newProfile.name = "Dalia";
newProfile.VUZ = VUZ.KGU;
newProfile.Print();



struct BankAcc
{
    public long numberAcc;
    public string typeAcc;
    public double balanceAcc;
    public void Print()
    {
        Console.WriteLine($"Номер счета - {numberAcc}, тип счета - {typeAcc}, баланс счета - {balanceAcc}");
    }
}

enum BankAccount
{
    Сurrent,
    Savings
}

struct employeeProfile
{
    public string name;
    public VUZ VUZ;
    public void Print()
    {
        Console.WriteLine($"Имя работника - {name}, Вуз - {VUZ}");
    }
}

enum VUZ
{
    KGU,
    KAI,
    KHTI
}
