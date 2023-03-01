// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 1.Ввод числа

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// 2. Объявление массива и ввод пользователем элементов массива
int[] CreateArray(int size) // функция создания массива int
{
    return new int[size];
}

int[] FillArrayFor(int size) // метод по заполнению массива c for
{
    int[] array = CreateArray(size);
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} элемент массива: ");
    }
    return array;
}

// 3. Подсчет положительных чисел
int CountEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int size = Prompt("Введите размер массива: ");
int[] array = FillArrayFor(size);
Console.WriteLine($"Чисел больше нуля: {CountEvenNumbers(array)}");