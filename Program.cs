using System;

Console.WriteLine("Готов начать?");

string qeshion = Console.ReadLine();

int counter = 0;

if (qeshion == "да")
{
    Console.WriteLine(" Реши пример √9=?");

    int answer = int.Parse(Console.ReadLine());

    if (answer == 3)
    {
        Console.WriteLine("Молодец");

    }
    if (answer != 3)
    {

        while (counter < 5)
        {
            Console.WriteLine("Ты лох, ответ не правельный)");

            counter++;
        }
    }
}
else
{
    Console.WriteLine("ну ладно, жаль");
};

Console.ReadKey();