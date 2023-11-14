using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      пример: если нужно отнять хп и записать в файл
StreamReader hp1 = File.OpenText("hp.txt");
string hpcheck = hp1.ReadToEnd();
int hp = Convert.ToInt32(hpcheck);
int hpcurrent = hp - 10;
hp1.Close();
using (StreamWriter hp2 = new StreamWriter("hp.txt", false))
{
    hp2.Write(hpcurrent);
}
*/

class Program
{
    static void event1()        //первый ивент через поход
    {
        Console.Clear();
        Console.WriteLine("Вы идете по лесу. Вокруг ничего кроме шума ветра, деревьев и вашего шага.\n\n[Нажмите любую клавишу для продолжения]");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Вы идете дальше.");
        Thread.Sleep(1300);
        Console.Clear();
        Console.WriteLine("Вы идете дальше..");
        Thread.Sleep(1300);
        Console.Clear();
        Console.WriteLine("Вы идете дальше...");
        Thread.Sleep(1300);
        Console.Clear();
        Console.WriteLine("Вы услышали выстрелы спереди, понизу от горы, что находится справа.\nЧто вы будете делать?\n\n1.Идти прямо\n2.Обходить по горе");
        int ev1 = int.Parse(Console.ReadLine());
        switch (ev1)
        {
            case 1: //идти прямо 
                {
                    Console.Clear();
                    Console.WriteLine("Вы идете прямо.");
                    Thread.Sleep(1300);
                    Console.Clear();
                    Console.WriteLine("Вы идете прямо..");
                    Thread.Sleep(1300);
                    Console.Clear();
                    Console.WriteLine("Вы идете прямо...");
                    Thread.Sleep(600);
                    Console.Clear();
                    Random evev1 = new Random();
                    int revent1 = evev1.Next(2);
                    Console.WriteLine(revent1);
                    if (revent1 == 0)   //вариант 1 при: идти прямо (event1)
                    {
                        Console.WriteLine("Вы шли среди деревьев, озираясь по округе. К сожалению вы были не совсем осмотрительны. Вы упали в яму и, пока выбирались, очень устали. Наконец встав на твердую почву, вы поняли, что стрелков уже и след простыл.\n\n-10 здоровья\n\n[Нажмите любую клавишу чтобы продолжить]");
                        Console.ReadKey();
                        StreamReader hp1 = File.OpenText("hp.txt");
                        string hpcheck = hp1.ReadToEnd();
                        int hp = Convert.ToInt32(hpcheck);
                        int hpcurrent = hp - 10;
                        hp1.Close();
                        using (StreamWriter hp2 = new StreamWriter("hp.txt", false))
                        {
                            hp2.Write(hpcurrent);
                        }
                    }
                    if (revent1 == 1)   //вариант 2 при: идти прямо (event1)
                    {
                        Console.WriteLine("in progress " + revent1);
                    }
                    break;
                }
            case 2: //идти по горе
                {
                    Console.Clear();
                    Console.WriteLine("Вы поднимаетесь.");
                    Thread.Sleep(1300);
                    Console.Clear();
                    Console.WriteLine("Вы поднимаетесь..");
                    Thread.Sleep(1300);
                    Console.Clear();
                    Console.WriteLine("Вы поднимаетесь...");
                    Thread.Sleep(600);
                    Console.Clear();
                    Console.WriteLine("Вы идете по горе.");
                    Thread.Sleep(1300);
                    Console.Clear();
                    Console.WriteLine("Вы идете по горе..");
                    Thread.Sleep(1300);
                    Console.Clear();
                    Console.WriteLine("Вы идете по горе...");
                    Thread.Sleep(600);
                    Console.Clear();

                    Random evev2 = new Random();
                    int revent2 = evev2.Next(2);
                    if (revent2 == 0)   //вариант 1 при: идти по горе (event1)
                    {
                        Console.WriteLine("Взбираться на гору - дело нелёгкое. Но, запыхавшись, вы это сделали. Из-за спины донеслись звуки еще нескольких выстрелов.\nВы увидели двух персон, держащих в обеих руках огнестрел. Кажется они что-то ждут.\n\nЧто будете делать?\n\n1.Выстрелить издалека\n2.Подкрасться\n3.Ничего");
                        int p_ev1 = int.Parse(Console.ReadLine());
                        switch (p_ev1)
                        {
                            case 1: //выстрелить издалека
                                {
                                    //if have gun то стрелять если нет то назад
                                    break;
                                }
                            case 2: //подкрасться
                                {
                                    Random p_ev1_sneak = new Random();
                                    int p_ev_sneak = p_ev1_sneak.Next(2);
                                    if (p_ev_sneak == 0)
                                    {
                                        Console.WriteLine("получилось");
                                    }
                                    if (p_ev_sneak == 1)
                                    {
                                        Console.WriteLine("не получилось");
                                    }
                                    break;
                                }
                            case 3: //подождать
                                {
                                    Random p_ev1_wait = new Random();
                                    int p_ev_wait = p_ev1_wait.Next(2);
                                    if (p_ev_wait == 0)
                                    {
                                        Console.WriteLine("получилось");
                                    }
                                    if (p_ev_wait == 1)
                                    {
                                        Console.WriteLine("не получилось");
                                    }
                                    break;
                                }
                        }
                    }

                    if (revent2 == 1)   //вариант 2 при: идти по горе (event1)
                    {
                        Console.WriteLine("Тактический обход занял некоторое время и вы надеетесь, что не зря карабкались полчаса...\n\n[Нажмите любую клавишу чтобы продолжить]");
                        Console.ReadKey();
                        Console.WriteLine("На удивление, спустя еще час блужданий по лесу, вы наткнулись на одинокий, затхлый домишко.\n\n\n[Нажмите любую клавишу чтобы продолжить]");
                        Console.ReadKey();
                        break;
                    }
                    break;
                }
            default:
                {
                    Console.Clear();
                    break;
                }
        }
    }
    static void event2()        //второй ивент через поход
    {
        Console.Clear();
        Console.WriteLine("2");
    }
    static void event3()        //третий ивент через поход
    {
        Console.Clear();
        Console.WriteLine("3");
    }
    static void Inventory()     //показывает инвентарь
    {
        StreamReader s1 = File.OpenText("inventory.txt");
        string read1 = s1.ReadToEnd();
        s1.Close();

        Console.WriteLine("Предметы: ");
        Console.WriteLine(read1);
        Console.ReadKey();
    }
    static void BuyImitation()  //имитация покупки
    {
        Random rand = new Random();
        int rBuyImitation = rand.Next(3);
        int rTime = rand.Next(2100);
        int rTime1 = rand.Next(1100);
        int rTime2 = rand.Next(2100);
        int rTime3 = rand.Next(1100);
        int rTime4 = rand.Next(2100);
        int rTime5 = rand.Next(1100);
        int rTime6 = rand.Next(1500);
        int rTimeF = rand.Next(300);
        Console.WriteLine(rBuyImitation);
        /*if (rBuyImitation == 0)
        {
            Console.Clear();
            Console.WriteLine("Подтверждение операции");
            Thread.Sleep(2100);
            Console.WriteLine("Обработка транзакции - 0%");
            Thread.Sleep(570);
            Console.WriteLine("Обработка транзакции - 12%");
            Thread.Sleep(800);
            Console.WriteLine("Обработка транзакции - 34%");
            Thread.Sleep(350);
            Console.WriteLine("Обработка транзакции - 57%");
            Thread.Sleep(700);
            Console.WriteLine("Обработка транзакции - 81%");
            Thread.Sleep(1300);
            Console.WriteLine("Обработка транзакции - 100%");
            Thread.Sleep(300);
        }
        if (rBuyImitation == 1)
        {
            Console.Clear();
            Console.WriteLine("Подтверждение операции");
            Thread.Sleep(2100);
            Console.WriteLine("Обработка транзакции - 0%");
            Thread.Sleep(370);
            Console.WriteLine("Обработка транзакции - 6%");
            Thread.Sleep(450);
            Console.WriteLine("Обработка транзакции - 15%");
            Thread.Sleep(1350);
            Console.WriteLine("Обработка транзакции - 44%");
            Thread.Sleep(700);
            Console.WriteLine("Обработка транзакции - 52%");
            Thread.Sleep(1300);
            Console.WriteLine("Обработка транзакции - 76%");
            Thread.Sleep(1130);
            Console.WriteLine("Обработка транзакции - 100%");
            Thread.Sleep(300);
        }
        if (rBuyImitation == 2)
        {
            Console.Clear();
            Console.WriteLine("Подтверждение операции");
            Thread.Sleep(2100);
            Console.WriteLine("Обработка транзакции - 0%");
            Thread.Sleep(270);
            Console.WriteLine("Обработка транзакции - 1%");
            Thread.Sleep(1200);
            Console.WriteLine("Обработка транзакции - 26%");
            Thread.Sleep(1350);
            Console.WriteLine("Обработка транзакции - 51%");
            Thread.Sleep(700);
            Console.WriteLine("Обработка транзакции - 76%");
            Thread.Sleep(980);
            Console.WriteLine("Обработка транзакции - 100%");
            Thread.Sleep(300);
        }*/

        if (rBuyImitation == 0)
        {
            Console.Clear();
            Console.WriteLine("Подтверждение операции");
            Thread.Sleep(rTime);
            Console.WriteLine("Обработка транзакции - 0%");
            Thread.Sleep(rTime1);
            Console.WriteLine("Обработка транзакции - 12%");
            Thread.Sleep(rTime2);
            Console.WriteLine("Обработка транзакции - 34%");
            Thread.Sleep(rTime3);
            Console.WriteLine("Обработка транзакции - 57%");
            Thread.Sleep(rTime4);
            Console.WriteLine("Обработка транзакции - 81%");
            Thread.Sleep(rTime5);
            Console.WriteLine("Обработка транзакции - 100%");
            Thread.Sleep(rTimeF);
        }
        if (rBuyImitation == 1)
        {
            Console.Clear();
            Console.WriteLine("Подтверждение операции");
            Thread.Sleep(rTime);
            Console.WriteLine("Обработка транзакции - 0%");
            Thread.Sleep(rTime1);
            Console.WriteLine("Обработка транзакции - 6%");
            Thread.Sleep(rTime2);
            Console.WriteLine("Обработка транзакции - 15%");
            Thread.Sleep(rTime3);
            Console.WriteLine("Обработка транзакции - 44%");
            Thread.Sleep(rTime4);
            Console.WriteLine("Обработка транзакции - 52%");
            Thread.Sleep(rTime5);
            Console.WriteLine("Обработка транзакции - 76%");
            Thread.Sleep(rTime6);
            Console.WriteLine("Обработка транзакции - 100%");
            Thread.Sleep(rTimeF);
        }
        if (rBuyImitation == 2)
        {
            Console.Clear();
            Console.WriteLine("Подтверждение операции");
            Thread.Sleep(rTime);
            Console.WriteLine("Обработка транзакции - 0%");
            Thread.Sleep(rTime1);
            Console.WriteLine("Обработка транзакции - 1%");
            Thread.Sleep(rTime2);
            Console.WriteLine("Обработка транзакции - 26%");
            Thread.Sleep(rTime3);
            Console.WriteLine("Обработка транзакции - 51%");
            Thread.Sleep(rTime4);
            Console.WriteLine("Обработка транзакции - 76%");
            Thread.Sleep(rTime5);
            Console.WriteLine("Обработка транзакции - 100%");
            Thread.Sleep(rTimeF);
        }

    }
    static void walkZoneImitation()
    {
        Console.Clear();
        Console.WriteLine("Вы идете в Зону.");
        Thread.Sleep(1300);
        Console.Clear();
        Console.WriteLine("Вы идете в Зону..");
        Thread.Sleep(1300);
        Console.Clear();
        Console.WriteLine("Вы идете в Зону...");
        Thread.Sleep(1300);
    }
    static void walkImitation()
    {
        Console.Clear();
        Console.WriteLine("Вы идете.");
        Thread.Sleep(1300);
        Console.Clear();
        Console.WriteLine("Вы идете..");
        Thread.Sleep(1300);
        Console.Clear();
        Console.WriteLine("Вы идете...");
        Thread.Sleep(1300);
    }

