// Задача 29
// Напишите метод, который задает массив из 8 элементов и выводит их на экран.

// Числа задаю рандомно.

void FillArrey(int[] colection)
{
    int length = colection.Length;
    int index = 0;

    while(index < length)
    {
        colection[index] = new Random().Next(1, 8);
        colection[0]=8;
        index++;
    }
}
void PrintArrey(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] arrey = new int[8];

FillArrey(arrey);
PrintArrey(arrey);

