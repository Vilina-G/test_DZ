Console.WriteLine(
    "Задача: Написать программу, которая из имеющегося массива строк формируст массив из строк, длина которых \n"
    + "меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте \n"
    + "выполнения алгоритма. При решении но рекомендуется пользоваться коллекциями, лучше обойтись \n"
    + "исключительно массивами.");
Console.WriteLine();

string[] people = { "hello", "2", "world", ":-)" };

EnterArray();
FilterArray();

void EnterArray()
{
    for (int i = 0; i < people.Length; i++)

    {
        Console.Write($"{people[i]} ");
    }
    System.Console.WriteLine();

}

void FilterArray()
{
    for (int i = 0; i < people.Length; i++)
    {
        if (people[i].Length <= 3)
        {
            Console.Write($"{people[i]} ");
        }

    }
}