    //MAIN
    static void Main(string[] args)
//MAIN
    {
        StreamReader hp1 = File.OpenText("hp.txt");     //открывает файл с хп
        string hpcheck = hp1.ReadToEnd();               //проверяет значение файла и отдает его в hpcheck
        hp1.Close();
        StreamReader hpMax1 = File.OpenText("hpMax.txt");     //открывает файл с макс. хп
        string hpMaxcheck = hpMax1.ReadToEnd();               //проверяет значение файла и отдает его в hpMaxcheck
        hpMax1.Close();
        StreamReader money1 = File.OpenText("money.txt");   //открывает файл с балансом
        string moneycheck = money1.ReadToEnd();             //проверяет значение файла и отдает его в moneycheck
        money1.Close();
        int hp = Convert.ToInt32(hpcheck);              //hp - текущее хп
        int hpMax = Convert.ToInt32(hpMaxcheck);               //hpMax - максимальное хп
        int money = Convert.ToInt32(moneycheck);            //money - текущий баланс
        if (hp <= 0)                //процедура проверки. если хп < 0, то не запустит
        {
            Console.WriteLine("Вы мертвы");
            return;
        }
        if (hp > hpMax)
        {
            string filePath = "hp.txt";  // Путь к файлу, который нужно изменить
            string currentValue = File.ReadAllText(filePath);   // Читаем текущее значение из файла
            int intValue = Convert.ToInt32(currentValue);   // Преобразуем текущее значение в тип int
            intValue = hpMax;  // Изменяем значение
            string newValue = intValue.ToString();  // Преобразуем значение обратно в строку
            File.WriteAllText(filePath, newValue);  // Записываем новое значение в файл
            Console.WriteLine("Уровень Вашего здоровья превысил максимальный. \nПожалуйста, перезапустите программу.\n");
            return;
        }
        Console.Clear();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Здоровье: " + hp + "/" + hpMax);
            Console.WriteLine("Деньги: " + money);
            Console.WriteLine("\nЧе делаем?");
            Console.WriteLine("\n1.Идти в Зону\n2.Идти в Магазин\n3.Инвентарь\n4.Вылечиться\n");
            string k = Console.ReadLine();
            
            if (k == "1")    //1.Идти в зону
            {
                walkZoneImitation();        //типа идешь (метод)
                Console.Clear();
                Random rand = new Random();
                int revent = rand.Next(2);
                Console.WriteLine(revent);
                if (revent == 0)     //!первый ивент
                {
                    event1();
                }
                if (revent == 1)     //!второй ивент
                {
                    event2();
                }
                if (revent == 2)     //!третий ивент
                {
                    event3();
                } 
                Console.ReadKey();
            }
            if (k == "2")       //2.Магазин
            {
                string heal1 = "Аптечка индивидуальная";
                int heal1_cost = 5190;
                string heal2 = "Аптечка армейская";
                int heal2_cost = 8280;
                string bandage = "Бинт";
                int bandage_cost = 590;
                string gun_rifle1 = "Винтовка Мосина";
                int gun_rifle1_cost = 21800;
                string gun_rifle1_ammo = "Коробка патронов 7.62x54 (20 шт.)";
                int gun_rifle1_ammo_cost = 6220;

                Console.Clear();
                Console.WriteLine("Магазин: \n");

                Console.WriteLine("1. " + heal1 + " - " + heal1_cost);
                Console.WriteLine("2. " + heal2 + " - " + heal2_cost);
                Console.WriteLine("3. " + bandage + " - " + bandage_cost);
                Console.WriteLine("4. " + gun_rifle1 + " - " + gun_rifle1_cost);
                Console.WriteLine("5. " + gun_rifle1_ammo + " - " + gun_rifle1_ammo_cost);

                Console.WriteLine("\nВведите номер покупки");
                int shop_buy = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (shop_buy)
                {
                    case 1: //аптечка индивидуальная
                        Console.WriteLine("Вы выбрали: " + heal1 + "\nЦена: " + heal1_cost + "\nПодтвердите покупку (y)");
                        string shop_confirm = Console.ReadLine();
                        if (shop_confirm == "y")
                        {
                            if (money >= heal1_cost)
                            {
                                BuyImitation();

                                string filePath = "money.txt";
                                string currentValue = File.ReadAllText(filePath);
                                int intValue = Convert.ToInt32(currentValue);
                                intValue = money - heal1_cost;
                                string newValue = intValue.ToString();
                                File.WriteAllText(filePath, newValue);

                                string newItemToInventory = "inventory.txt";
                                using (StreamWriter writer = new StreamWriter(newItemToInventory, true))
                                {
                                    // Записываем новую строку в файл
                                    writer.WriteLine(heal1);
                                }

                                Console.Clear();
                                Console.WriteLine("Покупка подтверждена");
                                Console.WriteLine("\nВы купили: " + heal1);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Подтверждение операции");
                                Thread.Sleep(2100);
                                Console.WriteLine("\nНедостаточно средств для покупки.\nВаш баланс - " + money + "\nНе хватает " + (heal1_cost - money) + " для покупки");
                            }

                        }

                        break;
                    case 2: //аптечка армейская
                        Console.WriteLine("Вы выбрали: " + heal2 + "\nЦена: " + heal2_cost + "\nПодтвердите покупку (y)");
                        shop_confirm = Console.ReadLine();
                        if (shop_confirm == "y")
                        {
                            if (money >= heal2_cost)
                            {
                                BuyImitation();

                                string filePath = "money.txt";
                                string currentValue = File.ReadAllText(filePath);
                                int intValue = Convert.ToInt32(currentValue);
                                intValue = money - heal2_cost;
                                string newValue = intValue.ToString();
                                File.WriteAllText(filePath, newValue);

                                string newItemToInventory = "inventory.txt";
                                using (StreamWriter writer = new StreamWriter(newItemToInventory, true))
                                {
                                    // Записываем новую строку в файл
                                    writer.WriteLine(heal2);
                                }

                                Console.Clear();
                                Console.WriteLine("Покупка подтверждена");
                                Console.WriteLine("\nВы купили: " + heal2);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Подтверждение операции");
                                Thread.Sleep(2100);
                                Console.WriteLine("\nНедостаточно средств для покупки.\nВаш баланс - " + money + "\nНе хватает " + (heal2_cost - money) + " для покупки");
                            }

                        }

                        break;
                    case 3:
                        Console.WriteLine("Вы выбрали: " + bandage + "\nЦена: " + bandage_cost + "\nПодтвердите покупку (y)");
                        shop_confirm = Console.ReadLine();
                        if (shop_confirm == "y")
                        {
                            if (money >= bandage_cost)
                            {
                                BuyImitation();

                                string filePath = "money.txt";
                                string currentValue = File.ReadAllText(filePath);
                                int intValue = Convert.ToInt32(currentValue);
                                intValue = money - bandage_cost;
                                string newValue = intValue.ToString();
                                File.WriteAllText(filePath, newValue);

                                string newItemToInventory = "inventory.txt";
                                using (StreamWriter writer = new StreamWriter(newItemToInventory, true))
                                {
                                    // Записываем новую строку в файл
                                    writer.WriteLine(bandage);
                                }

                                Console.Clear();
                                Console.WriteLine("Покупка подтверждена");
                                Console.WriteLine("\nВы купили: " + bandage);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Подтверждение операции");
                                Thread.Sleep(2100);
                                Console.WriteLine("\nНедостаточно средств для покупки.\nВаш баланс - " + money + "\nНе хватает " + (bandage_cost - money) + " для покупки");
                            }

                        }

                        break;
                    case 4:
                        Console.WriteLine("Вы выбрали: " + gun_rifle1 + "\nЦена: " + gun_rifle1_cost + "\nПодтвердите покупку (y)");
                        shop_confirm = Console.ReadLine();
                        if (shop_confirm == "y")
                        {
                            if (money >= gun_rifle1_cost)
                            {
                                BuyImitation();

                                string filePath = "money.txt";
                                string currentValue = File.ReadAllText(filePath);
                                int intValue = Convert.ToInt32(currentValue);
                                intValue = money - gun_rifle1_cost;
                                string newValue = intValue.ToString();
                                File.WriteAllText(filePath, newValue);

                                string newItemToInventory = "inventory.txt";
                                using (StreamWriter writer = new StreamWriter(newItemToInventory, true))
                                {
                                    // Записываем новую строку в файл
                                    writer.WriteLine(gun_rifle1);
                                }

                                Console.Clear();
                                Console.WriteLine("Покупка подтверждена");
                                Console.WriteLine("\nВы купили: " + gun_rifle1);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Подтверждение операции");
                                Thread.Sleep(2100);
                                Console.WriteLine("\nНедостаточно средств для покупки.\nВаш баланс - " + money + "\nНе хватает " + (gun_rifle1_cost - money) + " для покупки");
                            }

                        }

                        break;
                    case 5:
                        Console.WriteLine("Вы выбрали: " + gun_rifle1_ammo + "\nЦена: " + gun_rifle1_ammo_cost + "\nПодтвердите покупку (y)");
                        shop_confirm = Console.ReadLine();
                        if (shop_confirm == "y")
                        {
                            if (money >= gun_rifle1_ammo_cost)
                            {
                                BuyImitation();

                                string filePath = "money.txt";
                                string currentValue = File.ReadAllText(filePath);
                                int intValue = Convert.ToInt32(currentValue);
                                intValue = money - gun_rifle1_ammo_cost;
                                string newValue = intValue.ToString();
                                File.WriteAllText(filePath, newValue);

                                string newItemToInventory = "inventory.txt";
                                using (StreamWriter writer = new StreamWriter(newItemToInventory, true))
                                {
                                    // Записываем новую строку в файл
                                    writer.WriteLine(gun_rifle1_ammo);
                                }

                                Console.Clear();
                                Console.WriteLine("Покупка подтверждена");
                                Console.WriteLine("\nВы купили: " + gun_rifle1_ammo);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Подтверждение операции");
                                Thread.Sleep(2100);
                                Console.WriteLine("\nНедостаточно средств для покупки.\nВаш баланс - " + money + "\nНе хватает " + (gun_rifle1_ammo_cost - money) + " для покупки");
                            }

                        }
                        break;
                    default:
                        Console.WriteLine("Выбран некорректный номер предмета");
                        break;
                }

                Console.ReadKey();
            }
            if (k == "3")       //3.Инвентарь
            {
                Console.Clear();
                Console.WriteLine("Инвентарь:\n");
                Inventory();
            }

            void StartDialogDoctor()    //стартовый (привет) диалог
            {
                Console.Clear();
                Random rand1  = new Random();
                int rHelloDoc = rand1.Next(3);
                if (rHelloDoc == 0)
                {
                    Console.WriteLine("Хирург: Что-то ты бледный. Может укольчик сделаем?");
                }
                if (rHelloDoc == 1)
                {
                    Console.WriteLine("Хирург: Ну здравствуй, калека. Лечиться пришёл?");
                }
                if (rHelloDoc == 2)
                {
                    Console.WriteLine("Хирург: Привет, боец. Опять лататься будем?");
                }
                Console.WriteLine("1.Вылечи меня\n2.Что нового в Зоне?\n3.[Sample Text]\n\n4.Пока\n\n");
                string DialogDoctorChoice = Console.ReadLine();

                if (DialogDoctorChoice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Сейчас посмотрим.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Сейчас посмотрим..");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Сейчас посмотрим...");
                    Thread.Sleep(1000);
                    Console.Clear();

                    if (hp < hpMax)         //например хп 90/100. хп < макс.хп -- лечим
                    {
                        DoctorHeal();
                        return;
                    }
                    else                    //иначе (хп 100/100) не лечим
                    {
                        DoctorComplain();
                        Console.ReadKey();
                        //return;
                    }
                }
            }

