
//создаём массив. выбрали вариант, когда задаём данные при старте алгоритма
﻿string[] array1 = new string[4] {"hello", "2", "world", ":-)"};

//выбираем строки, длина которых меньше трёх
string[] array2 = new string[array1.Length];

//мотод, который выбирает строки, длина которых меньше трёх.
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

//печатаем массив
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


SecondArray(array1, array2); //вызываем метод SecondArray
Console.WriteLine("В заданном массиве строки, длина которых меньше трёх: "); //просто для информативности
PrintArray(array2); //печатаем массив