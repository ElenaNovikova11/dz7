// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

void FillArray(int[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        array[i] = new Random().Next(1, 10);
}
 
void PArray (int[] array, int arrLength)
{
    if (arrLength == 0) return;
    Console.Write($"{array[arrLength - 1] } ");
    PArray (array, (arrLength-1));
}
 
Console.Clear();
Console.Write("Введите длину массива ");
//int n = int.Parse(Console.ReadLine());
int[] arraynew = new int [int.Parse(Console.ReadLine())];
FillArray(arraynew);
Console.WriteLine("Текущий массив: " + string.Join(" ", arraynew));
Console.Write("Перевернутый массив: ");
PArray(arraynew, arraynew.Length);