            void DoctorHeal()   //если хп < максимума - хилить
            {
                int healCost = (hpMax - hp) * 41;

                if (hp > 50)
                {
                    Console.WriteLine("Хирург: Смотри, ковбой. Состояние твоё в порядке, единственное я бы тебе пару пластырей наклеил.");
                    Thread.Sleep(1500);
                }
                if (hp <= 50)
                {
                    Console.WriteLine("Хирург: Смотри, ковбой. Состояние у тебя действительно хуже среднего...");
                    Thread.Sleep(1500);
                }
                if (hp <= 30)
                {
                    Console.WriteLine("Хирург: Ты как сюда дошёл вообще?");
                    Thread.Sleep(1500);
                }
                Console.WriteLine("Хирург: Значит так. Расценки у меня порядочные, ходить сможешь. Главное, деньги при себе чтоб были, а там гуляй Вася.\n");
                Thread.Sleep(1250);
                Console.WriteLine("Ваше здоровье: " + hp + "/" + hpMax + "\nСтоимость лечения: " + healCost);
                Thread.Sleep(750);

                if (money >= healCost)
                {
                    Console.WriteLine("\n1.Я согласен, вылечи меня.\n2.Знаешь что, док? Лечи себя сам.");
                    string DialogDoctorHealChoice = Console.ReadLine();

                    if (DialogDoctorHealChoice == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Хирург: Сейчас мы тебя подлатаем.");
                        Thread.Sleep(1750);
                        Console.Clear();
                        Console.Write("Хирург: Да от тебя фонит, как от реактора. ");
                        Thread.Sleep(1750);
                        Console.WriteLine("Шучу.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Хирург: Почти закончили...");
                        Thread.Sleep(2000);
                        Console.Clear();

                        StreamReader hp1 = File.OpenText("hp.txt");
                        string hpcheck = hp1.ReadToEnd();
                        int hp = Convert.ToInt32(hpcheck);
                        int hpcurrent = hpMax;
                        hp1.Close();
                        using (StreamWriter hp2 = new StreamWriter("hp.txt", false))
                        {
                            hp2.Write(hpcurrent);
                        }
                        money = money - healCost;
                        Console.WriteLine("Хирург: Ну вот и всё! Шагай давай, ковбой");
                        Console.ReadKey();
                    }
                    if (DialogDoctorHealChoice != "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Хирург: Ну... На “нет” и суда нет.");
                        Console.ReadKey();
                    }
                }

