/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int getArrayLengthFromUser(string message)
{
    Console.WriteLine(message);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}
int[] generateArray(int length)
{
    int[] array = new int [length];
    int count = 1;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите значение для числа {count++}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int sumOfPositiveNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}
void printArray(int [] array)
{
    for (int i = 0; i < array.Length ; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}
int userLength = getArrayLengthFromUser("Введите требуемое количество чисел");
int [] array = generateArray(userLength);
printArray(array);
int sum = sumOfPositiveNumbers(array);
Console.WriteLine($"Количество введенных чисел больше 0 равно {sum}");