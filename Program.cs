using System;

Console.WriteLine("Готов начать?");

string qeshion = Console.ReadLine();

int counter = 0;

if (qeshion.ToLower() == "да")
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
            Console.WriteLine("Никита  лох, ответ не правельный)");

            counter++;
        }
    }
    Console.WriteLine("Нажмите любую кнопку, для завершения роботы програмы:");
    Console.ReadKey();
    return;
}

if (qeshion.ToLower() == "нет")
{
    Console.WriteLine("ну ладно, жаль");
}
else 
{
    Console.WriteLine("Програма не смогла распадзнать ваше действие");
};

Console.ReadKey();