                if (money < healCost)
                {
                    Console.WriteLine("\n\n1.Знаешь что, док? Лечи себя сам.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Хирург: Ну... На “нет” и суда нет.");
                    Console.ReadKey();
                }
            }

            void DoctorComplain()   //если хп = максимум - не хилить и прогнать
            {
                Console.WriteLine("Хирург: Если тебе с твоим здоровьем плохо - то я, должно быть, вообще уже мёртв.");
            }

            if (k == "4")       //4.Вылечиться
            {

                Console.WriteLine("\n1.Пойти к доктору\n2.Вылечиться используя аптечку\n");
                string healChoice = Console.ReadLine();

                if (healChoice == "1")    //1.доктор
                {
                    walkImitation();
                    StartDialogDoctor();



                    /*
                     * тут должен быть диалог с доктором. Ему можно добавить пару опций, типа:
                     * 1)Вылечи меня
                     * 2)Что нового в зоне
                     * 3)и так далее
                     * n)Пока 
                     * или типа того. 
                    */
                }
                if (healChoice == "2")
                {
                    Console.WriteLine("2");
                    /*
                     * здесь должен быть стримридер, который ищет наличие в инвентаре аптечки (любой) и хилит. Если аптечки нет, то тут два варика:
                     * 1) если аптечки нет, то вариант "2.Вылечиться используя аптечку" не появляется вообще;
                     * 2) если аптечки нет, то при выборе варианта "2.блаблабла" появляется надпись мол нету аптечки
                    */
                }
                Console.ReadKey();
            }
        }
        Console.WriteLine("\n\nКонец программы");
    }
    
}